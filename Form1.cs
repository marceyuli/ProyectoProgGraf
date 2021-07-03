using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using ProgGrafica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgGrafica
{
    public partial class Form1 : Form
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

        private Timer _timer = null!;
        private float _angle = 0.0f;
        public Form1()
        {
            InitializeComponent();
           // VSync = VSyncMode.On;
            escenario = new Escenario();
            escenario.add("Silla0", new Silla(0, 0, 0, 0.5f, 1, 0.5f));
             //escenario.add("ABC", new Silla(0, 0, 0, 1, 2, 1));
             escenario.add("Silla2", new Silla(2, 2, 0, 0.5f, 1, 0.5f));
             escenario.add("Silla3", new Silla(-4, -4,0, 0.5f, 1, 0.5f));
        }
        protected void RenderNew()
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
        private void Render()
        {
            glControl.MakeCurrent();

            GL.ClearColor(Color4.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);

            Matrix4 lookat = Matrix4.LookAt(0, 5, 5, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            //GL.Rotate(_angle, 0.0f, 1.0f, 0.0f);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            escenario.Rotar(_angle, 0.0f, 1.0f, 0.0f);
            //escenario.Trasladar(0.5f, 0.01f, 0.01f);
           // escenario.Escalar(1.05, 1.05, 1.05);
           escenario.Dibujar();
            aux = aux + 0.0001f;
            //   Context.SwapBuffers();
            theta += 0.1f;
            if (theta > 360)
            {
                theta = theta - 360;
            }
            //GL.Begin(BeginMode.Quads);

            //GL.Color4(Color4.Silver);
            //GL.Vertex3(-1.0f, -1.0f, -1.0f);
            //GL.Vertex3(-1.0f, 1.0f, -1.0f);
            //GL.Vertex3(1.0f, 1.0f, -1.0f);
            //GL.Vertex3(1.0f, -1.0f, -1.0f);

            //GL.Color4(Color4.Honeydew);
            //GL.Vertex3(-1.0f, -1.0f, -1.0f);
            //GL.Vertex3(1.0f, -1.0f, -1.0f);
            //GL.Vertex3(1.0f, -1.0f, 1.0f);
            //GL.Vertex3(-1.0f, -1.0f, 1.0f);

            //GL.Color4(Color4.Moccasin);
            //GL.Vertex3(-1.0f, -1.0f, -1.0f);
            //GL.Vertex3(-1.0f, -1.0f, 1.0f);
            //GL.Vertex3(-1.0f, 1.0f, 1.0f);
            //GL.Vertex3(-1.0f, 1.0f, -1.0f);

            //GL.Color4(Color4.IndianRed);
            //GL.Vertex3(-1.0f, -1.0f, 1.0f);
            //GL.Vertex3(1.0f, -1.0f, 1.0f);
            //GL.Vertex3(1.0f, 1.0f, 1.0f);
            //GL.Vertex3(-1.0f, 1.0f, 1.0f);

            //GL.Color4(Color4.PaleVioletRed);
            //GL.Vertex3(-1.0f, 1.0f, -1.0f);
            //GL.Vertex3(-1.0f, 1.0f, 1.0f);
            //GL.Vertex3(1.0f, 1.0f, 1.0f);
            //GL.Vertex3(1.0f, 1.0f, -1.0f);

            //GL.Color4(Color4.ForestGreen);
            //GL.Vertex3(1.0f, -1.0f, -1.0f);
            //GL.Vertex3(1.0f, 1.0f, -1.0f);
            //GL.Vertex3(1.0f, 1.0f, 1.0f);
            //GL.Vertex3(1.0f, -1.0f, 1.0f);

            //GL.End();

            glControl.SwapBuffers();
        }
    

        private void glControl_Load(object? sender, EventArgs e)
        {
            //GL.ClearColor(1, 1, 1, 1);
            //GL.Enable(EnableCap.DepthTest);

            //Make sure that when the GLControl is resized or needs to be painted,
            //we update our projection matrix or re-render its contents, respectively.
            glControl.Resize += glControl_Resize;
            glControl.Paint += glControl_Paint;

            // Redraw the screen every 1/20 of a second.
            _timer = new Timer();
            _timer.Tick += (sender, e) =>
            {
                _angle += 0.5f;
                Render();
            };
            _timer.Interval = 50;   // 1000 ms per sec / 50 ms per frame = 20 FPS
            _timer.Start();

            // Ensure that the viewport and projection matrix are set correctly initially.
            glControl_Resize(glControl, EventArgs.Empty);
        }

        private void glControl_Resize(object? sender, EventArgs e)
        {
            //GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadIdentity();
            //GL.Ortho(-5, 5, -5, 5, -5, 5);


            //GL.MatrixMode(MatrixMode.Modelview);

            glControl.MakeCurrent();

            if (glControl.ClientSize.Height == 0)
                glControl.ClientSize = new System.Drawing.Size(glControl.ClientSize.Width, 1);

            GL.Viewport(0, 0, glControl.ClientSize.Width, glControl.ClientSize.Height);

            float aspect_ratio = Math.Max(glControl.ClientSize.Width, 1) / (float)Math.Max(glControl.ClientSize.Height, 1);
            Matrix4 perpective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perpective);
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }
    }
}
