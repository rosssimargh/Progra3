using System;

namespace tarea1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante Est;
            Boolean Salir = false;
            int opcion = 4, i = 0, e;
            string a, s, c;
            Pila<Estudiante> p = new Pila<Estudiante>();
            while (Salir == false)
            {
                Console.WriteLine("1.Insertar los datos del Estudiante");
                Console.WriteLine("2. Eliminar ");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese los datos");
                        Console.Write("Nombre: ");
                        a = Console.ReadLine();
                        Console.Write("Edad: ");
                        e = int.Parse(Console.ReadLine());
                        Console.Write("Sexo (M/F): ");
                        s = Console.ReadLine();
                        Console.Write("Carrera: ");
                        c = Console.ReadLine();
                        Est = new Estudiante(a, e, s, c);
                        p.Push(Est);
                        i++;
                        break;

                    case 2:

                        Est = p.Pop();
                        Console.WriteLine("Elemento Eliminado " + Est.Nombre+"/Edad:"+ Est.Edad);
                        break;
                    case 3:
                      p.Mostar();

                        Console.WriteLine();
                        break;

                }

            }
            Console.ReadKey();
        }
    }
}
