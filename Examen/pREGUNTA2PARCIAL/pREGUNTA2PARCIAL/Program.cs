using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pREGUNTA2PARCIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            DOCENTES1 docent =0;
            int opcion = 0;
            int x = 0;
            string a, s, c;
            int e = 0;
            List<DOCENTES1> l = new List<DOCENTES1>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Ordenar");

                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        Console.Write("Nombre: ");
                        a = Console.ReadLine();
                        Console.Write("Edad: ");
                        e = int.Parse(Console.ReadLine());
                        Console.Write("Sexo (M/F): ");
                        s = Console.ReadLine();
                        Console.Write("Carrera: ");
                        c = Console.ReadLine();
                        docent = new DOCENTES1(a, e, s, c);
                        l.Add(docent);
                      
                        break;
                    case 2:
                        Console.WriteLine("que elemnto quiere eliminar");
                        x = int.Parse(Console.ReadLine());
                        l.Remove(docent);
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("* Los nombre ordenados por edad y luego por nombre.-");
                        var consulta1 = from  als in l
                                        orderby als.Edad ascending
                                        select al;
                        foreach (DOCENTES1 doc in consulta1)
                        {
                            Console.WriteLine("{0}{1}", doc.Edad, " " + doc.Nombre);
                        }
                        Console.WriteLine("Lista de docentes cuya edad es de 35.-");
                        var consulta2 = from als in docent
                                        where als.Edad == 35
                                        select als;
                        foreach (DOCENTES1 doc in consulta2)
                        {
                            Console.WriteLine("{0}{1}", doc.Edad, "" + doc.Nombre);
                        }
                        Console.WriteLine("Cantidad de docentes agrupados por carrera y sexo.-");
                        var c4 = from alm in docent
                                 group alm by alm.Sexo into sexo
                                 select new { Sexo = sexo.Key, Cantidad = sexo.Count() };

                        foreach (var grupoedad in c4)
                        {
                            Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Cantidad);
                        }

                        Console.WriteLine("Grupo de DOCENTES por sexo");
                        var c3 = from alm in docent
                                 group alm by alm.Sexo into sexo
                                 select sexo;
                        //grupo alumno
                        foreach (var grupogenero in c3)
                        {
                            Console.WriteLine(grupogenero.Key);
                            foreach (DOCENTES1 alumno in grupogenero)
                            {
                                Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Apellidos, alumno.Sexo);
                            }
                        }
                        Console.ReadKey();
                        foreach (int o in l)
                        {
                            Console.Write("{0 }", o);
                        }

                        Console.ReadKey();
                        break;

                }
            }

           
        }
    }
    }

