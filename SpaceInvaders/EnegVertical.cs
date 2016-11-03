using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class EnegVertical:Enemigo
    {
        public EnegVertical(int x,int y):base(x, y)
        {
        }

        override public void Mover()
        {
            if (pos.y <= -1800)
            {
                y = (-1 * pos.y) - 1800;
            }

            if (pos.y <= -1200 && pos.y > -1799)
            {
                y = -1 * pos.y - 1200;
            }

            if (pos.y <= -600 && pos.y > -1199)
            {
                y = -1 * pos.y - 600;
            }

            if (pos.y <= 0 && pos.y > -599)
            {
                y = -1 * pos.y;
            }

            switch (dir)
            {
                case 0: pos.y -= 3;
                    break;

                case 1: pos.y += 3;
                    break;
            }

            if (y >= 400) dir = 1;
            if (y <= 10) dir = 0;

        }
    }
}
