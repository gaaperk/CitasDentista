using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionDentista
{
    [DefaultEvent("_TextChanged")]
    public partial class RJTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(1, 121, 203);
        private int bordersize = 2;
        private bool underlineStyle=false;
        private Color borderFocusColor=Color.FromArgb(35, 32, 35);
        private bool isFocused = false;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;

        public RJTextBox()
        {
            InitializeComponent();
        }
        // events

        public event EventHandler _TextChanged;

        // properties 

        [Category("RJ Code A")]
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
        [Category("RJ Code A")]
        public int Bordersize 
        { 
            get 
            { 
                return bordersize; 
            }

            set
            {
                bordersize = value;
                this.Invalidate ();
            }
        }
        [Category("RJ Code A")]
        public bool UnderlineStyle 
        {
            get 
            { 
                return underlineStyle; 
            }    
            set 
            { 
                underlineStyle = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code A")]
        public bool Multiline
        {
            get{ return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("RJ Code A")]
        public override Color BackColor
        {
            get { 
                return base.BackColor; 
            
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        
        }
        [Category("RJ Code A")]
        public override Color ForeColor {
            get
            {
                return base.ForeColor;
            }
            set { 
                base.ForeColor = value; 
                textBox1.ForeColor = value;
            }
        }
        [Category("RJ Code A")]
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
        [Category("RJ Code A") ]
        public string Texts
        {
            get {
                if (isPlaceholder)
                {
                    return "";
                }else
                   
                return textBox1.Text; 
            }
            set {                                        
                if (isPlaceholder)
                {
                    RemovePlaceholder();
                    textBox1.Text = value;
                   
                }
                   else

                    textBox1.Text = value;
                SetPlaceholder();

            }
        }
       

        [Category("RJ Code A")]
        public Color BorderFocus {

            get { 
                return borderFocusColor; 
            }
            set { 
                borderFocusColor = value; 
            
            }

                
                }
        [Category("RJ Code A")]
        public Color PlaceholderColor 
        { 
            get {  return placeholderColor; }
            set
            {
                placeholderColor = value;
            }                                       
            }

        [Category("RJ Code A")]
        public string PlaceholderText
        {
            get { return placeholderText; }

            set { 
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();

            }
        }

        private void SetPlaceholder()
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                
            }
        }
        private void RemovePlaceholder()
        {
            if( isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;

            }
        }


        /// overrideen metodos

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //draw border
            using (Pen penBorder = new Pen(borderColor, bordersize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (isFocused==false)
                {
                    if (underlineStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                    }
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlineStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                    }
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }

                
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode);
            UpdateControlHeight();
        }

        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad(e); 
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
