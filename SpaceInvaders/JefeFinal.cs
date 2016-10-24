using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class JefeFinal:Enemigo
    {

        public JefeFinal(int x, int y):base(x,y)
        {

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
            if (pos.y <= 1) dir = 0;
        }

    }
}
