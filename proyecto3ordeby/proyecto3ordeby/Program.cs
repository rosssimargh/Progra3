using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto3ordeby
{
    class Program
    {
        static void Main(string[] args)
        {
            alumno[] alumnos = new alumno[7];
            alumnos[0] = new alumno("Rossimar", "Guzman", 18, "FEMENINO", "1234556", 1.54, 40);
            alumnos[1] = new alumno("Carolina", "Lopez", 19, "FEMENINO", "1234556", 1.65, 60);
            alumnos[2] = new alumno("Diego", "Latorre", 18, "Masculino", "1234556", 1.65, 60);
            alumnos[3] = new alumno("Dieter", "Quiñones", 19, "Masculino", "1234556", 1.59, 60);
            alumnos[4] = new alumno("Guztavo", "Zarate", 19, "Masculino", "1234556", 1.79, 70);
            alumnos[5] = new alumno("Alejandro", "Castro", 19, "Masculino", "1234556", 1.64, 50);
            alumnos[6] = new alumno("Franko", "Adamczyk", 18, "Masculino", "1234556", 1.70, 60);

           

            var c1 = from alm in alumnos
                     orderby  alm.Apellidos descending
                     select alm;

            //-lista de alumons ordenados por apellidos
            Console.WriteLine("Lista de alumnos ordenados por apellido decendentemente");
            foreach (var alumno in c1)
            {
                Console.WriteLine("{0} {1}", alumno.Apellidos, alumno.Nombre);
            }
            Console.WriteLine("************************************************");
            /////////////////////////////////////////////////////////////////
            ///
            Console.WriteLine("Lista cuya edad =18 & sexo = Masculino");
            var c2 = from alm in alumnos
                     where alm.Edad == 18 && alm.Sexo == "Masculino"
                     select alm;
            //2.-lista cuya edad sea =18 sexo= masculino
            foreach (var alumno in c2)
            {
                Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Sexo);
            }
            Console.WriteLine("************************************************");

            //////////////////////////////////////
            Console.WriteLine("Grupo de alumnos por sexo");
            var c3 = from alm in alumnos
                     group alm by alm.Sexo into sexo
                     select sexo;
            //grupo alumno
            foreach (var grupogenero in c3)
            {
                Console.WriteLine(grupogenero.Key);
                foreach (alumno alumno in grupogenero)
                {
                    Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Apellidos);
                }
            }
            Console.WriteLine("************************************************");
            Console.WriteLine("Cantidad de alumnos por sexo");
            //3&4.-Cantidad de alumons por sexo
            var c4 = from alm in alumnos
                     group alm by alm.Sexo into sexo
                     select new { Sexo = sexo.Key, Cantidad = sexo.Count() };
           
            foreach (var grupoedad in c4)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Cantidad);
            }

            //////////////////////////////////////
            Console.WriteLine("5.- PROMEDIO DE EDAD POR SEXO");

            var c5 = from alm in alumnos
                     group alm by alm.Sexo into sexo
                     select new { Sexo = sexo.Key, Promedio = sexo.Average(pe => pe.Edad) };
            foreach(var grupoEdad in c5)
            {
                Console.WriteLine("{0} {1}", grupoEdad.Sexo, grupoEdad.Promedio);
            }







            Console.ReadKey();
        }
    }
}
