using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class EnegHorizontal:Enemigo
    {
        public EnegHorizontal(int x,int y):base( x,  y)
        {
            w = 100;
            h = 100;
        }

        override public void Mover()
        {
            switch (dir)
            {
                case 0: pos.x += 3;
                    break;

                case 1: pos.x -= 3;
                    break;
            }

            if (pos.x >= 780) dir = 1;
            if (pos.x <= 1) dir = 0;

        }
    }
}
