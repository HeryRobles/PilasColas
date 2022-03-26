﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Pilas
    {
        private string[] array;
        private int max;
        private int tope;
        
        public Pilas(int tamano)
        {
            array = new string[tamano];
            max = array.Length -1;
            tope = 0;
          
        }

        private bool ValidaVacio()
            //if (tope < 1)
            //{
            //return true;
            //Console.Write("El Arreglo está Vacío");
            //}
            //else
            //{
            //return false;
            //}
        {
            return (tope<1);
        }

        private bool ValidaLleno()
        {
            return (tope > max);
        }

        public void Agregar(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("El Arreglo esta Lleno");
            }

            array[tope] = dato;
            tope++;
        }

        public void Elimiar()
        {
            if(ValidaVacio())
            {
                throw new Exception("El Arreglo está Vacío");
            }

            tope--;
            array[tope] = null;

        }
    }
}
