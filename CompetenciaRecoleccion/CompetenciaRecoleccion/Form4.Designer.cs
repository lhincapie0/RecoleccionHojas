namespace CompetenciaRecoleccion
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.facultadesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.volverBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facultadesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // facultadesChart
            // 
            this.facultadesChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facultadesChart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkVertical;
            this.facultadesChart.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.facultadesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.facultadesChart.Legends.Add(legend1);
            this.facultadesChart.Location = new System.Drawing.Point(71, 82);
            this.facultadesChart.Name = "facultadesChart";
            this.facultadesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.facultadesChart.Size = new System.Drawing.Size(1112, 447);
            this.facultadesChart.TabIndex = 0;
            this.facultadesChart.Text = "Recolección por Facultades";
            this.facultadesChart.Click += new System.EventHandler(this.facultadesChart_Click);
            // 
            // volverBut
            // 
            this.volverBut.BackColor = System.Drawing.Color.LightYellow;
            this.volverBut.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volverBut.Location = new System.Drawing.Point(41, 24);
            this.volverBut.Name = "volverBut";
            this.volverBut.Size = new System.Drawing.Size(118, 52);
            this.volverBut.TabIndex = 13;
            this.volverBut.Text = "Volver";
            this.volverBut.UseVisualStyleBackColor = false;
            this.volverBut.Click += new System.EventHandler(this.volverBut_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1247, 562);
            this.Controls.Add(this.volverBut);
            this.Controls.Add(this.facultadesChart);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultadesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart facultadesChart;
        private System.Windows.Forms.Button volverBut;
    }
}