using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgGrafica
{
    abstract class Objeto : IObjeto
    {
        public float x, y, z, ancho, alto, profundo;
        public Hashtable partes;
        public abstract void Dibujar();

        public abstract void Dibujar(String nombreParte);

        public abstract void Escalar(double ex, double ey, double ez);


        public abstract void Trasladar(double x, double y, double z);



        public abstract void Rotar(double angle, double rx, double ry, double rz);

        public abstract void Rotar(double angle, double rx, double ry, double rz, String nombreParte);
        }
    }

