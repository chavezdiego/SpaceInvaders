using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    class Graficos
    {
        private Graficos()
        {
                
        }
        
        static List<Disparos> ListDisp = new List<Disparos>();
        static List<Enemigo> ListEneg = new List<Enemigo>();
        static Bitmap bmp = new Bitmap(800, 2000);

        static int seguimientoY = 0;
        static int PreseguimientoY = 0;
        static public Bitmap Dibujar() 
        {
            
            Graphics g = Graphics.FromImage(bmp);

            //Fondo negro

            if (Jugador.ObtenerY()>=-1850)
            {
                PreseguimientoY = Jugador.ObtenerY();
                seguimientoY =  1850 + PreseguimientoY;
            }

            //g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 1000, 600));
            g.DrawImage(Image.FromFile("C:\\Users\\Diego\\Documents\\GitHub\\SpaceInvaders\\SpaceInvaders\\Imagenes\\FondoSpaceInvaders.png"), new Rectangle(0, -1400+seguimientoY, 800, 2000));//-1800+seguimientoY     -1400=0

            
            //Enemigo "Nave"

            ListEneg = PrimerEscenario.ObtenerList();
            

            foreach (Enemigo neg in ListEneg)
            {
                if (neg is JefeFinal)
                {
                    g.DrawImage(Image.FromFile("C:\\Users\\Diego\\Documents\\GitHub\\SpaceInvaders\\SpaceInvaders\\Imagenes\\JefeFinal.png"), new Rectangle(neg.ObtenerX(), -neg.ObtenerY()+seguimientoY, neg.ObtenerW(), neg.ObtenerH()));

                }
                else
                {
                    g.DrawImage(Image.FromFile("C:\\Users\\Diego\\Documents\\Visual Studio 2012\\Projects\\SpaceInvaders\\SpaceInvaders\\Imagenes\\InvadersEng.png"), new Rectangle(neg.ObtenerX(), -neg.ObtenerY()+seguimientoY, neg.ObtenerW(), neg.ObtenerH()));
                }
            }

            //Jugador "Nave"

            g.FillRectangle(Brushes.Red, new Rectangle(Jugador.ObtenerX(), -Jugador.ObtenerY(), 20, 20));

            //Disparos Jugador

            ListDisp = Jugador.LDisparo();

            foreach (Disparos disp in ListDisp)
            {
                g.FillRectangle(Brushes.White, new Rectangle(disp.ObtenerX(), disp.ObtenerY(), 10, 10));    
            }

            //-----------------Intersectas-----------------

            //Intersecta de disparos de jugador a enemigos

            foreach (Enemigo neg in ListEneg)
            {
                if (neg.intersectaDispJugador())
                {
                    ListEneg.Remove(neg);
                    break;
                }
            }

            //Intersecta del enemigo con el jugador

            foreach (Enemigo neg in ListEneg)
            {
                //if (j1.intersectaDisp(neg))
                //{
                //    vidas--;
                //}

                if (Jugador.IntersectaEneg(neg))
                {
                    Jugador.VidasMenos();
                }
            }
            seguimientoY = 0;

            return bmp;


        }
    }
}
