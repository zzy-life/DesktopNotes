using System.Drawing;

namespace System.Windows.Forms
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            this.FlatStyle = Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override bool ShowFocusCues
        {
            get { return false; }
        }

        public override Drawing.Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;

                int factor = 10;
                Color mouseDown = Color.FromArgb(value.A, Math.Max(0, value.R - factor),
                Math.Max(0, value.G - factor), Math.Max(0, value.B - factor));
                Color mouseOver = Color.FromArgb(value.A, Math.Min(255, value.R + factor),
                       Math.Min(255, value.G + factor), Math.Min(255, value.B + factor)); 
                this.FlatAppearance.MouseDownBackColor = mouseDown;
                this.FlatAppearance.MouseOverBackColor = mouseOver;
            }
        }
    }
}
