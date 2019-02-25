using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            personas[] alumnos = new personas[7];
            alumnos[0] = new personas("ROSSIMAR", "GUZMAN", 18, "FEMENINO", "1234556", 1.54, 40);
            alumnos[1] = new personas("Carolina", "Lopez", 19, "FEMENINO", "1234556", 1.65, 60);
            alumnos[2] = new personas("Diegp", "Latorre", 18, "Nodefinido", "1234556", 1.65, 60);
            alumnos[3] = new personas("Dieter", "Quiñones", 19, "FEME", "1234556", 1.59, 60);
            alumnos[4] = new personas("Guztavo", "Zarate", 19, "FEME", "1234556", 1.79, 70);
            alumnos[5] = new personas("Alejandro", "Castro", 19, "FEME", "1234556", 1.64, 50);
            alumnos[6] = new personas("Franko", "Adamczyk", 18, "FEME", "1234556", 1.70, 60);
            //lista de todos los alumnos
            var consulta1 = from alm in alumnos
                            select alm;
            //lista de los alumnos cuya edad sea igual a 18

            var c2 = from alm in alumnos
                     where alm.Edad > 18
                     select alm;
            /////////////////////////////////////////////

            var c3 = from alm in alumnos
                     orderby alm.Apellidos
                     select alm;
            ////////////////////////////////////////////
            var c4 = from alm in alumnos
                     orderby alm.Apellidos
                     /////////////////////////////
                     select new { alm.Nombre, alm.Apellidos };
            var c6 = from alm in alumnos
                     orderby alm.Nombre, alm.Apellidos descending
                     select alm;
            //////////////////////////////////////////////////////////
            var c5 = from alm in alumnos
                     group alm by alm.Edad into edad
                     select edad;
            //grupo edades 
            foreach(var grupoedades in c5)
            {
                Console.WriteLine(grupoedades.Key);
                foreach(personas alumno in grupoedades)
                    {
                    Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Apellidos);
                }
            }
            Console.WriteLine("************************************************");

            //7.-Edades de los alumnos y cantidad
            var c7 = from alm in alumnos
                     group alm by alm.Edad into edad
                     select new { Edad = edad.Key, Cantidad = edad.Count() };

            foreach (var grupoedad in c7)
            {
                Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.Cantidad);
            }

          //  foreach(var alumno in c2)
           // {
            //    Console.WriteLine("{0} {1}",alumno.Nombre,alumno.Apellidos);
         //   }
            Console.ReadKey();
        }
    }
}
