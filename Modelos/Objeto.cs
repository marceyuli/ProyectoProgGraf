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

        public abstract void Escalar(float ex, float ey, float ez);


        public abstract void Trasladar(float x, float y, float z);



        public abstract void Rotar(float rx, float ry, float rz);

        public abstract void Rotar(float rx, float ry, float rz, String nombreParte);
        }
    }

