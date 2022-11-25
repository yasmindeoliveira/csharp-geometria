// See https://aka.ms/new-console-template for more information

using Geometria;

Rettangolo usuario = new Rettangolo();

Console.WriteLine("Inserire dimensione base rettangolo:");
int baseUsuario = int.Parse(Console.ReadLine());
usuario.baseRettangolo = baseUsuario;

Console.WriteLine("Inserire dimensione altezza rettangolo:");
int altezzaUsuario = int.Parse(Console.ReadLine());
usuario.altezzaRettangolo = altezzaUsuario;

Console.WriteLine();

Console.WriteLine("Area: \t \t" + usuario.CalcoloArea() + " cm2");
Console.WriteLine("Perimetro: \t" + usuario.CalcoloPerimetro() + " cm");

Console.WriteLine();

// Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:


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

Console.WriteLine("-- Rettangolo2 --");
rettangoloSecondo.StampaRettangolo();

Console.WriteLine();

Console.WriteLine("-- Rettangolo3 --");
rettangoloTerzo.StampaRettangolo();


// Controllo
/*
Console.WriteLine();

Console.WriteLine("Base: " + usuario.baseRettangolo);
Console.WriteLine("Altezza: " + usuario.altezzaRettangolo);
*/


// Per sapere se funzionava il codice
/*
Rettangolo rettangoloPrimo = new Rettangolo();
Rettangolo rettangoloSecondo= new Rettangolo();

rettangoloPrimo.baseRettangolo = 4;
rettangoloPrimo.altezzaRettangolo = 2;

rettangoloSecondo.baseRettangolo = 6;
rettangoloSecondo.altezzaRettangolo = 3;

Console.WriteLine("La base del 1° rettangolo è: " + rettangoloPrimo.baseRettangolo);
Console.WriteLine("L'altezza del 1° rettangolo è: " + rettangoloPrimo.altezzaRettangolo);


Console.WriteLine("L'area del 1° rettangolo è: " + rettangoloPrimo.CalcoloArea());
Console.WriteLine("Il perimetro del 1° rettangolo è: " + rettangoloPrimo.CalcoloPerimetro());

Console.WriteLine();

Console.WriteLine("La base del 2° rettangolo è: " + rettangoloSecondo.baseRettangolo);
Console.WriteLine("L'altezza del 2° rettangolo è: " + rettangoloSecondo.altezzaRettangolo);


Console.WriteLine("L'area del 2° rettangolo è: " + rettangoloSecondo.CalcoloArea());
Console.WriteLine("Il perimetro del 2° rettangolo è: " + rettangoloSecondo.CalcoloPerimetro());
*/

