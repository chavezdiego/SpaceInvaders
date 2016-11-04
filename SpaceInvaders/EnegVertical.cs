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
            w = 100;
            h = 100;
        }

        override public void Mover()
        {
            
            switch (dir)
            {
                case 0: pos.y += 3;
                    break;

                case 1: pos.y -= 3;
                    break;
            }

            if (pos.y >= 400) dir = 1;
            if (pos.y <= 10) dir = 0;

        }
    }
}
