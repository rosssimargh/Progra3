using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace pregunta3segundoparcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Text = Ahorcado.getInstancia().Buscar(txtLetra.Text[0]);
        }
        private String EnviarMensaje(String Mensaje)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    // de conecta al servidor
                    sender.Connect(remoteEP);
                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(Mensaje);
                    // aqui se manda el mensaje
                    int bytesSent = sender.Send(msg);
                    // Recibe ladespuesta desde el dispositivo remoto .  

                    int bytesRec = sender.Receive(bytes);


                    String Respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                    return Respuesta;
                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

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

            return null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Respuesta = EnviarMensaje("Iniciar");

        }
    }
}
