namespace CompetenciaRecoleccion
{
    partial class RegistroView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroView));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.semestreBox = new System.Windows.Forms.ComboBox();
            this.facultadBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bolsasTxt = new System.Windows.Forms.TextBox();
            this.registrarBut = new System.Windows.Forms.Button();
            this.volverBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Facultad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semestre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(230, 74);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(238, 32);
            this.nombreTxt.TabIndex = 5;
            // 
            // codigoTxt
            // 
            this.codigoTxt.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTxt.Location = new System.Drawing.Point(230, 164);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(238, 32);
            this.codigoTxt.TabIndex = 6;
            // 
            // semestreBox
            // 
            this.semestreBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestreBox.FormattingEnabled = true;
            this.semestreBox.Items.AddRange(new object[] {
            "Primer Semestre",
            "Segundo Semestre",
            "Tercer Semestre",
            "Cuarto Semestre",
            "Quinto Semestre",
            "Sexto Semestre",
            "Séptimo Semestre",
            "Octavo Semestre",
            "Noveno Semestre",
            "Décimo Semestre"});
            this.semestreBox.Location = new System.Drawing.Point(644, 67);
            this.semestreBox.Name = "semestreBox";
            this.semestreBox.Size = new System.Drawing.Size(237, 33);
            this.semestreBox.TabIndex = 7;
            // 
            // facultadBox
            // 
            this.facultadBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultadBox.FormattingEnabled = true;
            this.facultadBox.Items.AddRange(new object[] {
            "Ciencias Administrativas y Económicas",
            "Ciencias de la Salud",
            "Ciencias Naturales",
            "Derecho y Ciencias Sociales",
            "Escuela de Ciencias de la Educación",
            "Ingeniería"});
            this.facultadBox.Location = new System.Drawing.Point(644, 156);
            this.facultadBox.Name = "facultadBox";
            this.facultadBox.Size = new System.Drawing.Size(237, 33);
            this.facultadBox.TabIndex = 8;
            this.facultadBox.SelectedIndexChanged += new System.EventHandler(this.facultadBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.bolsasTxt);
            this.groupBox1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(341, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bolsas Recogidas";
            // 
            // bolsasTxt
            // 
            this.bolsasTxt.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolsasTxt.Location = new System.Drawing.Point(102, 31);
            this.bolsasTxt.Name = "bolsasTxt";
            this.bolsasTxt.Size = new System.Drawing.Size(133, 32);
            this.bolsasTxt.TabIndex = 10;
            // 
            // registrarBut
            // 
            this.registrarBut.BackColor = System.Drawing.Color.OliveDrab;
            this.registrarBut.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarBut.Location = new System.Drawing.Point(403, 363);
            this.registrarBut.Name = "registrarBut";
            this.registrarBut.Size = new System.Drawing.Size(202, 52);
            this.registrarBut.TabIndex = 10;
            this.registrarBut.Text = "Registrar";
            this.registrarBut.UseVisualStyleBackColor = false;
            this.registrarBut.Click += new System.EventHandler(this.registrarBut_Click);
            // 
            // volverBut
            // 
            this.volverBut.BackColor = System.Drawing.Color.LightYellow;
            this.volverBut.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volverBut.Location = new System.Drawing.Point(26, 12);
            this.volverBut.Name = "volverBut";
            this.volverBut.Size = new System.Drawing.Size(118, 52);
            this.volverBut.TabIndex = 11;
            this.volverBut.Text = "Volver";
            this.volverBut.UseVisualStyleBackColor = false;
            this.volverBut.Click += new System.EventHandler(this.volverBut_Click);
            // 
            // RegistroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 480);
            this.Controls.Add(this.volverBut);
            this.Controls.Add(this.registrarBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.facultadBox);
            this.Controls.Add(this.semestreBox);
            this.Controls.Add(this.codigoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RegistroView";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox codigoTxt;
        private System.Windows.Forms.ComboBox semestreBox;
        private System.Windows.Forms.ComboBox facultadBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bolsasTxt;
        private System.Windows.Forms.Button registrarBut;
        private System.Windows.Forms.Button volverBut;
    }
}