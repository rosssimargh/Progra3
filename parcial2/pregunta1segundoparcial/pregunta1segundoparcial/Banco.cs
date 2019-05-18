using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta1segundoparcial
{
    class Banco
    {
     
        public int Estado { get; private set; }

        public double obtenercotizacion( Double temperatura)
        {
            Estado = 0;
            
            return temperatura;
        }
        public double colocarcotizacion( Double temperatura)
        {
            return temperatura;
        }




        private static Banco Instancia = null;
        
        public static Banco GetInstance() //singleton
        {
            if (Instancia == null)
            {
                Instancia = new Banco();
            }
            return Instancia;
        }
        public void ShowMethod()
        {
            double temperatura = 0;
            Console.WriteLine("   ", obtenercotizacion(temperatura));
            Console.WriteLine("   ", colocarcotizacion(temperatura));

        }

    }
   
}
