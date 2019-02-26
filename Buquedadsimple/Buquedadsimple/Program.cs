using System;

namespace Buquedadsimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10] { 54, 26, 93, 17, 77, 31, 44, 55, 20, 65 };
            Insercion(arreglo);
            int b = int.Parse(Console.ReadLine());
            if (Buscar(arreglo, b))
                Console.WriteLine("Se encontro elemento");
            else
                Console.WriteLine("No se encontro elmento");

            Console.ReadKey();
        
        }
        static Boolean Buscar (int [] arreglo, int b)
        {
            int i = 0;
            while(b > arreglo[i] && i<= arreglo[i])
            {
                i++;
            }

            if (arreglo[i] == b)
             return true; 
            else
            
                return false;
            
        }
        
        public static void Insercion(int [] arreglo )
        {
            int AUX;
            int J;
            for (int I = 0; I < arreglo.Length; I++)
            {
                AUX = arreglo[I];
                J = I - 1;
                while (J >= 0 && arreglo[J] > AUX)
                {
                    arreglo[J + 1] = arreglo[J];
                    J--;
                }
                arreglo[J + 1] = AUX;
            }
        }

        
    }
}
