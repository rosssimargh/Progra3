using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteChatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RTXCONVERSACION_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNENVIAR_Click(object sender, EventArgs e)
        {
            String mensaje = TXTNICK.Text + ": " + TXTMSG.Text;
            String mensajerecibido = StartClient(mensaje);
            String[] msg = mensajerecibido.Split(':');
            lbConversacion.Items.Add(mensajerecibido);
            if (LBPARTICIPANTES.FindString(msg[0]) == -1)
                LBPARTICIPANTES.Items.Add(msg[0]);
            
        }
        public static String StartClient(String cadena)
        {
            byte[] bytes = new byte[1024];
            String Respuesta="";
            // Se conecta al dispositivo remoto .  
            try
            {
                // Establece un punto remoto final para el socket.  
                // Este ejemplo usa el puerto 11000 en la computadora local.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                //IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                // Conetarse al punto final remoto  captura cualquier error .  
                try
                {
                    sender.Connect(remoteEP);

                  //  Console.WriteLine("Socket connectado a {0}",
                    //    sender.RemoteEndPoint.ToString());
                    
                    // codifica datos en un string dentro de un arreglo de bits. 
                    byte[] msg = Encoding.ASCII.GetBytes(cadena);
                    // Envia datos a traves del socket .  
                    int bytesSent = sender.Send(msg);
                    // Recibe ladespuesta desde el dispositivo remoto .  
                    int bytesRec = sender.Receive(bytes);
                    Respuesta=""+Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    
                    sender.Close();
                    Console.ReadLine();
                    
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return Respuesta;
        }
    }
}
