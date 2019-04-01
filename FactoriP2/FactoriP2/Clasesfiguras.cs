using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoriP2
{
    class Clasesfiguras: IFiguras

    {
        double A = 5;
        public double Area()
        {
            return A * A;
        }
        public double perimetro()
        {
            return 4 * A;
        }

    }
    class rectangulo: IFiguras
    {
        double b = 2, h = 4;
        public double Area()
        {
            return b * h;
        }
        public double perimetro()
        {
            return 2 * b + 2 * h;
        }


    }
    class circulo: IFiguras
    {
        double r = 10;
        public double Area()
        {
            return Math.PI * r;
        }
        public double perimetro()
        {
            return 2 * Math.PI * r;
        }
    }
}
