using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Pilas
{
    class Class_pila<T>
    {
        
        private T[]arreglo = new T[10];
        private int tope = -1;
        public void Push(T valor)
        {
            if (!llenar())
            {
                tope++;
              arreglo[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }

        }

        public T pop()
        {
            if(!Vacia())
            {
                tope--;
                return arreglo[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return arreglo[tope + 1];
            }

        }

        private Boolean Vacia()
        {
            return tope == -1;
        }
        private Boolean llenar()
        {
            return tope == 10;
        }

        public void Mostrar()
        {
            for (int i=0; i< tope+1;i++)
            {
                Console.WriteLine(arreglo[i] + ".");
            }

        }
    }
}
