// See https://aka.ms/new-console-template for more information

using Geometria;

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
