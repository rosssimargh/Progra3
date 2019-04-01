using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoriP2
{
    class Fabrica
    {
        public IFiguras getConexion(String figura)
        {
            if (figura == "Clasesfiguras")
            {
                return new Clasesfiguras();
            }
            else if (figura == "rectangulo")
            {
                return new rectangulo();
            }

            else
            {
                return new circulo();
            }
        }
    }
}
