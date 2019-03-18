﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1parcial
{
    class bicolasdocentes<T>
    {

        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int final = 0;
        private int frente = 0;
        private Docente[] Vector = new Docente[7];
        public void InsertarAtras(T valor)
        {
            if (!LLena())
            {
                arreglo[final] = valor;
                final = (final + 1) % Maximo;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public void InsertarDelante(T valor)
        {
            if (!LLena())
            {
                if (frente == 0)
                    frente = Maximo - 1;
                else
                    frente++;
                arreglo[frente] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public T EliminarDelante()
        {
            if (!Vacia())
            {
                T valor;
                valor = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return valor;
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public T EliminarAtras()
        {
            if (!Vacia())
            {

                T valor;
                if (final == 0)
                {
                    final = Maximo - 1;
                }
                final--;
                valor = arreglo[final];
                return valor;
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }


        public void mostrar()
        {
            int aux = frente;
            while (aux != final)
            {
                Console.Write(arreglo[aux] + "");
                
              
                aux = (aux + 1) % Maximo;
            }
        }
        private Boolean Vacia()
        {
            return frente == final;
        }
        private Boolean LLena()
        {
            return frente == (final + 1) % Maximo;
        }
    }
}
    public class Docente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Carrera { get; set; }

        public Docente(string Nombre, int Edad, string Sexo, string Carrera)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.Carrera = Carrera;
        }
    }


