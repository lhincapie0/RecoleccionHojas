using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace CompetenciaRecoleccion
{
    public partial class Form5 : Form
    {

        public Form1 main;
        public Semestre[] semestres;
        public Form5(Form1 main)
        {
            InitializeComponent();
            this.main = main;
            semestres = new Semestre[10];
            try
            {
                StreamReader reader = new StreamReader("..\\..\\Semestres.txt");
                String line;
                int a = 0;
                while ((line = reader.ReadLine()) != null)
                {

                    String[] datos = line.Split(',');
                    String nombre = datos[0];
                    String bolsas = datos[1];
                    int no_bolsas = Convert.ToInt32(bolsas);
                    Semestre semestre = new Semestre(nombre, no_bolsas);
                    semestres[a] = semestre;
                    a++;
                }
                reader.Close();
            }
            catch
            {

            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            String[] nombres = new string[10];
            int[] no_bolsas = new int[10];
            for (int i = 0; i < semestres.Length; i++)
            {
                nombres[i] = semestres[i].nombre;
                no_bolsas[i] = semestres[i].no_bolsas;
                Console.WriteLine(nombres[i] + no_bolsas[i]);
            }

            semestresChart.Palette = ChartColorPalette.Pastel;
            semestresChart.Titles.Add("Recolección por Semestres");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
                Series serie = semestresChart.Series.Add(nombres[i]);

                serie.Label = no_bolsas[i].ToString();
                serie.Points.Add(no_bolsas[i]);
            }


            semestresChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            semestresChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
        }


        private void volverBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }
    }
}
