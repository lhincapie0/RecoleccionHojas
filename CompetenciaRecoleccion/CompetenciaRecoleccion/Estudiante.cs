using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaRecoleccion
{
    class Estudiante
    {

        public String nombre { get; set; }
         public String codigo { get; set; }
        public String facultad { get; set; }
        public String semestre { get; set; }
         public int no_bolsas { get; set; }

        public Estudiante(String nombre, String codigo,String facultad, String Semestre, int no_bolsas)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.facultad = facultad;
            this.semestre = semestre;
            this.no_bolsas = no_bolsas;
        }

    }

}
