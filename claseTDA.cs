using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Auto
    {
        public string Placas { get; set; }
        public string Propietario { get; set; }
        public string Color { get; set; }

        public Auto(string placas, string propietario, string color)
        {
            Placas = placas;
            Propietario = propietario;
            Color = color;
        }
    }

    internal class claseTDA
    {
        private int top;
        private readonly int max;
        private Auto[] arreglo;

        public int Top1 { get => top; }
        public int Max1 { get => max; }
        public Auto[] Arreglo1 { get => arreglo; }

        public claseTDA(int n = 10)
        {
            max = n;
            top = 0;
            arreglo = new Auto[max];
        }

        public bool EstaLLeno()
        {
            return Top1 == Max1;
        }

        public bool EstaVacio()
        {
            return Top1 == 0;
        }

     
        public bool InsertarAuto(Auto auto)
        {
            if (EstaLLeno())
                throw new Exception("Estacionamiento lleno, no se pueden agregar más autos");

        
            for (int i = 0; i < Top1; i++)
                if (Arreglo1[i].Placas == auto.Placas)
                    throw new Exception("Ya existe un auto con esas placas");

            Arreglo1[Top1] = auto;
            top++;
            return true;
        }

        public Auto SacarAuto()
        {
            if (EstaVacio())
                return null;

            top--;
            Auto carrito = Arreglo1[Top1];
            Arreglo1[Top1] = null; 
            return carrito;
        }

        public Auto[] ObtenerAutos()
        {
            Auto[] arregloAux = new Auto[Top1];
            for (int i = 0; i < Top1; i++)
                arregloAux[i] = Arreglo1[i];
            return arregloAux;
        }
    }

}
