
Console.WriteLine("Hello World");
Console.WriteLine("Hello World");
/*int number;
int Number = 1;
const float Pi = 3.14f;*/
// Identifiers can not start ewith number or space also can't be a reserved keyword and use meaningful names 
 /*int number4 = number2 + 1;
byte number2= 255;
checked
{
    byte number2 = 255;
    number4 = number2 + 1;
}
{
    byte a = 1;
    {
        byte b =2;
        {
            byte c =3;
        }
    }
}*/

var  number = 2;
int count = 10;
bool isWorking = false;
char character = 'a';
string firstname = "Mosh";
float totalPrice = 20.95f;
Console.WriteLine(number);
Console.WriteLine(count);
Console.WriteLine(totalPrice);
Console.WriteLine(count);
Console.WriteLine(character);
Console.WriteLine(isWorking);


// 
Faction faction = PickFaction();
Console.WriteLine($"You've chosen to join the {faction} Faction.");
Faction PickFaction()
{
 Console.WriteLine("What faction do you want to be?");
 string? choice = Console.ReadLine();
 return choice switch
 {
 "Federation" => Faction.Federation,
 "Klingon" => Faction.Klingon,
 "Romulan" => Faction.Romulan,
 };
}
public enum Faction { Federation, Klingon, Romulan }

/*internal class Program
{
 static void <Main>$(string[] args)
 {
 Faction faction = PickFaction();
 Console.WriteLine($"You've chosen to join the {faction} faction.");
 Faction PickFaction()
 {
 Console.WriteLine("What faction do you want to be?");
 string? choice = Console.ReadLine();
 return choice switch
 {
 "Federation" => Faction.Federation,
 "Klingon" => Faction.Klingon,
 "Romulan" => Faction.Romulan,
 };
 }
 }
}
public enum Faction { Federation, Klingon, Romulan }*/