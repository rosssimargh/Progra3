using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4
{
    class Docentes
    {
        public string Nombre;
        public string Apellidos;
        public int Edad;
        public string Carrera;

        public Docentes(string Nombre, string Apellidos, int Edad, string Carrera)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad= Edad;
            this.Carrera = Carrera;

        }
    }
}
