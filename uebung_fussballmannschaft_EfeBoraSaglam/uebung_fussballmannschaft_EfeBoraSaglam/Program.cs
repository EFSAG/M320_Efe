namespace uebung_fussballmannschaft_EfeBoraSaglam
{

    //Efe Bora Saglam
    //Klasse 2EI
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fussballmanschaft Übung\n\n\n");

            Fussballmannschaft gates = new Fussballmannschaft();
            Fussballmannschaft fussballmannschaftops = new Fussballmannschaft();
            //Hier werden die Mannschaften vorgestellt
            Console.WriteLine("Classic XI\n\nRonaldo\nSalah\nMbappe\nMesut Özil\nModric\nValverde\nCarlos\nRamos\nVarane\nHakimi\nLivakovic\n\n\n");
            Console.WriteLine("Manchster City\n\nHaaland\nFoden\nAlvarez\nKovacic\nDe Bruyne\nSilva\nGvardiol\nAke\nRuben Dias\nWalker\nEderson\n\n\n");

            gates.Spieler();
            gates.Spieler();
            gates.Spieler();
            gates.Spieler();
            gates.Spieler();
            gates.Spieler();
            gates.Spieler();
            gates.Spieler();
            gates.Spieler();
            gates.Spieler();

            Fussballmannschaft Fenerbahce = new Fussballmannschaft();
            Torwart Livakovic = new Torwart();

            Livakovic.SetFussballmanschaft(Fenerbahce);
            Fenerbahce.SetTorwart(Livakovic);



            Torwart torwartOps = new Torwart();
            Feldspieler feldspielerOps = new Feldspieler();


            
            Torwart torwart = new Torwart("Livakovic");

            List<Torwart> torwartlist = new List<Torwart>
            {
                torwart
            };


            Torwart torwartA = new Torwart("Ederson");

            List<Torwart> torwartersteMannschaft = new List<Torwart>
            {
                torwartA
            };

            Random rand1 = new Random();

            List<Torwart> torwartgesamtListe = torwartlist.Concat(torwartersteMannschaft).ToList();

            torwartgesamtListe = torwartgesamtListe.OrderBy(x => rand1.Next()).ToList();

            foreach (Torwart name in torwartgesamtListe)
            {
                int aktion = rand1.Next(2);

                switch (aktion)
                {
                    case 0:
                        name.Schusshalten();
                        break;
                    case 1:
                        name.Abstoss();
                        break;
                }
            }

            torwart.Abstoss();


            Feldspieler spieler = new Feldspieler("Ronaldo");
            Feldspieler spieler1 = new Feldspieler("Salah");
            Feldspieler spieler2 = new Feldspieler("Mbappe");
            Feldspieler spieler3 = new Feldspieler("Mesut Özil");
            Feldspieler spieler4 = new Feldspieler("Modric");
            Feldspieler spieler5 = new Feldspieler("Valverde");
            Feldspieler spieler6 = new Feldspieler("Carlos");
            Feldspieler spieler7 = new Feldspieler("Ramos");
            Feldspieler spieler8 = new Feldspieler("Varane");
            Feldspieler spieler9 = new Feldspieler("Hakimi");

            List<Feldspieler> spielerListe = new List<Feldspieler>
            {
                spieler,
                spieler1,
                spieler2,
                spieler3,
                spieler4,
                spieler5,
                spieler6,
                spieler7,
                spieler8,
                spieler9
            };

            Feldspieler spielerA = new Feldspieler("Haaland");
            Feldspieler spielerB = new Feldspieler("Foden");
            Feldspieler spielerC = new Feldspieler("Alvarez");
            Feldspieler spielerD = new Feldspieler("Kovacic");
            Feldspieler spielerE = new Feldspieler("De Bruyne");
            Feldspieler spielerF = new Feldspieler("Silva");
            Feldspieler spielerG = new Feldspieler("Gvardiol");
            Feldspieler spielerH = new Feldspieler("Ake");
            Feldspieler spielerI = new Feldspieler("Ruben Dias");
            Feldspieler spielerJ = new Feldspieler("Walker");

            List<Feldspieler> zweiteMannschaft = new List<Feldspieler>
            {
                spielerA,
                spielerB,
                spielerC,
                spielerD,
                spielerE,
                spielerF,
                spielerG,
                spielerH,
                spielerI,
                spielerJ
            };


            Random rand = new Random();

            List<Feldspieler> gesamtListe = spielerListe.Concat(zweiteMannschaft).ToList();

            gesamtListe = gesamtListe.OrderBy(x => rand.Next()).ToList();

            foreach (Feldspieler name in gesamtListe)
            {
                int aktion = rand.Next(3);

                switch(aktion)
                {
                    case 0:
                        name.Dribbeln();
                        break;
                    case 1:
                        name.AusTorSchiessen();
                        break;
                    case 2:
                        name.Greatschen();
                        break;
                }
            }

            Random random = new Random();
            int zufallsIndex = random.Next(spielerListe.Count);
            Feldspieler zufallsSpieler = spielerListe[zufallsIndex];

            zufallsSpieler.Dribbeln();

            Random random1 = new Random();
            int zufallsIndex1 = random1.Next(spielerListe.Count);
            Feldspieler zufallsSpieler1 = spielerListe[zufallsIndex1];

            zufallsSpieler1.Greatschen();

            Random random2 = new Random();
            int zufallsIndex2 = random2.Next(spielerListe.Count);
            Feldspieler zufallsSpieler2 = spielerListe[zufallsIndex2];

            zufallsSpieler2.AusTorSchiessen();

            Random randomt = new Random();
            int zufallsIndext = randomt.Next(torwartgesamtListe.Count);
            Torwart zufallsTorwart = torwartgesamtListe[zufallsIndext];

            zufallsTorwart.Schusshalten();

            Random randomta = new Random();
            int zufallsIndexta = randomta.Next(torwartgesamtListe.Count);
            Torwart zufallsTorwart1 = torwartgesamtListe[zufallsIndexta];

            zufallsTorwart1.Abstoss();




            Fussballmannschaft team1 = new Fussballmannschaft();
            Fussballmannschaft team2 = new Fussballmannschaft();


            team1.AddTore(rand.Next(6));  
            team2.AddTore(rand.Next(6));

            Console.WriteLine($"{team1.GetName()}Classic XI {team1.GetTore()}-{team2.GetTore()} {team2.GetName()} Manchester City");
        }
    }
}