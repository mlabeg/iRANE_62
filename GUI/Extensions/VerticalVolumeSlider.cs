using NAudio.Gui;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace iRANE_62.Controls
{
    public class VerticalVolumeSlider : Control
    {
        private float volume;
        private float minimum = 0.0f;
        private float maximum = 1.0f;

        public event EventHandler VolumeChanged;

        public VerticalVolumeSlider()
        {
            this.Width = 30;  
            this.Height = 100;
            this.volume = 0f; 
            this.BackColor = SystemColors.Control;
            this.ForeColor = Color.Black;         
            this.DoubleBuffered = true;     
        }

        public float Volume
        {
            get => volume;
            set
            {
                value = Math.Max(Minimum, Math.Min(Maximum, value));
                if (volume != value)
                {
                    volume = value;
                    VolumeChanged?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        public float Minimum
        {
            get => minimum;
            set
            {
                if (value >= Maximum)
                    throw new ArgumentException("Minimum must be less than Maximum.");
                minimum = value;
                if (Volume < minimum) Volume = minimum;
                Invalidate();
            }
        }

        public float Maximum
        {
            get => maximum;
            set
            {
                if (value <= Minimum)
                    throw new ArgumentException("Maximum must be greater than Minimum.");
                maximum = value;
                if (Volume > maximum) Volume = maximum;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle area = ClientRectangle;
            int borderWidth = 2;

            using (SolidBrush backgroundBrush = new SolidBrush(BackColor))
            {
                g.FillRectangle(backgroundBrush, area);
            }

            using (Pen borderPen = new Pen(ForeColor, borderWidth))
            {
                g.DrawRectangle(borderPen, area.X, area.Y, area.Width - 1, area.Height - 1);
            }

            //Slider
            float range = Maximum - Minimum;
            float sliderHeight = area.Height * 0.1f;
            float volumeProportion = (Volume - Minimum) / range;
            float trackHeight = area.Height - sliderHeight; 
            float sliderTop = trackHeight - (trackHeight * volumeProportion); 

            sliderTop = Math.Max(0, Math.Min(trackHeight, sliderTop));

            RectangleF sliderRect = new RectangleF(
                area.X + borderWidth,
                sliderTop,
                area.Width - (2 * borderWidth),
                sliderHeight
            );

            using (SolidBrush sliderBrush = new SolidBrush(ForeColor))
            {
                g.FillRectangle(sliderBrush, sliderRect);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UpdateVolumeFromMousePosition(e.Y);
                Capture = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Capture)
            {
                UpdateVolumeFromMousePosition(e.Y);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            Capture = false;
        }

        private void UpdateVolumeFromMousePosition(int y)
        {
            float range = Maximum - Minimum;
            float height = ClientRectangle.Height;
            float proportion = 1.0f - ((float)y / height);
            proportion = Math.Max(0.0f, Math.Min(1.0f, proportion));  
            Volume = Minimum + (proportion * range);
        }
    }
}