using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    public class Rettangolo
    {
        // CARATTERISTICHE

        public int baseRettangolo;
        public int altezzaRettangolo;

        // METODI

        public int CalcoloArea()
        {
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }

        public int CalcoloPerimetro()
        {
            int perimetroRettangolo = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetroRettangolo;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("BASE: \t \t" + baseRettangolo + " cm");
            Console.WriteLine("ALTEZZA: \t" + altezzaRettangolo + " cm");
            Console.WriteLine("AREA: \t \t" + CalcoloArea() + " cm2");
            Console.WriteLine("PERIMETRO: \t" + CalcoloPerimetro() + " cm");
        }

        public void Disegna()
        {
            string disegno = " ";

            for (int i = 0; i<baseRettangolo; i++)
            {
                disegno = disegno + "--";
            }

            disegno = disegno + "\n";

            for (int i = 0; i<altezzaRettangolo; i++)
            {
                disegno = disegno + "|";
                for (int y = 0; y<baseRettangolo; y++)
                {
                    disegno = disegno + "  ";
                }
                disegno = disegno + "|\n";
            }

            disegno = disegno + " ";

            for (int i = 0; i < baseRettangolo; i++)
            {
                disegno = disegno + "--";
            }

            Console.WriteLine(disegno);
        }
    }
}
