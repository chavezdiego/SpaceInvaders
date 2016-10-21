using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    class Jugador
    {

        static List<Disparos> LDisparos = new List<Disparos>();
        static Punto pos = new Punto(400,350);
        static int stepX, stepY;

        private Jugador()
        {
        }
        
        static public List<Disparos> LDisparo()
        {
            return LDisparos;
        }
        static public void Step(int x, int y)
        {
            stepX = x;
            stepY = y;
        }

        static public void Mover(int stepX, int stepY)
        {
            pos.x += stepX;
            pos.y += stepY;
        }

        static public int ObtenerX()
        {
            return pos.x;
        }
        static public int ObtenerY()
        {
            return pos.y;
        }
        static public void CrearDisparo()
        {
            LDisparos.Add(new Disparos(pos.x, pos.y));
        }
        static public void MoverDisparos()
        {
            foreach (Disparos disp in LDisparos)
            {
                disp.Mover();
            }
        }
    }
}
