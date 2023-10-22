using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_fussballmannschaft_EfeBoraSaglam
{
    internal class Fussballmannschaft
    {
        private string name;

        public int Spielzug;

        private int tore;

        private List<Feldspieler> feldspieler = new List<Feldspieler> ();

        public Fussballmannschaft()
        {
            feldspieler.Add(new Feldspieler());
            this.name = name;
            tore = 0;

        }

        public void AddTore(int anzahl)
        {
            tore += anzahl;
        }

        // Gibt die aktuelle Anzahl der Tore zurück
        public int GetTore()
        {
            return tore;
        }

        public void Spieler()
        {
            if(feldspieler.Count < 10)
            {
                feldspieler.Add(new Feldspieler());
            }
        }

        public string GetName()
        {
            return name;
        }

        private Torwart torwart;

        public void SetTorwart(Torwart torwart)
        {
            this.torwart = torwart;
        }
    }
}
