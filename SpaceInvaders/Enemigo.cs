using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    abstract class Enemigo
    {
        protected Punto pos = new Punto();

        protected List<Disparos> LDisparos = new List<Disparos>();

        public Enemigo(int x,int y)
        {
            pos.y = y;
            pos.x = x;
        }

        protected int w = 25;
        protected int h = 25;
        protected int dir=0;

        abstract public void Mover();
       
        public int ObtenerX()
        {
            return pos.x;
        }

        public int ObtenerY()
        {
            return pos.y;
        }

        public int ObtenerW()
        {
            return w;
        }

        public int ObtenerH()
        {
            return h;
        }
        public bool intersectaDispJugador()
        {
            if (Jugador.DispIntersecta(pos.x, pos.y, w, h))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
