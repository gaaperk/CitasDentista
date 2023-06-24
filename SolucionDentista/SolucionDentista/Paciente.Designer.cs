namespace SolucionDentista
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtanuncio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtTel = new SolucionDentista.RJTextBox();
            this.TxtAm = new SolucionDentista.RJTextBox();
            this.txtAp = new SolucionDentista.RJTextBox();
            this.TxtNom = new SolucionDentista.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Decker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 102;
            this.iconPictureBox1.Location = new System.Drawing.Point(327, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(102, 114);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Decker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer Apellido*";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Decker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Apellido*";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Decker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Núm. Telefonico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Location = new System.Drawing.Point(0, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 294);
            this.panel3.TabIndex = 12;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton3.FlatAppearance.BorderSize = 3;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(23, 193);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(202, 42);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Cerrar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton2.FlatAppearance.BorderSize = 3;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(23, 119);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(202, 42);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Nuevo";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton1.FlatAppearance.BorderSize = 3;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(21, 35);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(202, 42);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Guardar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.txtanuncio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 100);
            this.panel1.TabIndex = 13;
            // 
            // txtanuncio
            // 
            this.txtanuncio.Font = new System.Drawing.Font("Decker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanuncio.Location = new System.Drawing.Point(3, 48);
            this.txtanuncio.Multiline = true;
            this.txtanuncio.Name = "txtanuncio";
            this.txtanuncio.ReadOnly = true;
            this.txtanuncio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtanuncio.Size = new System.Drawing.Size(256, 34);
            this.txtanuncio.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Decker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Anuncio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(268, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 100);
            this.panel2.TabIndex = 14;
            // 
            // TxtTel
            // 
            this.TxtTel.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.TxtTel.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.TxtTel.Bordersize = 2;
            this.TxtTel.Font = new System.Drawing.Font("Decker", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTel.ForeColor = System.Drawing.Color.Black;
            this.TxtTel.Location = new System.Drawing.Point(562, 329);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTel.Multiline = false;
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Padding = new System.Windows.Forms.Padding(7);
            this.TxtTel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtTel.PlaceholderText = "Numero de contacto";
            this.TxtTel.Size = new System.Drawing.Size(250, 35);
            this.TxtTel.TabIndex = 18;
            this.TxtTel.Texts = "";
            this.TxtTel.UnderlineStyle = true;
            this.TxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
            // 
            // TxtAm
            // 
            this.TxtAm.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.TxtAm.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.TxtAm.Bordersize = 2;
            this.TxtAm.Font = new System.Drawing.Font("Decker", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAm.ForeColor = System.Drawing.Color.Black;
            this.TxtAm.Location = new System.Drawing.Point(562, 278);
            this.TxtAm.Margin = new System.Windows.Forms.Padding(5);
            this.TxtAm.Multiline = false;
            this.TxtAm.Name = "TxtAm";
            this.TxtAm.Padding = new System.Windows.Forms.Padding(7);
            this.TxtAm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtAm.PlaceholderText = "Segundo Apellido";
            this.TxtAm.Size = new System.Drawing.Size(250, 35);
            this.TxtAm.TabIndex = 17;
            this.TxtAm.Texts = "";
            this.TxtAm.UnderlineStyle = true;
            this.TxtAm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAm_KeyPress);
            // 
            // txtAp
            // 
            this.txtAp.BackColor = System.Drawing.SystemColors.Window;
            this.txtAp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.txtAp.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.txtAp.Bordersize = 2;
            this.txtAp.Font = new System.Drawing.Font("Decker", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAp.ForeColor = System.Drawing.Color.Black;
            this.txtAp.Location = new System.Drawing.Point(562, 228);
            this.txtAp.Margin = new System.Windows.Forms.Padding(5);
            this.txtAp.Multiline = false;
            this.txtAp.Name = "txtAp";
            this.txtAp.Padding = new System.Windows.Forms.Padding(7);
            this.txtAp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAp.PlaceholderText = "Primer Apellido";
            this.txtAp.Size = new System.Drawing.Size(250, 35);
            this.txtAp.TabIndex = 16;
            this.txtAp.Texts = "";
            this.txtAp.UnderlineStyle = true;
            this.txtAp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAp_KeyPress);
            // 
            // TxtNom
            // 
            this.TxtNom.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.TxtNom.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.TxtNom.Bordersize = 2;
            this.TxtNom.Font = new System.Drawing.Font("Decker", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.ForeColor = System.Drawing.Color.Black;
            this.TxtNom.Location = new System.Drawing.Point(562, 171);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNom.Multiline = false;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Padding = new System.Windows.Forms.Padding(7);
            this.TxtNom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNom.PlaceholderText = "Nombre del paciente";
            this.TxtNom.Size = new System.Drawing.Size(250, 35);
            this.TxtNom.TabIndex = 15;
            this.TxtNom.Texts = "";
            this.TxtNom.UnderlineStyle = true;
            this.TxtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNom_KeyPress);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 512);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtAm);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Paciente";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtanuncio;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel2;
        private RJTextBox TxtNom;
        private RJTextBox txtAp;
        private RJTextBox TxtAm;
        private RJTextBox TxtTel;
    }
}