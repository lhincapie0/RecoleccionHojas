using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaRecoleccion
{
    class Facultad
    {
        private String nombre { get; set; }
        private int no_bolsas { get; set; }

        public Facultad(String nombre, int no_bolsas)
        {
            this.nombre = nombre;
            this.no_bolsas = no_bolsas;
        }
    }
}
