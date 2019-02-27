using System;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0 , a =0;
           Class_pila<int> p = new Class_pila<int>();
            while(opcion!=4)
            {
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca elemento: ");
                        a = int.Parse(Console.ReadLine());
                        p.Push(a);
                        Console.WriteLine("***********************************");
                        break;

                    case 2:
                        a = p.pop();
                        Console.WriteLine("Elemento eliminado: "+ a);

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
