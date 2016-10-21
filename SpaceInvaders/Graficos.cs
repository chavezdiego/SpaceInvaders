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
        static int posX = 400, posY = 350;
        static double count = 0;
        static double fi = 1.0;
        static List<Disparos> ListDisp = new List<Disparos>();
        static List<Enemigo> ListEneg = new List<Enemigo>();
        static Bitmap bmp = new Bitmap(800, 600);
         
        static public void CambiarYjug(int yjug)
        {
            posY = yjug;
        }

        static public void CambiarXjug(int xjug)
        {
            posX = xjug;
        }

        static public Bitmap Dibujar() 
        {
            
            Graphics g = Graphics.FromImage(bmp);

            //Fondo negro

            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 800, 600));

            //Enemigo "Nave"

            ListEneg = PrimerEscenario.ObtenerList();

            foreach (Enemigo neg in ListEneg)
            {
                g.DrawImage(Image.FromFile("C:\\Users\\Diego\\Documents\\Visual Studio 2012\\Projects\\SpaceInvaders\\SpaceInvaders\\Imagenes\\InvadersEng.png"), new Rectangle(neg.ObtenerX(), neg.ObtenerY(), 25, 25));
    
            }

            //Jugador "Nave"

            g.FillRectangle(Brushes.Red, new Rectangle(Jugador.ObtenerX(), Jugador.ObtenerY(), 20, 20));

            //Disparos Jugador

            ListDisp = Jugador.LDisparo();

            foreach (Disparos disp in ListDisp)
            {
                g.FillRectangle(Brushes.White, new Rectangle(disp.ObtenerX(), disp.ObtenerY(), 10, 10));    
            }

            //Movimiento circular

            fi = (count * Math.PI) / 10;

            //y = (int)(y_inic + 100 * Math.Sin(fi));

           // x = (int)(x_inic + 100 * Math.Cos(fi));

            count++;

            return bmp;


        }
    }
}
