using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Windowing.Common;
using System;

namespace ProgGrafica
{
    class Game 
    {
        Silla silla = new Silla();
        Escenario escenario;
        float theta = 1;
        float aux = 1;
        public double x = 0, y = 0, z = 2, ancho = 1, alto = 1, largo = 2;
        public float anguloX = -20;
        public float anguloY = 22;
        public float anguloZ = 0;

        public float escala = 1;
        public Game(int ancho, int altura, string title) //: base(ancho, altura)
        {
           // VSync = VSyncMode.On;
            escenario = new Escenario();
            escenario.add("Silla0", new Silla(0, 0, 0, 0.5f, 1, 0.5f));
           // escenario.add("Silla1", new Silla(0, 0, 0, 1, 2, 1));
           // escenario.add("Silla2", new Silla(2, 2, 0, 2, 4, 2));
           // escenario.add("Silla3", new Silla(-4, -4, 0, 3, 6, 3));

        }
        protected  void OnLoad(EventArgs e)
        {
        //    base.OnLoad(e);
            GL.ClearColor(1, 1, 1, 1);
            GL.Enable(EnableCap.DepthTest);
        }

        protected  void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();
            //GL.Rotate(theta, 1, 1, 1);
           // escenario.Rotar(theta, 1, 1, 1);
          
            escenario.Trasladar(0.5f, 0.01f, 0.01f);
            escenario.Escalar(0.05, 1.05, 1.05);
            escenario.Dibujar();
            aux = aux + 0.0001f;
         //   Context.SwapBuffers();
            theta += 0.1f;
            if (theta > 360)
            {
                theta = theta - 360;
            }
          //  base.OnRenderFrame(e);
        }
        protected  void OnResize(EventArgs e)
        {
           // base.OnResize(e);
          //  GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-5, 5, -5, 5, -5, 5);


            GL.MatrixMode(MatrixMode.Modelview);
           // base.OnResize(e);
        }





    }
}
