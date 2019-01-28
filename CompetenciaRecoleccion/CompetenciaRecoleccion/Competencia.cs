using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompetenciaRecoleccion
{
    class Competencia
    {


        public List<Estudiante> Estudiantes;
        public Facultad[] facultades { get; set; }
        public Semestre[] semestres { get; set; }

        public Competencia()
        {
            Estudiantes = new List<Estudiante>();
            facultades = new Facultad[6];
            semestres = new Semestre[10];
            String line = "";
            int a = 0;
            // lee los datos por facultad
            try
            {
                StreamReader reader = new StreamReader("..\\..\\Facultades.txt");
                while ((line = reader.ReadLine()) != null)
                {

                    String[] datos = line.Split(',');
                    String facultad = datos[0];
                    String bolsas = datos[1];
                    int no_bolsas = Convert.ToInt32(bolsas);
                    Facultad f = new Facultad(facultad, no_bolsas);
                    facultades[a] = f;
                    a++;
                }
                reader.Close();

            }
            catch
            {

            }

            int b =0;
            // lee los datos por facultad
            try
            {
                StreamReader reader = new StreamReader("..\\..\\Semestres.txt");
                while ((line = reader.ReadLine()) != null)
                {

                    String[] datos = line.Split(',');
                    String semestre = datos[0];
                    String bolsas = datos[1];
                    int no_bolsas = Convert.ToInt32(bolsas);
                    Semestre s = new Semestre(semestre, no_bolsas);
                    semestres[b] = s;
                    b++;
                }
                reader.Close();

            }
            catch
            {

            }


            //lee los datos de los estudiantes
            try
            {
                StreamReader reader = new StreamReader("..\\..\\TextFile1.txt");
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
                     Console.WriteLine(facultad);
                    Estudiante ag = new Estudiante(nombre, codigo, facultad, semestre, no_bolsas);
                    Estudiantes.Add(ag);
               
               
                }
                reader.Close();
            }
            catch
            {

            }


          

        }


      


            public void agregarRegistro(String nombre, String codigo, String facultad, String semestre, int bolsas)
        {
            Estudiante e = new Estudiante(nombre, codigo, facultad, semestre, bolsas);
            Console.WriteLine(e.nombre);
            Estudiantes.Add(e);
            try
            {

                StreamWriter writer =File.AppendText("..\\..\\TextFile1.txt");
                writer.WriteLine(nombre + "," + codigo + "," + facultad + "," + semestre + "," + bolsas);
                writer.Close();
            }
            catch
            {
                Console.WriteLine("No se pudo guardar el dato");
            }


            Boolean ya = false;
            for (int i = 0; i < semestres.Length && !ya; i++)
            {
                if (semestre.Equals(semestres[i].nombre))
                {
                    ya = true;
                    semestres[i].no_bolsas += bolsas;
                    Console.WriteLine("SEMESTRES ");
                }
            }
            Boolean ya1 = false;
            for (int i = 0; i < facultades.Length && !ya1; i++)
            {
                Console.WriteLine(facultad);

                Console.WriteLine(facultades[i].nombre);
                if (facultades.Equals(facultades[i].nombre))
                {
                    ya = true;
                    facultades[i].no_bolsas += bolsas;
                }
            }

            try
            {

                StreamWriter writer = new StreamWriter("..\\..\\Semestres.txt");
                for(int i = 0; i<semestres.Length;i++)
                {
                    writer.WriteLine(semestres[i].nombre + "," + semestres[i].no_bolsas);
               
                }

                writer.Close();
              
            }
            catch
            {
                Console.WriteLine("No se pudo guardar el dato");
            }

           

            try
            {

                StreamWriter writer = new StreamWriter("..\\..\\Facultades.txt");
                for (int i = 0; i < facultades.Length; i++)
                {
                    writer.WriteLine(facultades[i].nombre + "," + facultades[i].no_bolsas);

                }

                writer.Close();

            }
            catch
            {
                Console.WriteLine("No se pudo guardar el dato");
            }
        }
    }
}
