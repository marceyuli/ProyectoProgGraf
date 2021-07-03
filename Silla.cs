using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgGrafica
{
    class Silla : Objeto
    {
        public Silla(float x, float y, float z, float ancho, float alto, float profundo)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.ancho = ancho;
            this.alto = alto;
            this.profundo = profundo;
            actualizarPuntos();

        }

        public Silla()
        {
            partes  = new Hashtable();
            //Pata izquierda delantera
            partes.Add("PID" ,new Parte(0f, -0.5f, 0.5f, 0.05f, 1f, 0.05f));
            //Pata derecha delantera
            partes.Add("PDD", new Parte(0f, 0.5f, 0.5f, 0.05f, 1f, 0.05f));
            //Pata trasera izquierda
            partes.Add("PTI", new Parte(1f, -0.5f, 1f, 0.05f, 2f, 0.05f));
            //Pata trasera derecha
            partes.Add("PTD" ,new Parte(1f, 0.5f, 1f, 0.05f, 2f, 0.05f));
            //Tabla de sentar
           partes.Add("TDS", new Parte(0.5f, 0f, 1f, 1f, 0.05f, 1f));
            //Respaldar arriba
         //  partes.AddLast(new Parte(1f, 0f, 2f, 1f, 0.05f, 0.05f));
            //Tabla de la espalda
            partes.Add("TDE", new Parte(1f, 0f, 1.5f, 1f, 1f, 0.05f));

        }

        override public void Dibujar()
        {
            foreach (DictionaryEntry parte in partes)
            {
                Parte prt = (Parte)parte.Value;
                    prt.Dibujar();
                
            }
        }
        override public void Escalar(double ex, double ey, double ez)
        {
            foreach (DictionaryEntry parte in partes)
            {
                Parte prt = (Parte)parte.Value;
                prt.Escalar(ex, ey, ez);
            }
        }
        override public void Rotar(double angle, double rx, double ry, double rz)
        {
            foreach (DictionaryEntry parte in partes)
            {
                Parte prt = (Parte)parte.Value;
                
                    prt.Rotar(angle, rx, ry, rz);
            }
        }
        override public void Trasladar(double dx, double dy, double dz)
        {
            foreach (DictionaryEntry parte in partes)
            {
                Parte prt = (Parte)parte.Value;
                prt.Trasladar(dx, dy, dz);
            }
        }
        /*override public void Escalar(float porcentaje)
         {
             this.alto = this.alto * porcentaje;
             this.ancho = this.ancho * porcentaje;
             this.profundo = this.profundo * porcentaje;
             actualizarPuntos();
         }*/
        public void actualizarPuntos()
         {
             partes = new Hashtable();
            //Pata izquierda delantera
            partes.Add("PID",new Parte(0f + x, -0.25f * alto + y, 0.5f * profundo + z, 0.05f * ancho, 0.5f * alto, 0.05f * profundo));
             //Pata derecha delantera
             partes.Add("PDT",new Parte(0f + x, 0.25f * alto + y, 0.5f * profundo + z, 0.05f * ancho, 0.5f * alto, 0.05f * profundo));
             //Pata trasera izquierda
             partes.Add("PTI",new Parte(ancho + x, -0.25f * alto + y, 1f * profundo + z, 0.05f * ancho, alto, 0.05f * profundo));
             //Pata trasera derecha
             partes.Add("PTD",new Parte(ancho + x, 0.25f * alto + y, 1f * profundo + z, 0.05f * ancho, alto, 0.05f * profundo));
             //Tabla de sentar
             partes.Add("TDS",new Parte(0.5f * ancho + x, 0f + y, profundo + z, ancho, 0.025f * alto, profundo));
             //Respaldar arriba
             //   partes.AddLast(new Parte(1f+x, 0f+y, 2f+z, ancho, 0.025f * alto, 0.05f*profundo));
             //Tabla de la espalda
             partes.Add("TDE",new Parte(ancho + x, 0f + y, 1.5f * profundo + z, ancho, 0.5f * alto, 0.05f * profundo));
         }
        /*  override public void Trasladar(float dx, float dy, float dz)
         {
             x += dx;
             y += dy;
             z += dz;
             partes = new LinkedList<Parte>();
             actualizarPuntos();
         }*/
        /*override public void Rotar(double teta, double beta, double alfa)
        {
            x = (float)((x * (Math.Cos(alfa) * Math.Cos(beta))) +
              y * ((Math.Cos(alfa) * Math.Sin(beta) * Math.Sin(teta)) - (Math.Sin(alfa) * Math.Cos(teta))) +
              z * ((Math.Cos(alfa) * Math.Sin(beta) * Math.Cos(teta)) + (Math.Sin(alfa) * Math.Sin(teta))));
            y = (float)((x * (Math.Sin(alfa) * Math.Cos(beta))) +
                y * ((Math.Sin(alfa) * Math.Sin(beta) * Math.Sin(teta)) + (Math.Cos(alfa) * Math.Cos(teta))) +
                z * ((Math.Sin(alfa) * Math.Sin(beta) * Math.Cos(teta)) - (Math.Cos(alfa) * Math.Sin(teta))));
            z = (float)(-x * Math.Sin(beta) + y * (Math.Cos(beta) * Math.Sin(teta)) + z * (Math.Cos(beta) * Math.Cos(teta)));
            actualizarPuntos();
        }*/
    }
}
