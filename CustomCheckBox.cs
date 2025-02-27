using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emulator
{
   
    
    public class CustomCheckBox : CheckBox
    {
        private int textWidth = 130; 
        private const int CircleSize = 10; 
        private new const int Padding = 0; 
        private int innerCircleSize = 10; 
        private Color circleColor = Color.Black; 
        private Color innerCircleColor = Color.Red; 

        public Color CircleColor
        {
            get => circleColor;
            set
            {
                circleColor = value;
                this.Invalidate(); 
            }
        }

    
        public Color InnerCircleColor
        {
            get => innerCircleColor;
            set
            {
                innerCircleColor = value;
                this.Invalidate();
            }
        }

        public int TextWidth
        {
            get => textWidth;
            set
            {
                textWidth = value;
                this.Invalidate(); 
            }
        }

        public int InnerCircleSize
        {
            get => innerCircleSize;
            set
            {
                innerCircleSize = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
      
            pevent.Graphics.Clear(this.BackColor);

    
            Rectangle circleRect = new Rectangle(0, (this.Height - CircleSize) / 2, CircleSize, CircleSize);
            using (Pen pen = new Pen(circleColor))
            {
                pevent.Graphics.DrawEllipse(pen, circleRect);
            }

            if (this.Checked)
                {
                    int innerOffset = (CircleSize - innerCircleSize) / 2;
                    Rectangle innerCircle = new Rectangle(
                        circleRect.X + innerOffset,
                        circleRect.Y + innerOffset,
                        innerCircleSize,
                        innerCircleSize
                    );
                    using (Brush brush = new SolidBrush(innerCircleColor))
                    {
                        pevent.Graphics.FillEllipse(brush, innerCircle);
                    }
                }

          
            string displayedText = this.Text;
            Size textSize = TextRenderer.MeasureText(displayedText, this.Font);

            if (textSize.Width > textWidth)
            {
                while (textSize.Width > textWidth && displayedText.Length > 1)
                {
                    displayedText = displayedText.Substring(0, displayedText.Length - 1);
                    textSize = TextRenderer.MeasureText(displayedText + "...", this.Font);
                }
                displayedText += "...";
            }
     
            int textX = circleRect.Right + Padding;
            TextRenderer.DrawText(pevent.Graphics, displayedText, this.Font,
                new Rectangle(textX, 0, textWidth, this.Height), this.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
    }
}
