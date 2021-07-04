using System;
using System.Collections.Generic;
using System.Text;

namespace ProgGrafica
{
    interface IObjeto
    {
        void Dibujar();
        void Trasladar(float dx, float dy, float dz);
        void Rotar( float rx, float ry, float rz);
        void Escalar(float ex, float ey, float ez);

    }
}
