using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAN
{
    public partial class Form1 : Form
    {
        public int arriba = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnINTRODUZCA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                TextBox txt = new TextBox();
                txt.Top = arriba;
                arriba += 22;
                panel1.Controls.Add(txt);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

         
            double[] flujos = new double[int.Parse(textBox1.Text)];
            int i = 0;
            foreach (Control control in panel1.Controls)
            {
                if(control.GetType().Name =="TextBox")
                {
                    flujos[i] = double.Parse(control.Text);
                    i++;
                }
            }
            Calculadorafinanciera cal = new Calculadorafinanciera(int.Parse(textInverioninicial.Text),double.Parse(texttasa.Text));
           
            cal.VAN(int.Parse(textInverioninicial.Text), flujos);
      cal.Montofinal(Convert.ToInt32(textInverioninicial.Text));
        }
    }
}                 
