using System;

namespace bicolas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Bicola p;
            while (opc != 6) 
            {
                Console.WriteLine(" opciones: ");
                Console.WriteLine(" 1.Agregar por el frente  \n 2.agregar por el final  \n 3.eliminar por el frente  \n 4.eliminar por el final \n 5.imprimir elementos \n 6.salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: p.agregar_por_el_frente(); break;
                    case 2:p.agregar_por_el_final(); break;
                    case 3: p.eliminar_por_el_frente(); break;
                    case 4:p.eliminar_por_el_final(); break;
                    case 5: p.imprimir_elementos(); break;
                    case 6: Console.WriteLine("Sesion finalizada"); break;
                    default: Console.WriteLine("Seleccione una opcion del menu"); break;
                }
               

            }
        }
    }
    
}
