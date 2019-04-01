using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoriP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica f = new Fabrica();
            IFiguras f1 = f.getConexion("Clasesfiguras");
            Console.WriteLine("AREA: " + f1.Area());
            Console.WriteLine("Perimetro: " + f1.perimetro());
            Console.WriteLine("*************************");
            IFiguras f2 = f.getConexion("rectangulo");
            Console.WriteLine("AREA: " + f2.Area());
            Console.WriteLine("Perimetro: " + f2.perimetro());
            Console.WriteLine("*************************");
            IFiguras f3 = f.getConexion("circulo");
            Console.WriteLine("AREA: " + f3.Area());
            Console.WriteLine("Perimetro: " + f3.perimetro());

            Console.ReadKey();
        }
    }
}
