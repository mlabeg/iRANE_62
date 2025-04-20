namespace iRANE_62.Controls
{
    public class CrossfaderSlider : Control
    {
        private float position; 

        public event EventHandler PositionChanged;

        public CrossfaderSlider()
        {
            this.Width = 100;  
            this.Height = 30;  
            this.position = 0.5f;  
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

            using (SolidBrush backgroundBrush = new SolidBrush(BackColor))
            {
                g.FillRectangle(backgroundBrush, area);
            }

            using (Pen borderPen = new Pen(ForeColor, borderWidth))
            {
                g.DrawRectangle(borderPen, area.X, area.Y, area.Width - 1, area.Height - 1);
            }

            float sliderWidth = area.Width * 0.1f;  
            float trackWidth = area.Width - sliderWidth; 
            float sliderLeft = trackWidth * position; 

            RectangleF sliderRect = new RectangleF(
                area.X + sliderLeft,
                area.Y + borderWidth,
                sliderWidth,
                area.Height - (2 * borderWidth)
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
            float proportion = (float)x / width;  
            proportion = Math.Max(0.0f, Math.Min(1.0f, proportion)); 
            Position = proportion; 
        }
    }
}