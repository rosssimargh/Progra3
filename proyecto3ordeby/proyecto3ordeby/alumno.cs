﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto3ordeby
{
    class alumno
    {
        public string Nombre { get; set; }
        public string Apellidos;
        public int Edad;
        public string Sexo;
        public string CI;
        public double Altura;
        public double Peso;
        public alumno(string Nombre, string Apellidos, int Edad, string Sexo, string CI, double Altura, double peso)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.CI = CI;
            this.Altura = Altura;
            this.Peso = peso;


        }
    }
}
