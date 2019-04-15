using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServidorFactorial
{
    class Program
    {

        private static int factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return factorial(n - 1) * n;
        }

        public static string data = null;
    public static void StartListening()
    {
        // Bufer de Datos paralosdatos recibidos  
        byte[] bytes = new Byte[1024];

        // Establece el punto deentrada final para el socket.  
        // Dns.GetHostName devuelve el nombre del host donde correr la aplicacion
        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddress = ipHostInfo.AddressList[0];

        IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

        // Crea un Socket TCP/IP x.  
        Socket listener = new Socket(IPAddress.Any.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);


        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);

            // Inicia a escuchas miestras llegan conexiones.  
            while (true)
            {
                Console.WriteLine("Esperando por conexiones ...");
                // el Programa es suspendido mientras espera oconexiones de entrada .  
                Socket handler = listener.Accept();
                data = null;

                    int bytesrec = handler.Receive(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, bytesrec);

                    // Muestra los datos en la consola .  
                    Console.WriteLine("Nro recibido: {0}", data);

                    // Prepara los datos para responder  al cliente.  
                    int fact = factorial(int.Parse(data));
                byte[] msg = Encoding.ASCII.GetBytes(fact.ToString());

                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\nPresiones ENTER para continuar...");
        Console.Read();

    }

    public static int Main(String[] args)
    {
            Console.WriteLine("introduzca numero");
        StartListening();
        return 0;
    }
}
}
