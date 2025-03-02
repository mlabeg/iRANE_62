// HorizontalCrossfader.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace iRANE_62.Controls
{
    public class CrossfaderSlider : Control
    {
        private float position;  // 0.0f (left, full chanel1) to 1.0f (right, full chanel2)

        public event EventHandler PositionChanged;

        public CrossfaderSlider()
        {
            this.Width = 100;  // Wide for horizontal movement
            this.Height = 30;  // Narrow height
            this.position = 0.5f;  // Center (equal mix)
            this.BackColor = SystemColors.Control;
            this.ForeColor = Color.Black;
            this.DoubleBuffered = true;
        }

        public float Position
        {
            get => position;
            set
            {
                value = Math.Max(0.0f, Math.Min(1.0f, value));
                if (position != value)
                {
                    position = value;
                    PositionChanged?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle area = ClientRectangle;
            int borderWidth = 2;

            // Draw background
            using (SolidBrush backgroundBrush = new SolidBrush(BackColor))
            {
                g.FillRectangle(backgroundBrush, area);
            }

            // Draw border
            using (Pen borderPen = new Pen(ForeColor, borderWidth))
            {
                g.DrawRectangle(borderPen, area.X, area.Y, area.Width - 1, area.Height - 1);
            }

            // Calculate slider position (horizontal)
            float sliderWidth = area.Width * 0.1f;  // 10% of width for slider
            float trackWidth = area.Width - sliderWidth;  // Available track width
            float sliderLeft = trackWidth * position;  // Left edge moves from 0 to trackWidth

            RectangleF sliderRect = new RectangleF(
                area.X + sliderLeft,
                area.Y + borderWidth,
                sliderWidth,
                area.Height - (2 * borderWidth)
            );

            // Draw slider
            using (SolidBrush sliderBrush = new SolidBrush(ForeColor))
            {
                g.FillRectangle(sliderBrush, sliderRect);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UpdatePositionFromMousePosition(e.X);
                Capture = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Capture)
            {
                UpdatePositionFromMousePosition(e.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            Capture = false;
        }

        private void UpdatePositionFromMousePosition(int x)
        {
            float width = ClientRectangle.Width;
            float sliderWidth = width * 0.1f;
            float trackWidth = width - sliderWidth;
            float proportion = (float)x / width;  // 0 to 1 across full width
            proportion = Math.Max(0.0f, Math.Min(1.0f, proportion));  // Clamp to 0-1
            Position = proportion;  // Map directly to 0-1 range
        }
    }
}