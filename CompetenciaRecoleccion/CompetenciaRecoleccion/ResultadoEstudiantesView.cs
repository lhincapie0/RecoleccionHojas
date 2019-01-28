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

namespace CompetenciaRecoleccion
{
    public partial class ResultadoEstudiantesView : Form
    {

        public Form1 f;
        public ResultadoEstudiantesView(Form1 f)
        {
            InitializeComponent();
            this.f = f;

            List<Estudiante> estudiantes = new List<Estudiante>();
            try
            {
                StreamReader reader = new StreamReader("..\\..\\TextFile1.txt");
                String line;
                while ((line = reader.ReadLine()) != null)
                {

                    String[] datos = line.Split(',');
                    String nombre = datos[0];
                    String codigo = datos[1];
                    String facultad = datos[2];
                    String semestre = datos[3];
                    String bolsas = datos[4];
                    int no_bolsas = Convert.ToInt32(bolsas);
                    Console.WriteLine(nombre);
                    Console.WriteLine(codigo); Console.WriteLine(facultad);
                    Estudiante ag = new Estudiante(nombre, codigo, facultad, semestre, no_bolsas);
                    estudiantes.Add(ag);
                }
                reader.Close();

            }
            catch
            {

            }

            if (estudiantes != null)
            {
                for (int i = 0; i < estudiantes.Count; i++)
                {
                    Estudiante e = estudiantes.ElementAt(i);
                    String nombre = e.nombre;
                    ListViewItem item1 = new ListViewItem(nombre);
                    item1.SubItems.Add(e.codigo);
                    item1.SubItems.Add(" " + e.no_bolsas);
                    listView.Items.Add(item1);

                }
            }
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ResultadoEstudiantesView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void volverBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }
    }
}
