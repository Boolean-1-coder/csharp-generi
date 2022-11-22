// See https://aka.ms/new-console-template for more information
// Generi Musicali = Pop, Rock, Jazz, Elettronica

// PROBLEMA: Stampare la percentuale di utenti che ascoltano ogni genere musicale richiesto!


Console.Write("Inserisci il numero di utenti Pop: ");
int utentiPop = int.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di utenti Rock: ");
int utentiRock = int.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di utenti Jazz: ");
int utentiJazz = int.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di utenti Elettronica: ");
int utentiElettronica = int.Parse(Console.ReadLine());

int totaleUtenti = utentiPop + utentiRock + utentiJazz + utentiElettronica;

double percentualePop = 100 * (double)utentiPop / totaleUtenti;
double percentualeRock = 100 * (double)utentiRock / totaleUtenti;
double percentualeJazz = 100 * (double)utentiJazz / totaleUtenti;
double percentualeElettronica = 100 * (double)utentiElettronica / totaleUtenti;


Console.WriteLine("Percentuale utenti che ascoltano Pop: " + percentualePop + " sdsdf %");
Console.WriteLine("Percentuale utenti che ascoltano Rock: " + percentualeRock + " sdfsf %");
Console.WriteLine("Percentuale utenti che ascoltano Jazz: " + percentualeJazz + " sdfsdf %");
Console.WriteLine("Percentuale utenti che ascoltano Elettronica: " + percentualeElettronica + " sf sdf  %");
