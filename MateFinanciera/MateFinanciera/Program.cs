using System;

namespace MateFinanciera
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ci,t,Io;
           int n=0;
            Console.WriteLine("Introduzca el valor inicial;");
            Ci = double.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el nro de periodos");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca la tasa de valor actual");
            t = double.Parse(Console.ReadLine());
            double[] flujo = new double[n];
            Calculadorafinanciera cal = new Calculadorafinanciera(n, t);
            Console.WriteLine("introduzca los flujos ");
            //poner cero en el primer flujo
            for(int i=0; i<n; i++)
            {
                flujo[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("introduzaca nuevamente el ingreso inicial");
            Io = double.Parse(Console.ReadLine());
            Console.WriteLine("VAN =" + cal.VAN(Io, flujo));
            Console.WriteLine("Monto final =" + cal.Montofinal(Ci));
            Console.ReadKey();
        }
    }
}
