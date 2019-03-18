using System;

namespace tarea2
{
    class Program
    {

        public class factororial
        {
            public delegate void delegado(int x);
            public event delegado mult;
            public int factorial(int x)
            {
                int x1, y = 1;

                x1 = int.Parse(Console.ReadLine());
                for (int i = 1; i <= x1; i++)
                {
                    y = y * i;

                }
                Console.Write(" factorial " + y);

                if ((y % 3 == 0) && (mult != null))
                {
                    mult(y);
                }
                Console.ReadLine();
                return y;

            }
        }
        class factorial2
        {
            static void Main(string[] args)
            {
                factororial f = new factororial();
                f.mult+= recibemultiplodetres;
                Console.WriteLine(" Introduzca un numero ");
                int y = 1;
                int res = f.factorial(y);
                Console.WriteLine("el factorial es " + y);
            }
            static void recibemultiplodetres(int x)
            {
                Console.WriteLine(" se introdujo un multiplo de 3 : " + x);
            }
        }
    }
}
