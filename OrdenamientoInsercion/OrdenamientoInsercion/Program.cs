using System.Linq;
using System;


namespace OrdenamientoInsercion
{
    class Program
    {
        class PV
        {
            private int[] VECTOR;
            public void CARGAR()
            {
                Console.WriteLine("METODO DE INTERSECCION");
                Console.WriteLine("Cuantos longitud de vector:");
                string LINEA;
                LINEA = Console.ReadLine();
                int CANT;
                CANT = int.Parse(LINEA);
                VECTOR = new int[CANT];
                for (int F = 0; F < VECTOR.Length; F++)
                {
                    Console.WriteLine("INGRESE ELEMENTO" + (F + 1) + ":");
                    LINEA = Console.ReadLine();
                    VECTOR[F] = int.Parse(LINEA);

                }
            }
            public void INTERCESIONDIRECTA()
            {
                int AUX;
                int J;
                for(int I = 0; I< VECTOR.Length; I++)
                {
                    AUX = VECTOR[I];
                    J = I - 1;
                    while(J>= 0 && VECTOR[J] > AUX)
                    {
                        VECTOR[J + 1] = VECTOR[J];
                        J--;
                    }
                    VECTOR[J + 1] = AUX;
                }
            }

            public void IMPRIMIR()
            {
                Console.WriteLine("Vector ordenados en forma ascendente");
                for(int f= 0; f< VECTOR.Length;f++)
                {
                    Console.Write(VECTOR[f] + "-");
                }
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            PV prueba = new PV();
            prueba.CARGAR();
            prueba.INTERCESIONDIRECTA();
            prueba.IMPRIMIR();
        }
    }
}
