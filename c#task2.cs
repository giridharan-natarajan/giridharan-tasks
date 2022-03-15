using System;
class Rate
{
public static void Main()
{
Console.WriteLine("enter the package");
string package=Console.ReadLine();
switch(package)
{
case "A":Console.WriteLine("The package cost is RS250   Channels:Southspecial,children's club,movies.");
break;
case "B":Console.WriteLine("The package cost is RS450    Channels:News,sports,movies,regional2.");
break;
case "C":Console.WriteLine("The package cost is RS350   Channels:Discovery,history,national.");
break;


}
}
}