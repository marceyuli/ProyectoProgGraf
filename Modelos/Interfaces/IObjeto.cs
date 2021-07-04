using System;
using System.Collections.Generic;
using System.Text;

namespace ProgGrafica
{
    interface IObjeto
    {
        void Dibujar();
        void Trasladar(double dx, double dy, double dz);
        void Rotar(double angle, double rx, double ry, double rz);
        void Escalar(double ex, double ey, double ez);

    }
}
