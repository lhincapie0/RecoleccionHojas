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
        }



        public void agregarRegistro(String nombre, String codigo, String facultad, String semestre, int bolsas)
        {
            competencia.agregarRegistro(nombre, codigo, facultad, semestre, bolsas);
           
            
        }

        private void verBut_Click(object sender, EventArgs e)
        {
            ResultadoEstudiantesView ne = new ResultadoEstudiantesView(this);

            ne.Show();
        }

     



      

     
    }
}
