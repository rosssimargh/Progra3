using System;

namespace Tarea5
{
    delegate int operacione(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese valores para X ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valores para Y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("SUMA.R.-");
            Console.WriteLine(operacion(Suma, x, y));
            Console.WriteLine("RESTA.R.-");
            Console.WriteLine(operacion(Resta, x, y));
            Console.WriteLine("MULTIPLICACION.-");
            Console.WriteLine(operacion(Multiplicacion, x, y));
            Console.WriteLine("DIVISION");
            Console.WriteLine(operacion(Division, x, y));
            Console.ReadKey();
        }
        static int operacion(operacione op, int x, int y)
        {
            return (op(x, y));
        }
      
       
        static int Suma(int x, int y)
        {
            return x + y;
        }
        static int Resta(int x, int y)
        {
            return x - y;
        }
        static int Multiplicacion(int x, int y)
        {
            return x * y;
        }
        static int Division(int x, int y)
        {
            return x / y;
        }
    }
}
