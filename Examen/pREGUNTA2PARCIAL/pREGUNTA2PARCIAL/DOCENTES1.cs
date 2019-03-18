using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pREGUNTA2PARCIAL
{
    class DOCENTES1
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public string Sexo { get; set; }

        public DOCENTES1(string Nombre, string Apellidos, int Edad, string Carrera,string Sexo)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Carrera = Carrera;
            this.Sexo = Sexo;

        }
    }
}
