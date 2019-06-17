using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        pila<string> pi = new pila<string>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
      
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbinsertar_Click(object sender, EventArgs e)
        {

            
            pi.push("Nro de Placa:"+textnroplaca.Text);
            pi.push("montoa cobrar:" + textmontocobra.Text);
            pi.push("Hrs de ingreso:"+textHRAINGRE.Text);
            pi.push("Hrs de salida:"+textHRASALIDA.Text);
            pi.push("tipo de vehiculo:"+CBTIPODEVEHI.Text);


        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            mostrar.Items.Clear();
            string[] are = pi.mostrar();
            for (int i = 0; i < are.Length; i++)
            {
                mostrar.Items.Add(are[i]);
            }


        }

        private void Btnmostrarlistado_Click(object sender, EventArgs e)
        {
            vehiculos.GetEnumerator();
            mostrarlista.Items.Add(CBTIPODEVEHI);

        }
    }
}
