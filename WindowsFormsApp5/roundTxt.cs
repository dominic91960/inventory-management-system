using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class roundTxt : UserControl
    {
        //fields
        private Color borderColor = Color.DimGray;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        //constructor
        public roundTxt()
        {
            InitializeComponent();
        }

        //properties
        public Color BorderColor 
        {
            get 
            { 
                return borderColor; 
            }

            set 
            { 
                borderColor = value;
                this.Invalidate();
            } 
        }
        
        public int BorderSize 
        { 
            get 
            { 
                return borderSize;
            }

            set 
            { 
                borderSize = value;
                this.Invalidate();
            } 
        }

        public bool UnderlinedStyle 
        { 
            get 
            { 
                return underlinedStyle; 
            }

            set 
            { 
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public bool PasswordChar
        {
            get 
            { 
                return textBox1.UseSystemPasswordChar;
            }

            set 
            { 
                textBox1.UseSystemPasswordChar = value;
            }
        }

        public bool Multiline
        {
            get 
            { 
                return textBox1.Multiline;
            }

            set 
            {
                textBox1.Multiline = value; 
            }
        }

        public override Color BackColor 
        {
            get 
            { 
                return base.BackColor; 
            }
            
            set 
            {
                base.BackColor = value; 
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor 
        {
            get
            {
                return base.ForeColor; 
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;

                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        public string Text_
        {
            get 
            { 
                return textBox1.Text;
            }

            set 
            {
                textBox1.Text = value;
            }
        }
        
        //overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //draw border
            using (Pen penBorder =  new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if(underlinedStyle)//line style
                {
                    graph.DrawLine(penBorder, 0, this.Height-1, this.Width, this.Height-1);
                }

                else//normal style
                {
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();

        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}
