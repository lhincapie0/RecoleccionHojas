namespace CompetenciaRecoleccion
{
    partial class Form5
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
            this.volverBut = new System.Windows.Forms.Button();
            this.semestresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.semestresChart)).BeginInit();
            this.SuspendLayout();
            // 
            // volverBut
            // 
            this.volverBut.BackColor = System.Drawing.Color.LightYellow;
            this.volverBut.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volverBut.Location = new System.Drawing.Point(25, 26);
            this.volverBut.Name = "volverBut";
            this.volverBut.Size = new System.Drawing.Size(118, 52);
            this.volverBut.TabIndex = 14;
            this.volverBut.Text = "Volver";
            this.volverBut.UseVisualStyleBackColor = false;
            this.volverBut.Click += new System.EventHandler(this.volverBut_Click);
            // 
            // semestresChart
            // 
            chartArea1.Name = "ChartArea1";
            this.semestresChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.semestresChart.Legends.Add(legend1);
            this.semestresChart.Location = new System.Drawing.Point(149, 79);
            this.semestresChart.Name = "semestresChart";
            this.semestresChart.Size = new System.Drawing.Size(1270, 496);
            this.semestresChart.TabIndex = 15;
            this.semestresChart.Text = "chart1";
            this.semestresChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1473, 635);
            this.Controls.Add(this.semestresChart);
            this.Controls.Add(this.volverBut);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.semestresChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volverBut;
        private System.Windows.Forms.DataVisualization.Charting.Chart semestresChart;
    }
}