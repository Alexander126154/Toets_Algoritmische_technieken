

//variabelen
int water = 4;
int frisdrank = 7;
int fruitsap = 15;
int bedrag = 120;
int maxBakken = 3;
int tellerWater = 1;
int tellerFrisdrank = 1;
int tellerFruitsap = 1;
int tellerMogelijkeBestellingen = 0;
int tellerCombinaties = 0;
//tekst met rode achtergrond
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("BAKKEN BESTELLEN VOOR 120 EURO");
Console.ResetColor();
//for loop want brute force is met een for loop
for (int i = 0; i < 20; i++)
{
    bedrag = bedrag - fruitsap - frisdrank - water;
    if (bedrag >= fruitsap)
    {
        bedrag = bedrag - fruitsap;
        tellerFruitsap++;
        maxBakken++;
    }
    else if (bedrag >= frisdrank)
    {
        bedrag = bedrag - frisdrank;
        tellerFrisdrank++;
        maxBakken++;
    }
    else if (bedrag >= water)
    {
        bedrag = bedrag - water;
        tellerWater++;
        maxBakken++;
    }
    if (bedrag == 0 && maxBakken <= 20)
    {
        tellerMogelijkeBestellingen++;
        Console.WriteLine($"{tellerWater} water, {tellerFrisdrank} frisdrank, {tellerFruitsap} fruitsap ({tellerWater + tellerFrisdrank + tellerFruitsap} bakken)");
    }
}
//antwoorden
Console.WriteLine($"Aantal mogelijke bestellingen: {tellerMogelijkeBestellingen}");
Console.WriteLine($"Aantal gecontroleerde combinaties: {tellerMogelijkeBestellingen}");
Console.WriteLine($"Minstebakken: {tellerWater} water, {tellerFrisdrank} frisdrank, {tellerFruitsap} fruitsap ({tellerWater + tellerFrisdrank + tellerFruitsap} bakken)");




