using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System;

namespace ProgGrafica
{
    internal class Parte : IObjeto
    {
        float x, y, z, profundo, alto, ancho;
        Vector3 vectorRotacion;
        public Parte(float x, float y, float z, float ancho, float alto, float profundo)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.profundo = profundo;
            this.alto = alto;
            this.ancho = ancho;

            vectorRotacion.X = 0;
            vectorRotacion.Y = 0;
            vectorRotacion.Z = 0;
        }

        public void Dibujar()
        {
            GL.PushMatrix();
            //GL.Translate(0, 1, 0);
            // Holis
            GL.Rotate(vectorRotacion.X,1,0,0);
            GL.Rotate(vectorRotacion.Y, 0, 1, 0);
            GL.Rotate(vectorRotacion.Z, 0, 0, 1);

            //GL.Scale(escala.X, escala.Y, escala.Z);
            // GL.ClearColor(Color4.MidnightBlue);
            //GL.Enable(EnableCap.DepthTest);
            //Matrix4 lookat = Matrix4.LookAt(0, 5, 5, 0, 0, 0, 0, 1, 0);
            //GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadMatrix(ref lookat);
            //  GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Begin(PrimitiveType.Quads);

            //Frontal
            GL.Color3(0.5, 0.0, 0.999999);
            GL.Vertex3(x + profundo / 2, y - ancho / 2, z - alto / 2); //A
            GL.Vertex3(x + profundo / 2, y + ancho / 2, z - alto / 2); //B
            GL.Vertex3(x + profundo / 2, y + ancho / 2, z + alto / 2); //C
            GL.Vertex3(x + profundo / 2, y - ancho / 2, z + alto / 2); //D




            //Trasera
            GL.Color3(0, 1, 0.999999);
            GL.Vertex3(x - profundo / 2, y - ancho / 2, z - alto / 2); //A
            GL.Vertex3(x - profundo / 2, y + ancho / 2, z - alto / 2); //B
            GL.Vertex3(x - profundo / 2, y + ancho / 2, z + alto / 2); //C
            GL.Vertex3(x - profundo / 2, y - ancho / 2, z + alto / 2); //D




            //Arriba
            GL.Color3(0.7, 0.0, 0.999999);
            GL.Vertex3(x + profundo / 2, y - ancho / 2, z + alto / 2); //A
            GL.Vertex3(x + profundo / 2, y + ancho / 2, z + alto / 2); //B
            GL.Vertex3(x - profundo / 2, y + ancho / 2, z + alto / 2); //C
            GL.Vertex3(x - profundo / 2, y - ancho / 2, z + alto / 2); //D





            //Abajo
            GL.Color3(0.0, 1.0, 1.0);
            GL.Vertex3(x + profundo / 2, y - ancho / 2, z - alto / 2); //A
            GL.Vertex3(x + profundo / 2, y + ancho / 2, z - alto / 2); //B
            GL.Vertex3(x - profundo / 2, y + ancho / 2, z - alto / 2); //C
            GL.Vertex3(x - profundo / 2, y - ancho / 2, z - alto / 2); //D




            //Izquierdo
            GL.Color3(0.5, 0.5, 0.0);
            GL.Vertex3(x + profundo / 2, y - ancho / 2, z - alto / 2); //A
            GL.Vertex3(x - profundo / 2, y - ancho / 2, z - alto / 2); //B
            GL.Vertex3(x - profundo / 2, y - ancho / 2, z + alto / 2); //C
            GL.Vertex3(x + profundo / 2, y - ancho / 2, z + alto / 2); //D











            ////Derecho
            GL.Color3(0.5, 0.0, 0.999999);
            GL.Vertex3(x + profundo / 2, y + ancho / 2, z - alto / 2); //A
            GL.Vertex3(x - profundo / 2, y + ancho / 2, z - alto / 2); //B
            GL.Vertex3(x - profundo / 2, y + ancho / 2, z + alto / 2); //C
            GL.Vertex3(x + profundo / 2, y + ancho / 2, z + alto / 2); //D




            GL.End();
            GL.PopMatrix();
        }

        public void Escalar(float ex, float ey, float ez)
        {
            GL.Scale(ex, ey, ez);
        }
        /* public void Escalar(float porcentaje)
         {
             this.ancho = this.ancho * porcentaje;
             this.alto = this.alto * porcentaje;
             this.profundo = this.profundo * porcentaje;
         }*/
        public void Rotar(float rx, float ry, float rz)
        {
            // GL.Rotate(angle, rx, ry, rz);
            vectorRotacion.X = rx;
            vectorRotacion.Y = ry;
            vectorRotacion.Z = rz;
        }

        /*public void Rotar(double teta, double beta, double alfa)
        {
            x = (float)((x * (Math.Cos(alfa) * Math.Cos(beta))) +
                y * ((Math.Cos(alfa) * Math.Sin(beta) *Math.Sin(teta)) - (Math.Sin(alfa) * Math.Cos(teta))) +
                z *( (Math.Cos(alfa) * Math.Sin(beta) * Math.Cos(teta)) + (Math.Sin(alfa) * Math.Sin(teta))));
            y= (float)((x * (Math.Sin(alfa) * Math.Cos(beta))) +
                y * ((Math. Sin(alfa) * Math.Sin(beta)*Math.Sin(teta)) +(Math.Cos(alfa) * Math.Cos(teta))) +
                z * ((Math.Sin(alfa) * Math.Sin(beta) * Math.Cos(teta)) - (Math.Cos(alfa) * Math.Sin(teta))));
            z = (float)(-x * Math.Sin(beta) + y * (Math.Cos(beta) * Math.Sin(teta)) + z * (Math.Cos(beta) * Math.Cos(teta)));
        }*/
        public void Trasladar(float dx, float dy, float dz)
        {
            GL.Translate(dx, dy, dz);
        }
        /*public void Trasladar(float dx, float dy, float dz)
    {
        x += dx;
        y += dy;
        z += dz;
    }*/
    }
}
