﻿namespace SistemaAsistencia
{
    partial class frmDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpfech = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnuev = new System.Windows.Forms.Button();
            this.ptbhuella = new System.Windows.Forms.PictureBox();
            this.txtapem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtapep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtfem = new System.Windows.Forms.RadioButton();
            this.rbtmas = new System.Windows.Forms.RadioButton();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtema = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Estado = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ptbfoto = new System.Windows.Forms.PictureBox();
            this.btnelim = new System.Windows.Forms.Button();
            this.btngua = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlbus = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgbus = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbhuella)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).BeginInit();
            this.pnlbus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpfech);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnnuev);
            this.groupBox1.Controls.Add(this.ptbhuella);
            this.groupBox1.Controls.Add(this.txtapem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtapep);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.txtema);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 303);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dtpfech
            // 
            this.dtpfech.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpfech.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfech.Location = new System.Drawing.Point(80, 141);
            this.dtpfech.Name = "dtpfech";
            this.dtpfech.Size = new System.Drawing.Size(129, 20);
            this.dtpfech.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fech Nac. ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 27);
            this.button5.TabIndex = 18;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(260, 232);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(56, 40);
            this.btnedit.TabIndex = 18;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnnuev
            // 
            this.btnnuev.BackColor = System.Drawing.Color.Transparent;
            this.btnnuev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuev.BackgroundImage")));
            this.btnnuev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuev.FlatAppearance.BorderSize = 0;
            this.btnnuev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuev.Location = new System.Drawing.Point(181, 220);
            this.btnnuev.Name = "btnnuev";
            this.btnnuev.Size = new System.Drawing.Size(56, 65);
            this.btnnuev.TabIndex = 18;
            this.btnnuev.Text = " ";
            this.btnnuev.UseVisualStyleBackColor = false;
            this.btnnuev.Click += new System.EventHandler(this.btnnuev_Click);
            // 
            // ptbhuella
            // 
            this.ptbhuella.Location = new System.Drawing.Point(260, 19);
            this.ptbhuella.Name = "ptbhuella";
            this.ptbhuella.Size = new System.Drawing.Size(71, 75);
            this.ptbhuella.TabIndex = 17;
            this.ptbhuella.TabStop = false;
            // 
            // txtapem
            // 
            this.txtapem.Location = new System.Drawing.Point(220, 109);
            this.txtapem.Name = "txtapem";
            this.txtapem.Size = new System.Drawing.Size(129, 20);
            this.txtapem.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Apellidos ";
            // 
            // txtapep
            // 
            this.txtapep.Location = new System.Drawing.Point(80, 109);
            this.txtapep.Name = "txtapep";
            this.txtapep.Size = new System.Drawing.Size(129, 20);
            this.txtapep.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "/";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtfem);
            this.groupBox4.Controls.Add(this.rbtmas);
            this.groupBox4.Location = new System.Drawing.Point(27, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 100);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo";
            // 
            // rbtfem
            // 
            this.rbtfem.AutoSize = true;
            this.rbtfem.Location = new System.Drawing.Point(7, 56);
            this.rbtfem.Name = "rbtfem";
            this.rbtfem.Size = new System.Drawing.Size(31, 17);
            this.rbtfem.TabIndex = 0;
            this.rbtfem.TabStop = true;
            this.rbtfem.Text = "F";
            this.rbtfem.UseVisualStyleBackColor = true;
            // 
            // rbtmas
            // 
            this.rbtmas.AutoSize = true;
            this.rbtmas.Location = new System.Drawing.Point(7, 33);
            this.rbtmas.Name = "rbtmas";
            this.rbtmas.Size = new System.Drawing.Size(34, 17);
            this.rbtmas.TabIndex = 0;
            this.rbtmas.TabStop = true;
            this.rbtmas.Text = "M";
            this.rbtmas.UseVisualStyleBackColor = true;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(80, 67);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(129, 20);
            this.txtnom.TabIndex = 1;
            // 
            // txtema
            // 
            this.txtema.Location = new System.Drawing.Point(80, 171);
            this.txtema.Name = "txtema";
            this.txtema.Size = new System.Drawing.Size(129, 20);
            this.txtema.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, -240);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(79, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "...";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(80, 26);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(95, 20);
            this.txtdni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Estado);
            this.groupBox3.Controls.Add(this.cbestado);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.ptbfoto);
            this.groupBox3.Location = new System.Drawing.Point(429, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 224);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Foto";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(27, 200);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 3;
            this.Estado.Text = "Estado";
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Activo\t",
            "Inactivo",
            "Vacaciones"});
            this.cbestado.Location = new System.Drawing.Point(83, 197);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(103, 21);
            this.cbestado.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptbfoto
            // 
            this.ptbfoto.Image = ((System.Drawing.Image)(resources.GetObject("ptbfoto.Image")));
            this.ptbfoto.Location = new System.Drawing.Point(41, 19);
            this.ptbfoto.Name = "ptbfoto";
            this.ptbfoto.Size = new System.Drawing.Size(135, 159);
            this.ptbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbfoto.TabIndex = 0;
            this.ptbfoto.TabStop = false;
            // 
            // btnelim
            // 
            this.btnelim.BackColor = System.Drawing.Color.Transparent;
            this.btnelim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnelim.BackgroundImage")));
            this.btnelim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnelim.FlatAppearance.BorderSize = 0;
            this.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelim.Location = new System.Drawing.Point(615, 338);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(45, 58);
            this.btnelim.TabIndex = 18;
            this.btnelim.UseVisualStyleBackColor = false;
            this.btnelim.Click += new System.EventHandler(this.btnelim_Click);
            // 
            // btngua
            // 
            this.btngua.BackColor = System.Drawing.Color.Transparent;
            this.btngua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngua.BackgroundImage")));
            this.btngua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngua.FlatAppearance.BorderSize = 0;
            this.btngua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngua.Location = new System.Drawing.Point(554, 338);
            this.btngua.Name = "btngua";
            this.btngua.Size = new System.Drawing.Size(51, 58);
            this.btngua.TabIndex = 0;
            this.btngua.UseVisualStyleBackColor = false;
            this.btngua.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pnlbus
            // 
            this.pnlbus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlbus.Controls.Add(this.button3);
            this.pnlbus.Controls.Add(this.dtgbus);
            this.pnlbus.Controls.Add(this.txtbus);
            this.pnlbus.Controls.Add(this.label5);
            this.pnlbus.Location = new System.Drawing.Point(12, 72);
            this.pnlbus.Name = "pnlbus";
            this.pnlbus.Size = new System.Drawing.Size(399, 281);
            this.pnlbus.TabIndex = 19;
            this.pnlbus.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(367, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgbus
            // 
            this.dtgbus.AllowUserToAddRows = false;
            this.dtgbus.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgbus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.ApellidoP,
            this.ApellidoM,
            this.Nombres,
            this.FECHA,
            this.Sexo,
            this.Correo,
            this.Foto,
            this.Est});
            this.dtgbus.Location = new System.Drawing.Point(6, 51);
            this.dtgbus.Name = "dtgbus";
            this.dtgbus.ReadOnly = true;
            this.dtgbus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgbus.Size = new System.Drawing.Size(384, 195);
            this.dtgbus.TabIndex = 2;
            this.dtgbus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbus_CellClick);
            this.dtgbus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgbus_CellContentClick);
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // ApellidoP
            // 
            this.ApellidoP.HeaderText = "Apellido P";
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.ReadOnly = true;
            // 
            // ApellidoM
            // 
            this.ApellidoM.HeaderText = "Apellido M";
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "Fech_Nac";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            // 
            // Est
            // 
            this.Est.HeaderText = "Estado";
            this.Est.Name = "Est";
            this.Est.ReadOnly = true;
            // 
            // txtbus
            // 
            this.txtbus.BackColor = System.Drawing.Color.White;
            this.txtbus.Location = new System.Drawing.Point(50, 25);
            this.txtbus.Name = "txtbus";
            this.txtbus.Size = new System.Drawing.Size(207, 20);
            this.txtbus.TabIndex = 1;
            this.txtbus.TextChanged += new System.EventHandler(this.txtbus_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DNI";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 54);
            this.panel1.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(56, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Registro Docentes";
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(675, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlbus);
            this.Controls.Add(this.btnelim);
            this.Controls.Add(this.btngua);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDocente";
            this.ShowIcon = false;
            this.Text = "Docente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDocente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbhuella)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).EndInit();
            this.pnlbus.ResumeLayout(false);
            this.pnlbus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnuev;
        private System.Windows.Forms.PictureBox ptbhuella;
        private System.Windows.Forms.TextBox txtapem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtapep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtfem;
        private System.Windows.Forms.RadioButton rbtmas;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ptbfoto;
        private System.Windows.Forms.Button btnelim;
        private System.Windows.Forms.Button btngua;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlbus;
        private System.Windows.Forms.DataGridView dtgbus;
        private System.Windows.Forms.TextBox txtbus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpfech;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Est;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;

    }
}