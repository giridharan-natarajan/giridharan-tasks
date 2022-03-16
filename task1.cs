using System;
class inherit
{
public void Add(int n1,int n2)
{
Console.WriteLine(n1+n2);
Console.WriteLine(n1-n2);
}
}
class inheritance:inherit
{
public void Mul(int n1,double n2)
{
Console.WriteLine(n1*n2);
Console.WriteLine(n1/n2);
}
}
class task1
{
public static void Main()
{
inheritance obj=new inheritance();
Console.WriteLine("Add and sub");
obj.Add(22,30);
Console.WriteLine("Mul and div");
obj.Mul(25,33.5);
}
}