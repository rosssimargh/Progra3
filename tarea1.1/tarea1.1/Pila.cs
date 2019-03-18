using System;
using System.Collections.Generic;
using System.Text;

namespace tarea1._1
{
    class Pila<T>
    {
        private Estudiante[] Vector = new Estudiante[7];
        private int tope = -1;

        public void Push(Estudiante x)
        {
            if (!Llena())
            {
                tope++;

                Vector[tope] = x;

            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }

        }
        public Estudiante Pop()
        {

            if (!Vacia())
            {
                tope--;
                return Vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Vector[tope + 1];
            }


        }
        private Boolean Vacia()
        {

            return tope == -1;

        }
        private Boolean Llena()
        {

            return tope == 10;

        }
        public void Mostar()
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.Write("Nombre: " + Vector[i].Nombre + " /Edad: " + Vector[i].Edad +"/Sexo:"+Vector[i].Sexo+ " ");
            }
        }

    }
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Carrera { get; set; }

        public Estudiante(string Nombre, int Edad, string Sexo, string Carrera)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.Carrera = Carrera;
        }
    }
}

