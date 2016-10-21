using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class Enemigo
    {
        Punto pos = new Punto();

        public Enemigo(int x,int y)
        {
            pos.y = y;
            pos.x = x;
        }
        
        int dir=0;

        public void Mover()
        {
            switch (dir)
	        {
                case 0: pos.x+=3;
                        break;

                case 1: pos.x-=3;
                        break;
	        }

            if (pos.x >= 780) dir = 1;
            if (pos.x <= 1) dir = 0;
            
        }

        public int ObtenerX()
        {
            return pos.x;
        }

        public int ObtenerY()
        {
            return pos.y;
        }
    }
}
