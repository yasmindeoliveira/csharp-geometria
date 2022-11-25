// See https://aka.ms/new-console-template for more information

using Bonus;

Rettangolo rettangoloPrimo = new Rettangolo();
Rettangolo rettangoloSecondo = new Rettangolo();
Rettangolo rettangoloTerzo = new Rettangolo();

rettangoloPrimo.baseRettangolo = 4;
rettangoloPrimo.altezzaRettangolo = 2;

rettangoloSecondo.baseRettangolo = 6;
rettangoloSecondo.altezzaRettangolo = 2;

rettangoloTerzo.baseRettangolo = 8;
rettangoloTerzo.altezzaRettangolo = 4;

Console.WriteLine("-- Rettangolo1 --");
rettangoloPrimo.StampaRettangolo();

Console.WriteLine();
// DISEGNO

rettangoloPrimo.Disegna();

Console.WriteLine();

Console.WriteLine("-- Rettangolo2 --");
rettangoloSecondo.StampaRettangolo();

Console.WriteLine();
// DISEGNO

rettangoloSecondo.Disegna();

Console.WriteLine();

Console.WriteLine("-- Rettangolo3 --");
rettangoloTerzo.StampaRettangolo();

Console.WriteLine();
// DISEGNO

rettangoloTerzo.Disegna();


