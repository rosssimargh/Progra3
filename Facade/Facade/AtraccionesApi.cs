using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class AtraccionesApi
    {
        public void buscarAtraccionesApi(String fechaEntrada, String fechaSalida, String origen, String destino)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Atracciones Encontrada");
            Console.WriteLine("Entrada: " + fechaEntrada + " Salida: " + fechaSalida);
            Console.WriteLine("Atracciones A:juego de mesas");
            Console.WriteLine("Atracciones B:futbol");
            Console.WriteLine("Atracciones C: tennis");
            Console.WriteLine("==============================");
        }
    }
}
