using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta1segundoparcial
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Banco ob = Banco.GetInstance();
            ob.ShowMethod();
            
            Banco ob2 = Banco.GetInstance();
            ob2.ShowMethod();
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.ReadKey();


        }
    }
}
