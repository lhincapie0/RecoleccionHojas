using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetenciaRecoleccion
{
    public partial  class Form1 : Form
    {

          Competencia competencia { get; set; }

        public Form1()
        {
            InitializeComponent();
            competencia = new Competencia();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarBut_Click(object sender, EventArgs e)
        {
            RegistroView r = new RegistroView(this);
            r.Show();
            this.Hide();
        }



        public void agregarRegistro(String nombre, String codigo, String facultad, String semestre, int bolsas)
        {
            competencia.agregarRegistro(nombre, codigo, facultad, semestre, bolsas);
           
            
        }

        private void verBut_Click(object sender, EventArgs e)
        {
        
            if (resultadosBox.GetSelected(0))
            {
                ResultadoEstudiantesView ventana = new ResultadoEstudiantesView(this);
                ventana.Show();
                this.Hide();
            }
            if (resultadosBox.GetSelected(1))
            {
                Form4 ventana = new Form4(this);
                ventana.Show();
                this.Hide();
            }
            if (resultadosBox.GetSelected(2))
            {
                Form5 ventana = new Form5(this);
                ventana.Show();
                this.Hide();
            }
            
        }

        private void resultadosBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
