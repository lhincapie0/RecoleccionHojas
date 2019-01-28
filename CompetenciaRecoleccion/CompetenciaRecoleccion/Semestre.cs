using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaRecoleccion
{
    public class Semestre
    {
        public String nombre { get; set; }
        public int no_bolsas { get; set; }

        public Semestre(String nombre, int no_bolsas)
        {
            this.nombre = nombre;
            this.no_bolsas = no_bolsas;
        }
    }
}
