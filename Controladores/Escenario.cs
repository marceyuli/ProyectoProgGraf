using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgGrafica
{
    class Escenario
    {
        Hashtable objetos;
        public Escenario()
        {
            objetos = new Hashtable();
        }
        public void add(String nombre, Objeto nuevoObjeto)
        {
            objetos.Add(nombre, nuevoObjeto);
        }
        public void Escalar(double ex, double ey, double ez)
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

        public void Trasladar(double x, double y, double z)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                obj.Trasladar(x, y, z);
            }
        }
        public void Rotar(double angle, double rx, double ry, double rz)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                obj.Rotar(angle, rx, ry, rz);

            }
        }

        public void Rotar(double angle, double rx, double ry, double rz, String nombreObjeto, String nombreParte)
        {
            foreach (DictionaryEntry objeto in objetos)
            {
                Objeto obj = (Objeto)objeto.Value;
                if (objeto.Key == nombreObjeto)
                {
                    obj.Rotar(angle, rx, ry, rz, nombreParte);
                }

            }
        }
    }
}
