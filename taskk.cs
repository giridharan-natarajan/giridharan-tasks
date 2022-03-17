using System;
abstract class Stayaccomadation
{
public abstract void Foodresort();
}
class Abc:Stayaccomadation
{
public override void Foodresort()

{
Console.WriteLine("silver gives 3 days accomadation in resort , Gold gives 5 days accomadation in resort , Platinum gives 7 days accomadation at resort");
}
}
class Def:Stayaccomadation
{
public override void Foodresort()
{
Console.WriteLine("Gold gives 2 dinner and platinum gives 5 dinner");
}
}
class taskk
{
public static void Main()
{
Abc obj= new Abc();
obj.Foodresort();
Def obj2= new Def();
obj2.Foodresort();
}
}