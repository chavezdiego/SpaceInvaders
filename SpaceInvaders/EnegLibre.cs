using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class EnegLibre:Enemigo
    {
        public EnegLibre(int x,int y):base(x,y)
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
            switch (dir) //Direccion
            {
                case 0:
                    pos.x += 5;
                    pos.y+=5;
                    break;

                case 1:
                    pos.x -= 5;
                    pos.y -= 5;
                    break;

                case 2:
                    pos.x += 5;
                    pos.y -= 5;
                    break;

                case 3:
                    pos.x-=5;
                    pos.y += 5;
                    break;

            }

            //Limites

            if (pos.x <= 1 && dir == 1) dir = 2;
            if (pos.x <= 1 && dir == 3) dir = 0;
            if (pos.x == 790 && dir == 2) dir = 1;
            if (pos.x == 795 && dir == 0) dir = 3;

            if (y <= 50 && dir == 1) dir = 3;
            if (y <= 50 && dir == 2) dir = 0;
            if (y == 400 && dir == 3) dir = 1;
            if (y == 400 && dir == 0) dir = 2;
        }
    }
}
