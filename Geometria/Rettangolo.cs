using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
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
    }
}
