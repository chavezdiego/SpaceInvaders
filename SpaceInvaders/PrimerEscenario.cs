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
            LEneg.Add(new Enemigo(100,50));
            LEneg.Add(new Enemigo(200,150));
            LEneg.Add(new Enemigo(300,200));
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
