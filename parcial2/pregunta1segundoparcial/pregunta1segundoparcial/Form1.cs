using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta1segundoparcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bhtnobt_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(textvalor.Text);
            Banco.GetInstance().ShowMethod();
                

        }

        private void btncolocar_Click(object sender, EventArgs e)
        {

            textvalor.Clear();
           
            Banco.GetInstance().ShowMethod();

        }
    }
}
