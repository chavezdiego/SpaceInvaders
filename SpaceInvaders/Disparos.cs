using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace SpaceInvaders
{
    class Disparos
    {

        int x, y;

        public Disparos(int px, int py)
        {
            x = px;
            y = py;
        }

        public int ObtenerX()
        {
            return x;
        }

        public int ObtenerY()
        {
            return y;
        }

        public void Mover()
        {
            y-=3;
        }

    }
}
