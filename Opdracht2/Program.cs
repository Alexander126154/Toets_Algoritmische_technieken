
//rode tekst
using System.Threading.Channels;

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("CONTROLE VAN KLANTNUMMER");
Console.ResetColor();
//Nummer van klant
int nummerKlant = Convert.ToInt32(Console.ReadLine());
//Antwoord
if (DigitaleWortel(nummerKlant) == 9)
{
    Console.Write($"{DigitaleWortel(nummerKlant)} : geldig");
}
else
{
    Console.Write($"{DigitaleWortel(nummerKlant)} : ongeldig");
}

//Methode 1
static int SomCijfers(int getal)
{
    int Laatste = getal % 10;
    int getalZonderLaatste = getal / 10;
    int som = 0;
    som += Laatste;
    if (getalZonderLaatste == 0)
    {
        return som;
    }
    return SomCijfers(getalZonderLaatste);
}
//Methode 2
static int DigitaleWortel(int getal)
{
    SomCijfers(getal);
    int Laatste = SomCijfers(getal) % 10;
    int getalZonderLaatste = SomCijfers(getal) / 10;
    int som = 0;
    som += Laatste;
    if (som == 9)
    {
        return som;
    }
    return DigitaleWortel(getal);
}