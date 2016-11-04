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
        static Punto pos = new Punto(200, 400);
        static int stepX, stepY, Ygrafico = pos.y - 1800;
        static int w = 200, h = 200;

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
            pos.y -= stepY;
            Ygrafico += stepY;
        }

        static int vidas = 1;
        static public int Vidas()
        {
            return vidas;
        }

        static public void VidasMenos()
        {
            vidas--;
        }

        static public int ObtenerX()
        {
            return pos.x;
        }
        static public int ObtenerY()
        {
            return pos.y;
        }
        static public int ObtenerW()
        {
            return w;
        }
        static public int ObtenerH()
        {
            return h;
        }
        static public int ObtenerYGrafico()
        {
            return Ygrafico;
        }
        static public void ModificarY(int y)
        {
            pos.y = y;
        }
        static public void ModificarYGrafico(int y)
        {
            Ygrafico = y;
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
                if (Calibracion.CalibrarY(disp.ObtenerY()) <= 5)
                {
                    LDisparos.Remove(disp);
                    break;
                }
            }
        }

        static public bool DispIntersecta(int x,int y,int w,int h)
        {
            foreach (Disparos disp in LDisparos)
            {
                if (disp.ObtenerX() >= x && disp.ObtenerX() < (x + w) && disp.ObtenerY() >= y - 1 && disp.ObtenerY() < (y + h))
                {
                    return true;
                }
            }
            return false;
        }

        static public bool IntersectaEneg(Enemigo neg)
        {

            if (pos.x >= neg.ObtenerX() && pos.x < (neg.ObtenerX() + neg.ObtenerW()) && pos.y >= neg.ObtenerY() - 1 && pos.y < (neg.ObtenerY() + neg.ObtenerH()))
            {
                return true;
            }

            return false;
        }
    }
}
