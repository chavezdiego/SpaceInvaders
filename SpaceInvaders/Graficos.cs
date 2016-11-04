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
        static Bitmap bmp = new Bitmap(800, 600);

        static int seguimientoY = 0;
        static int PreseguimientoY = 0;
        static int Ejey = -1800;
        static public Bitmap Dibujar() 
        {
            
            Graphics g = Graphics.FromImage(bmp);

            //Fondo negro
            /*
            if (Jugador.ObtenerY()>=-1850)
            {
                PreseguimientoY = Jugador.ObtenerY();
                seguimientoY =  1850 + PreseguimientoY;
            }
            */
            //g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 1000, 600));
            
            if (Ejey<=-5)
            {
                Ejey = -1800 + seguimientoY;
            }
            
            g.DrawImage(Image.FromFile("C:\\Users\\silvy\\Documents\\GitHub\\SpaceInvaders\\SpaceInvaders\\Imagenes\\FondoSpaceInvaders.png"), new Rectangle(0, Ejey, 800, 2400));//-1800+seguimientoY     -1400=0

            //Enemigo "Nave"

            ListEneg = PrimerEscenario.ObtenerList();
            
            foreach (Enemigo neg in ListEneg)
            {
                if (neg is JefeFinal)
                {
                    g.DrawImage(Image.FromFile(@"C:\Users\silvy\Documents\GitHub\SpaceInvaders\SpaceInvaders\Imagenes\JefeFinal.png"), new Rectangle(neg.ObtenerX(), neg.ObtenerY(), 300, 200));
                }
                if (neg is EnegCircular)
                {
                    g.DrawImage(Image.FromFile(@"C:\Users\silvy\Documents\GitHub\SpaceInvaders\SpaceInvaders\Imagenes\Enemigo2.png"), new Rectangle(neg.ObtenerX(), neg.ObtenerY(), 200, 100));                    
                }
                else
                {
                    g.DrawImage(Image.FromFile(@"C:\Users\silvy\Documents\GitHub\SpaceInvaders\SpaceInvaders\Imagenes\naveenemiga.png"), new Rectangle(neg.ObtenerX(), neg.ObtenerY(), 100, 100));
                }

            }
            if (Ejey == -1500)
            {
                //ListEneg.Add(new EnegHorizontal(10,20));
                ListEneg.Add(new EnegCircular(20,20));
                ListEneg.Add(new JefeFinal(20,20));
            }
            //Jugador "Nave"

            //g.FillRectangle(Brushes.Red, new Rectangle(Jugador.ObtenerX(), Jugador.ObtenerYGrafico(), 100, 100));

            g.DrawImage(Image.FromFile(@"C:\Users\silvy\Documents\GitHub\SpaceInvaders\SpaceInvaders\Imagenes\nave.png"), new Rectangle(Jugador.ObtenerX(), Jugador.ObtenerYGrafico(), 200, 200));

            if (Jugador.ObtenerYGrafico()<=300)
            {
                Jugador.ModificarYGrafico(301);
                seguimientoY= seguimientoY+10;
            }

            //Disparos Jugador

            ListDisp = Jugador.LDisparo();

            foreach (Disparos disp in ListDisp)
            {
                g.FillRectangle(Brushes.White, new Rectangle(disp.ObtenerX(), Calibracion.CalibrarY(disp.ObtenerY()), 10, 10));    
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
            
            return bmp;


        }
    }
}
