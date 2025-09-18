using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class claseTDA
    {
        public int top;
        public readonly int max;
        public int[] arreglo;

        public int Top1 { get => top; }
        public int Max1 { get => max; }
        public int[] Arreglo1 { get => arreglo; }

        public claseTDA(int n)
        {
            max = n;
            top = 0;
            arreglo = new int[max];
        }
        public bool EstaLLeno()
        {
            if (Top1 == Max1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EstaVacio()
        {
            if (Top1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsertarDato(int dato)
        {
            if (!EstaLLeno())
                throw new Exception("Pila llena, no se pueden agragar mas datos");
            for (int i = 0; i < Top1; i++)
                if (Arreglo1[i] == dato)
                    throw new Exception("El dato ya existe en la pila");
            Arreglo1[Top1] = dato;
            top++;
            return true;
        }

        public int SacarDato()
        {
            if (EstaVacio())
                return -1; //indica que la pila esta vacia
            top--;
            return Arreglo1[Top1]; //retorna el dato que se saca
        }

        public bool EliminarDato(int dato)
        {
            int i = 0;
            if (!EstaVacio())
            {
                for (i = 0; i < Top1; i++)
                {
                    if (arreglo[i] == dato)
                    {
                        for (int y = i; y < Top1 - 1; y++)
                        {
                            arreglo[y] = arreglo[y + 1];
                            top--;   //Disminuye el tope
                            return true; //Realizado con exito


                        }
                        return false; //No se encontro el dato
                    }
                    return false;
                }
            }
           return false; //Pila vacia
        }
        
        public bool EliminarDato()
        { 
        int i = 0;
            if (!EstaVacio())
            {
                arreglo [Top1 - 1] = 0;
                top--;   //Disminuye el tope
                return false; //Realizado con exito
            }
            return false; //No se encontro el dato
        }

        //public int BuscarDato() 
        //{
        //    int numeroArreglo[top - 1];
        //    return numero;

        //}

        public int[] ObtenerDatos()
        {
            int[] arregloAux = new int[Top1];
            for (int i = 0; i < Top1; i++)
                arregloAux[i] = Arreglo1[i];
            return arregloAux;

        }
    }
}
