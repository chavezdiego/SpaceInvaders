using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class EnegCircular:Enemigo
    {
        public EnegCircular(int x,int y):base( x,  y)
        {
        }

        double count = 0;
        double fi = 1.0;
        int y_inic = 200;
        int x_inic = 200;

        override public void Mover()
        {
            fi = (count * Math.PI) / 10;

            pos.y = (int)(y_inic + 100 * Math.Sin(fi));

            pos.x = (int)(x_inic + 100 * Math.Cos(fi));

            count++;

        }
    }
}
