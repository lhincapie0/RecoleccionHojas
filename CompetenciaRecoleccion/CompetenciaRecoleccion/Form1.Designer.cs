namespace CompetenciaRecoleccion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.registrarBut = new System.Windows.Forms.Button();
            this.verBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultadosBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPETENCIA DE RECOL.ECCIÓN DE HOJAS ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // registrarBut
            // 
            this.registrarBut.BackColor = System.Drawing.Color.DarkKhaki;
            this.registrarBut.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBut.ForeColor = System.Drawing.Color.White;
            this.registrarBut.Location = new System.Drawing.Point(199, 148);
            this.registrarBut.Name = "registrarBut";
            this.registrarBut.Size = new System.Drawing.Size(339, 49);
            this.registrarBut.TabIndex = 2;
            this.registrarBut.Text = "Registrar recolección de hojas";
            this.registrarBut.UseVisualStyleBackColor = false;
            this.registrarBut.Click += new System.EventHandler(this.registrarBut_Click);
            // 
            // verBut
            // 
            this.verBut.BackColor = System.Drawing.Color.DarkKhaki;
            this.verBut.ForeColor = System.Drawing.Color.White;
            this.verBut.Location = new System.Drawing.Point(78, 166);
            this.verBut.Name = "verBut";
            this.verBut.Size = new System.Drawing.Size(171, 42);
            this.verBut.TabIndex = 3;
            this.verBut.Text = "Ver";
            this.verBut.UseVisualStyleBackColor = false;
            this.verBut.Click += new System.EventHandler(this.verBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.resultadosBox);
            this.groupBox1.Controls.Add(this.verBut);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(202, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver Resultados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // resultadosBox
            // 
            this.resultadosBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadosBox.FormattingEnabled = true;
            this.resultadosBox.Items.AddRange(new object[] {
            "Ver Resultados por Estudiante",
            "Ver Resultados por Facultades",
            "Ver Resultados por Semestres"});
            this.resultadosBox.Location = new System.Drawing.Point(23, 50);
            this.resultadosBox.Name = "resultadosBox";
            this.resultadosBox.Size = new System.Drawing.Size(297, 85);
            this.resultadosBox.TabIndex = 4;
            this.resultadosBox.SelectedIndexChanged += new System.EventHandler(this.resultadosBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(774, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registrarBut);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Competencia de Recolección";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrarBut;
        private System.Windows.Forms.Button verBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox resultadosBox;
    }
}

