using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial3
{

    class Registro
    {
        private List<Vehiculo> Listavehiculos;
        public void insertar(Vehiculo vp)
        {
            Listavehiculos.Add(vp);
        }
        public Boolean eliminar(Vehiculo vp)
        {
            return Listavehiculos.Remove(vp);
        }
        public List<Vehiculo> Getmotos()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            var consulta2 = from al in Listavehiculos
                            where al.tipodevehiculo == "Motos"
                            select al;
            foreach (Vehiculo p in consulta2)
            {
                aux.Add(p);
            }

            return aux;
        }
        public List<Vehiculo> GetVehiculos()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            var consulta2 = from al in Listavehiculos
                            where al.tipodevehiculo == "Numeros"
                            select al;
            foreach (Vehiculo p in consulta2)
            {
                aux.Add(p);
            }

            return aux;
        }
        public List<Vehiculo> GetMonto()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            var consulta2 = from al in Listavehiculos
                            where al.monto >10
                            select al;
            foreach (Vehiculo p in consulta2)
            {
                aux.Add(p);
            }

            return aux;
        }

    }
    class Vehiculo
    {
        private string text1;
        private int v;
        private string text2;

        public int placa { set; get; }
        public String tipodevehiculo { set; get; }
        public int monto { set; get; }

        public Vehiculo(int Placa, string Tipodevehiculo, int Monto)
        {

            placa = Placa;
            tipodevehiculo = tipodevehiculo;
            monto = monto;


        }

        public Vehiculo(string text1, int v, string text2)
        {
            this.text1 = text1;
            this.v = v;
            this.text2 = text2;
        }
    }
}
