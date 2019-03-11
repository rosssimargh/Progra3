using System;
using System.Collections.Generic;
using System.Text;

namespace bicolas
{
    class Bicola
    {
       
        int[] cola = new int[max];
        int final = -1;
        int frente = -1;
        public static int max = 5;
       
        public Boolean vacia()
        {
            if (frente == -1)
                return true;
            else
                return false;
        }
        public Boolean llena()
        {
            if (frente == 0 && final == max - 1)
                return true;
            else
                return false;
        }
        public void agregar_por_el_frente()
        {
            if (llena() == true)
                Console.WriteLine("la cola esta llena");
            else
                Console.WriteLine("agregar dato");
            if (frente == 0)
            {
                Console.WriteLine("no se puede agregar por el frente");
            }
            if (frente > 0)
            {
                frente--;
                cola[frente] = int.Parse(Console.ReadLine());
            }
            if (frente == -1)
            {
                frente++;
                cola[frente] = int.Parse(Console.ReadLine());
                if (frente == 0)//se igualan los datos
                { final = 0; }//se igualan los datos
            }
        }
        public void agregar_por_el_final()
        {
            if (llena() == true)
                Console.WriteLine("la cola esta llena");
            else
                Console.WriteLine("agregar dato");
            if (final < max - 1)
            {
                final++;
                cola[final] = int.Parse(Console.ReadLine());
            }
            if (final == max - 1)
            {
                Console.WriteLine("no se puede agregar por el final");
            }
            if (final == -1)
            {
                final++;
                cola[final] = int.Parse(Console.ReadLine());
                if (final == 0)//se igualan los datos
                    frente = 0;//se igualan los datos
            }

        }
        public void eliminar_por_el_frente()
        {
            if (vacia() == true)
                Console.WriteLine("La cola esta vacia");
            else
                Console.WriteLine("Se eliminara el dato por el frente" + cola[frente]);
            frente++;
        }
        public void eliminar_por_el_final()
        {
            if (vacia() == true)
                Console.WriteLine("La cola esta vacia");
            else
                Console.WriteLine("Se eliminara el dato por el final" + cola[final]);
            final--;
        }
        public void imprimir_elementos()
        {
            if (vacia() == true)//se verifica el estodo de la cola
                Console.WriteLine("Cola vacia");
            else
                for (int i = frente; i <= final; i++)// se crea un ciclo para recorrer los elementos
                    Console.Write(" " + cola[i] + '\t');//se captura el dato
            Console.WriteLine("  ");

        }
    }
}
