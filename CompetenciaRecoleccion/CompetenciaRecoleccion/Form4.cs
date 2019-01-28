using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace CompetenciaRecoleccion
{
    public partial class Form4 : Form
    {
        public Form1 main;
        public Facultad[] facultades;
        public Form4(Form1 main)
        {
            InitializeComponent();
            this.main = main;
            facultades = new Facultad[6];
            try
            {
                StreamReader reader = new StreamReader("..\\..\\Facultades.txt");
                String line;
                int a = 0;
                while ((line = reader.ReadLine()) != null)
                {

                    String[] datos = line.Split(',');
                    String nombre = datos[0];
                    String bolsas = datos[1];
                    int no_bolsas = Convert.ToInt32(bolsas);
                    Facultad facultad = new Facultad(nombre, no_bolsas);
                    facultades[a] = facultad;
                    a++;
                }
                reader.Close();
            }
            catch
            {

            }

        }

        private void facultadesChart_Click(object sender, EventArgs e)
        {
            String[] nombres = new string[6];
            int[] no_bolsas = new int[6];
            for(int i = 0; i<facultades.Length;i++)
            {
                nombres[i] = facultades[i].nombre;
                no_bolsas[i] = facultades[i].no_bolsas;
                Console.WriteLine(nombres[i] + no_bolsas[i]);
            }
           
            facultadesChart.Palette = ChartColorPalette.Pastel;
            facultadesChart.Titles.Add("Recolección por Facultades");

            for(int i = 0; i<nombres.Length;i++)
            {
                Series serie = facultadesChart.Series.Add(nombres[i]);

                serie.Label = no_bolsas[i].ToString();
                serie.Points.Add(no_bolsas[i]);
            }


            facultadesChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            facultadesChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
        }

        private void volverBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
