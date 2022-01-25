using System;

namespace ConsoleApp2
{
    public class Fahrzeug
    {
        string kennzeichen = "PZ-000";
        double kmstand;
        double verbrauch;
        double benzinpreis;
        double grundpreis;
        double tankinhalt;
        double tankvolumen;
        int kapazitaet;

        public Fahrzeug()
        {
            kennzeichen = "PZ-000";
            kmstand = 0;
            grundpreis = 2;
            kapazitaet = 15;
        }
        public Fahrzeug(string kennzeichen, double kmstand, double kmpreis, double grundpreis, double tankinhalt, double tankvolumen, int kapazitaet)
        {
            this.kennzeichen = kennzeichen;
            this.kmstand = kmstand;
            this.grundpreis = grundpreis;
            this.tankinhalt = tankinhalt;
            this.tankvolumen = tankvolumen;
            this.kapazitaet = kapazitaet;
        }
        /*
        public double BerechnePreis(double strecke)
        {   
            kmstand += strecke;
            if (strecke <= 3)
            {
                return grundpreis;
            }
            else
            {
                this.kmstand += strecke;
                return kmpreis * (strecke - 3) + grundpreis;
            }
        }
        */
        public double BerechneFahrpreis(double strecke)
        {
            kmstand += strecke;
            if (strecke <= 3)
            {
                return grundpreis;
            }
            else
            {
                return verbrauch *= (strecke - 3) / 100 * benzinpreis;
            }
        }

    }
}
