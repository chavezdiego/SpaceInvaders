using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class PrimerEscenario
    {
        private PrimerEscenario()
        {

        }
        static List<Enemigo> LEneg = new List<Enemigo>();

        static public void MapaCargar()
        {
            LEneg.Add(new EnegHorizontal(100,1300));
            LEneg.Add(new EnegHorizontal(200,50));
            LEneg.Add(new JefeFinal(200,1550));
        //    LEneg.Add(new EnegHorizontal(300,200));
        //    LEneg.Add(new EnegVertical(200,50));
        //    LEneg.Add(new EnegLibre(200,50));
        //    LEneg.Add(new EnegCircular(400,300));
        }
        static public List<Enemigo> ObtenerList()
        {
            return LEneg;
        }
        static public void Mover()
        {
            foreach (Enemigo neg in LEneg)
            {
                neg.Mover();
            }
        }
    }
}
