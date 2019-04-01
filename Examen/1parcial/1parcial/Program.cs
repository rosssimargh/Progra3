using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Docente DC;
            int opcion = 0;
            int x = 0;
            string a, c,  s;
            int e = 0;
            bicolasdocentes<Docente> p = new bicolasdocentes<Docente>();
            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar por Detras");
                Console.WriteLine("2. Insertar por Delante");
                Console.WriteLine("3. Eliminar por Delante");
                Console.WriteLine("4. Eliminar por Atras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento Atras");
                        Console.WriteLine("Ingrese los datos");
                        Console.Write("Nombre: ");
                        a = Console.ReadLine();
                        Console.Write("Edad: ");
                        e = int.Parse(Console.ReadLine());
                        Console.Write("Sexo (M/F): ");
                        s = Console.ReadLine();
                        Console.Write("Carrera: ");
                        c = Console.ReadLine();
                        DC = new Docente(a, e, s, c);
                        p.InsertarAtras(DC);

                            break;
                    case 2:
                        Console.WriteLine("introduzca un elemento DElante");
                        Console.WriteLine("Ingrese los datos");
                        Console.Write("Nombre: ");
                        a = Console.ReadLine();
                        Console.Write("Edad: ");
                        e = int.Parse(Console.ReadLine());
                        Console.Write("Sexo (M/F): ");
                        s = Console.ReadLine();
                        Console.Write("Carrera: ");
                        c = Console.ReadLine();
                        DC = new Docente(a, e, s, c);
                      
                        p.InsertarDelante(DC);
                        break;
                    case 3:
                      DC = p.EliminarDelante();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 4:
                        DC = p.EliminarAtras();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }


            }

        }

        }
}
    

