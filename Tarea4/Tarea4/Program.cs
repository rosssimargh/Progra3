using System;
using System.Linq;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Docentes[] docent = new Docentes[5];
            docent[0] = new Docentes("Vicente", "Campos", 61, "Administracion De Empresas");
            docent[1] = new Docentes("Henrry", "Subieta", 50, "Programacion");
            docent[2] = new Docentes("Luis Alberto", "Teran", 45, "Ing Industrial");
            docent[3] = new Docentes("Maria", "Valverde", 60, "Sistemas");
            docent[4] = new Docentes("Febe", "Hurtado", 38, "Pedagogia");
            Console.WriteLine("* Los nombre ordenados desdendentemente.-");
            var consulta1 = from al in docent
                            orderby al.Apellidos descending
                            select al;
            foreach (Docentes doc in consulta1)
            {
                Console.WriteLine("{0}{1}", doc.Apellidos, " " + doc.Nombre);
            }
            Console.WriteLine("Lista de docentes de edad mayor a 60.-");
            var consulta2 = from als in docent
                            where als.Edad >= 60
                            select als;

            foreach (Docentes docen in consulta2)
            {
                Console.WriteLine("{0}, {1} ", docen.Nombre, docen.Edad);


            }
            Console.WriteLine("Cantidad de docentes con la misma edad");
            var metodo4 = docent.GroupBy(t => new { edad = t.Edad })
                         .Select(g => new
                         {
                             Cantidad = g.Count(),
                             Edad = g.Key.edad
                         });

            foreach (var grupoedad in metodo4)
            {
                Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.Cantidad);

            }
            Console.ReadKey();
        }
    }
}

