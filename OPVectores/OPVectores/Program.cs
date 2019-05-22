using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPVectores
{
    class Program
    {
        static void Main(string[] args)

        {

            {
                do
                {
                    int n;

                    Console.Clear();
                    //Limpia la pantalla
                    //Entrada de Menu
                    Console.WriteLine("1. Crear un Vector que almacene 5 números enteros y obtener la sumatoria de esos elementos.");
                    Console.WriteLine("2.Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas. Obtener:");
                    Console.WriteLine("3.Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde). Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno. Imprimir los sueldos de cada turno. Sugerencia: Crear dos Vectores; TurnoMañana, TurnoTarde. .   ");
                    
                    Console.WriteLine("");

                    Console.Write("Digite un valor entre 1-10: ");
                    n = int.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    //Proceso
                    switch (n)
                    {
                        case 1:
                            suma();
                            break;
                        case 2:
                            resta();
                            break;
                        case 3:
                            multiplicacion();
                            break;
                       
                        default:
                            Console.WriteLine("Introduzca un valor entre 1 y 10");
                            break;
                    }
                    Console.WriteLine("");
                    Console.Write("Digite (Intro) para continuar, (Esc) para salir ...");

                } while (Console.ReadKey().Key != ConsoleKey.Escape);

            }//Fin Main
        

             static void suma()
            {
                int[] numeros = new int[5];

                int suma = 0;
                for (int i = 0; i <= 4; i++)
                {

                    numeros[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i <= 4; i++)
                {
                    suma = suma + numeros[i];
                }
                for (int i = 0; i <= 4; i++)
                {
                    Console.Write(numeros[i]);
                }
                Console.WriteLine("la suma es " + suma);
            }
             static void resta()
            {
                int[] numeros = new int[5];

                int resta = 0;
                for (int i = 0; i <= 4; i++)
                {

                    numeros[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i <= 4; i++)
                {
                    resta = resta - numeros[i];
                }
                for (int i = 0; i <= 4; i++)
                {
                    Console.Write(numeros[i]);
                }
                Console.WriteLine("la resta es " + resta);
            }
             static void multiplicacion()
            {
                int[] numeros = new int[5];

                int multi = 0;
                for (int i = 0; i <= 4; i++)
                {

                    numeros[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i <= 4; i++)
                {
                    multi = multi * numeros[i];
                }
                for (int i = 0; i <= 4; i++)
                {
                    Console.Write(numeros[i]);
                }
                Console.WriteLine("la multiplicacion es " + multi);
            }



        }
    }
}
