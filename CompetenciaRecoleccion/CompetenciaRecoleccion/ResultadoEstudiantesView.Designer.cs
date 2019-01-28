namespace CompetenciaRecoleccion
{
    partial class ResultadoEstudiantesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoEstudiantesView));
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bolsas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.volverBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(485, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULTADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.cod,
            this.bolsas});
            this.listView.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(41, 113);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1121, 469);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 310;
            // 
            // cod
            // 
            this.cod.Text = "Código";
            this.cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cod.Width = 268;
            // 
            // bolsas
            // 
            this.bolsas.Text = "Número de Bolsas Recogidas";
            this.bolsas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bolsas.Width = 536;
            // 
            // volverBut
            // 
            this.volverBut.BackColor = System.Drawing.Color.LightYellow;
            this.volverBut.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volverBut.Location = new System.Drawing.Point(41, 28);
            this.volverBut.Name = "volverBut";
            this.volverBut.Size = new System.Drawing.Size(118, 52);
            this.volverBut.TabIndex = 12;
            this.volverBut.Text = "Volver";
            this.volverBut.UseVisualStyleBackColor = false;
            this.volverBut.Click += new System.EventHandler(this.volverBut_Click);
            // 
            // ResultadoEstudiantesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 615);
            this.Controls.Add(this.volverBut);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Name = "ResultadoEstudiantesView";
            this.Text = "Resultado de Recolección por Estudiantes";
            this.Load += new System.EventHandler(this.ResultadoEstudiantesView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader cod;
        private System.Windows.Forms.ColumnHeader bolsas;
        private System.Windows.Forms.Button volverBut;
    }
}