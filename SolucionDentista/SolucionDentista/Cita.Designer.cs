namespace SolucionDentista
{
    partial class Cita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAr = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtanuncio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Calendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmbH = new System.Windows.Forms.ComboBox();
            this.DGVB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCu = new System.Windows.Forms.ComboBox();
            this.cmbM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvance = new SolucionDentista.RJTextBox();
            this.txtNombre = new SolucionDentista.RJTextBox();
            this.txtCarnet = new SolucionDentista.RJTextBox();
            this.txtBP = new SolucionDentista.RJTextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Checked = true;
            this.rdbN.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbN.ForeColor = System.Drawing.Color.Black;
            this.rdbN.Location = new System.Drawing.Point(6, 26);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(151, 22);
            this.rdbN.TabIndex = 14;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "Nuevo Tratamiento";
            this.rdbN.UseVisualStyleBackColor = true;
            this.rdbN.MouseCaptureChanged += new System.EventHandler(this.rdbN_MouseCaptureChanged);
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbC.ForeColor = System.Drawing.Color.Black;
            this.rdbC.Location = new System.Drawing.Point(6, 58);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(172, 22);
            this.rdbC.TabIndex = 15;
            this.rdbC.Text = "Continuar Tratamiento";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.MouseCaptureChanged += new System.EventHandler(this.rdbC_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre del paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Número de Carnet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hora de la cita";
            // 
            // cmbAr
            // 
            this.cmbAr.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAr.FormattingEnabled = true;
            this.cmbAr.Location = new System.Drawing.Point(206, 87);
            this.cmbAr.Name = "cmbAr";
            this.cmbAr.Size = new System.Drawing.Size(212, 26);
            this.cmbAr.TabIndex = 21;
            this.cmbAr.Text = "Arreglos Dentales";
            this.cmbAr.SelectedIndexChanged += new System.EventHandler(this.cmbAr_SelectedIndexChanged);
            this.cmbAr.Click += new System.EventHandler(this.cmbAr_Click);
            this.cmbAr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbAr_MouseClick);
            this.cmbAr.MouseCaptureChanged += new System.EventHandler(this.cmbAr_MouseCaptureChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.iconButton4);
            this.panel3.Location = new System.Drawing.Point(720, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 294);
            this.panel3.TabIndex = 22;
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
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton4.FlatAppearance.BorderSize = 3;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(21, 35);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(202, 42);
            this.iconButton4.TabIndex = 0;
            this.iconButton4.Text = "Guardar";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.txtanuncio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(717, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 100);
            this.panel1.TabIndex = 23;
            // 
            // txtanuncio
            // 
            this.txtanuncio.Font = new System.Drawing.Font("Decker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanuncio.Location = new System.Drawing.Point(6, 47);
            this.txtanuncio.Multiline = true;
            this.txtanuncio.Name = "txtanuncio";
            this.txtanuncio.ReadOnly = true;
            this.txtanuncio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtanuncio.Size = new System.Drawing.Size(256, 38);
            this.txtanuncio.TabIndex = 2;
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
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(408, 149);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 35);
            this.iconPictureBox1.TabIndex = 25;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 50;
            this.iconPictureBox2.Location = new System.Drawing.Point(388, 6);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 62);
            this.panel2.TabIndex = 28;
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(12, 238);
            this.Calendar1.MaxSelectionCount = 1;
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 32;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar1_DateChanged);
            this.Calendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar1_DateSelected);
            this.Calendar1.MouseCaptureChanged += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // cmbH
            // 
            this.cmbH.Font = new System.Drawing.Font("Decker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbH.FormattingEnabled = true;
            this.cmbH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbH.Location = new System.Drawing.Point(276, 274);
            this.cmbH.Name = "cmbH";
            this.cmbH.Size = new System.Drawing.Size(62, 24);
            this.cmbH.TabIndex = 34;
            this.cmbH.Text = "Hora";
            // 
            // DGVB
            // 
            this.DGVB.AllowUserToDeleteRows = false;
            this.DGVB.AllowUserToOrderColumns = true;
            this.DGVB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.DGVB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DGVB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVB.ColumnHeadersHeight = 35;
            this.DGVB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVB.ColumnHeadersVisible = false;
            this.DGVB.EnableHeadersVisualStyles = false;
            this.DGVB.Location = new System.Drawing.Point(446, 185);
            this.DGVB.Name = "DGVB";
            this.DGVB.ReadOnly = true;
            this.DGVB.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DGVB.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVB.Size = new System.Drawing.Size(265, 87);
            this.DGVB.TabIndex = 42;
            this.DGVB.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVB_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbN);
            this.groupBox1.Controls.Add(this.rdbC);
            this.groupBox1.Font = new System.Drawing.Font("Decker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 87);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de citas";
            // 
            // cmbCu
            // 
            this.cmbCu.BackColor = System.Drawing.Color.White;
            this.cmbCu.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCu.FormattingEnabled = true;
            this.cmbCu.Location = new System.Drawing.Point(446, 87);
            this.cmbCu.Name = "cmbCu";
            this.cmbCu.Size = new System.Drawing.Size(212, 26);
            this.cmbCu.TabIndex = 44;
            this.cmbCu.Text = "Curaciones Dentales";
            this.cmbCu.SelectedIndexChanged += new System.EventHandler(this.cmbCu_SelectedIndexChanged);
            this.cmbCu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCu_MouseClick);
            this.cmbCu.MouseCaptureChanged += new System.EventHandler(this.cmbCu_MouseCaptureChanged);
            // 
            // cmbM
            // 
            this.cmbM.Font = new System.Drawing.Font("Decker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbM.FormattingEnabled = true;
            this.cmbM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbM.Location = new System.Drawing.Point(347, 274);
            this.cmbM.Name = "cmbM";
            this.cmbM.Size = new System.Drawing.Size(71, 24);
            this.cmbM.TabIndex = 45;
            this.cmbM.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Decker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Progreso";
            // 
            // txtAvance
            // 
            this.txtAvance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAvance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.txtAvance.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.txtAvance.Bordersize = 2;
            this.txtAvance.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvance.ForeColor = System.Drawing.Color.Black;
            this.txtAvance.Location = new System.Drawing.Point(276, 347);
            this.txtAvance.Margin = new System.Windows.Forms.Padding(5);
            this.txtAvance.Multiline = true;
            this.txtAvance.Name = "txtAvance";
            this.txtAvance.Padding = new System.Windows.Forms.Padding(7);
            this.txtAvance.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAvance.PlaceholderText = "Avance sobre el tratamiento";
            this.txtAvance.Size = new System.Drawing.Size(216, 66);
            this.txtAvance.TabIndex = 48;
            this.txtAvance.Texts = "";
            this.txtAvance.UnderlineStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.txtNombre.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.txtNombre.Bordersize = 2;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Decker", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(206, 189);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Nombre completo";
            this.txtNombre.Size = new System.Drawing.Size(232, 35);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = true;
            // 
            // txtCarnet
            // 
            this.txtCarnet.BackColor = System.Drawing.SystemColors.Window;
            this.txtCarnet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.txtCarnet.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.txtCarnet.Bordersize = 2;
            this.txtCarnet.Font = new System.Drawing.Font("Decker", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.ForeColor = System.Drawing.Color.Black;
            this.txtCarnet.Location = new System.Drawing.Point(206, 149);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(5);
            this.txtCarnet.Multiline = false;
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Padding = new System.Windows.Forms.Padding(7);
            this.txtCarnet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCarnet.PlaceholderText = "Carnte del paciente";
            this.txtCarnet.Size = new System.Drawing.Size(187, 35);
            this.txtCarnet.TabIndex = 27;
            this.txtCarnet.Texts = "";
            this.txtCarnet.UnderlineStyle = true;
            this.txtCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarnet_KeyPress);
            // 
            // txtBP
            // 
            this.txtBP.BackColor = System.Drawing.SystemColors.Window;
            this.txtBP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(203)))));
            this.txtBP.BorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.txtBP.Bordersize = 2;
            this.txtBP.Font = new System.Drawing.Font("Decker", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBP.ForeColor = System.Drawing.Color.Black;
            this.txtBP.Location = new System.Drawing.Point(446, 149);
            this.txtBP.Margin = new System.Windows.Forms.Padding(5);
            this.txtBP.Multiline = false;
            this.txtBP.Name = "txtBP";
            this.txtBP.Padding = new System.Windows.Forms.Padding(7);
            this.txtBP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBP.PlaceholderText = "Buscar paciente";
            this.txtBP.Size = new System.Drawing.Size(265, 35);
            this.txtBP.TabIndex = 26;
            this.txtBP.Texts = "";
            this.txtBP.UnderlineStyle = true;
            this.txtBP._TextChanged += new System.EventHandler(this.iconPictureBox1_Click);
            this.txtBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox1_KeyPress);
            // 
            // Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 512);
            this.Controls.Add(this.txtAvance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbM);
            this.Controls.Add(this.cmbCu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVB);
            this.Controls.Add(this.cmbH);
            this.Controls.Add(this.Calendar1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtBP);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbAr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cita";
            this.Text = "Form4";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAr;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private RJTextBox txtBP;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RJTextBox txtCarnet;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private RJTextBox txtNombre;
        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.ComboBox cmbH;
        private System.Windows.Forms.DataGridView DGVB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCu;
        private System.Windows.Forms.ComboBox cmbM;
        private System.Windows.Forms.TextBox txtanuncio;
        private System.Windows.Forms.Label label3;
        private RJTextBox txtAvance;
    }
}