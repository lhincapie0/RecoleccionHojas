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
    public partial class RegistroView : Form
    {

        private Form1 f;

        public RegistroView(Form1 f)
        {
            InitializeComponent();
            this.f = f; 
        }

        private void facultadBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void volverBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void registrarBut_Click(object sender, EventArgs e)
        {

            int bolsas = Convert.ToInt32(bolsasTxt.Text);
        
            f.agregarRegistro(nombreTxt.Text, codigoTxt.Text, facultadBox.Text, semestreBox.Text, bolsas);
            MessageBox.Show("Registro Exitoso");
            nombreTxt.Clear();
            codigoTxt.Clear();
            facultadBox.ResetText();
            semestreBox.ResetText();
            bolsasTxt.Clear();

           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
