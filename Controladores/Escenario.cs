using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgGrafica
{
    class Escenario
    {
        public Hashtable objetos;
        public Escenario()
        {
            objetos = new Hashtable();
        }
        public void add(String nombre, Objeto nuevoObjeto)
        {
            objetos.Add(nombre, nuevoObjeto);
        }
        public void Escalar(float ex, float ey, float ez)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                obj.Escalar(ex, ey, ez);
            }
        }
        public void Dibujar()
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                obj.Dibujar();
            }

        }

        public void Dibujar(String nombreObjeto, String parteObjeto)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                if (objeto.Key == nombreObjeto)
                {
                    obj.Dibujar(parteObjeto);
                }
            }

        }

        public void Trasladar(float x, float y, float z)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                obj.Trasladar(x, y, z);
            }
        }
        public void Rotar( float rx, float ry, float rz)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                obj.Rotar( rx, ry, rz);

            }
        }

        public void Rotar(float rx, float ry, float rz, String nombreObjeto, String nombreParte)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                if (objeto.Key == nombreObjeto)
                {
                    obj.Rotar( rx, ry, rz, nombreParte);
                }

            }
        }
        public void Rotar(float rx, float ry, float rz, String nombreObjeto)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                if (objeto.Key == nombreObjeto)
                {
                    obj.Rotar(rx, ry, rz);
                }

            }
        }
        public Objeto BuscarObjeto(string nombreObjeto)
        {
            return (Objeto)objetos[nombreObjeto];
        }
    }
}
