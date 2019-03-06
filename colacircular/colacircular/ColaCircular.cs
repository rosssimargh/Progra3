using System;
using System.Collections.Generic;
using System.Text;

namespace colacircular
{
    class ColaCircular<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[10];
        private int fin = 0;
        private int frente = 0;

        public void insertar(T valor)
        {
            if (!llenar())
            {
                arreglo[fin] = valor;
                fin = (fin + 1) % Maximo;
            }
            else
            {
                Console.WriteLine("La Cola esta llena");
            }

        }
        public T eliminar()
        {
            if (!Vacia())
            {
                T valor;
                valor = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return valor;
            }
            else
            {
                Console.WriteLine("La Cola esta vacia");
                return arreglo[frente ];
            }

        }
        public void Mostrar()
        {
            int aux = frente;
            while(aux != fin)
            {
                Console.WriteLine(arreglo[aux]+ " ");
                aux = (aux + 1) % Maximo;
            }


        }
        private Boolean Vacia()
        {
            return frente == fin;
        }
        private Boolean llenar()
        {
            return fin == (fin+1)%Maximo;
        }
    }
}
