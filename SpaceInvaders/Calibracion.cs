using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class Calibracion
    {
        private Calibracion()
        {
    
        }
        static int y;

        static public int CalibrarY(int yinic)
        {

            if (yinic <= 1800 && yinic >= 1201)
            {
                y = yinic - 1200;
            }

            if (yinic <= 1200 && yinic >= 601)
            {
                y = yinic - 600;
            }

            if (yinic <= 600 && yinic > 0)
            {
                y = yinic;
            }

            if (yinic <= 2400 && yinic >= 1801)
            {
                y = yinic - 1800;
            }

            return y;
        }
    }
}
