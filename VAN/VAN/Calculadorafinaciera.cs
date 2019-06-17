using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAN
{
    class Calculadorafinanciera
    {
        private int n;
        private double tasa;
        public Calculadorafinanciera(int periodos, double i)
        {
            this.n = periodos;
            this.tasa = i;
        }
        public double Montofinal(double Montoinicial)
        {
            double CF;
            CF = Montoinicial * Math.Pow((1 + tasa), n);
            return CF;
        }
        public double VAN(double Io, double[] flujos)
        {
            double sumatoria = 0;
            for (int i = 0; i < n; i++)
            {
                sumatoria = sumatoria + (flujos[i]) / Math.Pow((1 + tasa), i);
            }
            return sumatoria - Io;
        }
    }
}
