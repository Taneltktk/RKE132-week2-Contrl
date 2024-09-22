// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Hello, Tanel!");

//rakendus küsib kasutajalt tema sugu (m/f)
//rakendus küsib kasutajalt tema perekonnanime
//lähtudes kasutaja valikust, tervitab rakendus kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]

Console.WriteLine("Please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your surname:");
string surName = Console.ReadLine();


if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {surName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {surName}!");
}
else
{
    Console.WriteLine($"Welcome, {surName}!");
}


