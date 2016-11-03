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
            LEneg.Add(new EnegHorizontal(100,-2000));
            LEneg.Add(new EnegHorizontal(200,-2100));
            LEneg.Add(new EnegHorizontal(200,-1850));
            LEneg.Add(new EnegHorizontal(300,-200));
            LEneg.Add(new EnegHorizontal(100,-50));
            LEneg.Add(new EnegHorizontal(200,-50));
            LEneg.Add(new EnegVertical(100, -2000));
         
            LEneg.Add(new EnegVertical(100, -20));
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
