using System;
class priceunits
{
public static void Main()
{
int price,units,a;
Console.WriteLine("Enter the units");
units=Convert.ToInt32(Console.ReadLine());
if(units<200)
{
price=units*2;
Console.WriteLine(price);
}

if(units>=201 && units<=350)
{ 
a=units-200;
price=400+(a*3);
Console.WriteLine(price);
}

if(units>=351 && units<=500)
{
a=units-350;
price=850+(a*5);
Console.WriteLine(price);
}
if(units>500)
{
a=units-500;
price=1600+(a*7);
Console.WriteLine(price);
}}}


