using System;

namespace colacircular
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, opcion = 0;




            //HACEMOS LA COLA
            ColaCircular<int> p = new ColaCircular<int>();
            while (opcion != 4)
            {
                Console.WriteLine("1. insertar");
                Console.WriteLine("2. eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca elemento: ");
                        n = int.Parse(Console.ReadLine());
                        p.insertar(n);



                        Console.WriteLine("***********************************");
                        break;

                    case 2:
                        n = p.eliminar();
                        Console.WriteLine("Elemento eliminado: " + n);


                        break;
                    case 3:
                        Console.WriteLine("***********************************");
                        p.Mostrar();
                        Console.WriteLine();

                        break;
                    case 4:

                        break;

                }
                Console.ReadKey();

            }

        }
    }
}
