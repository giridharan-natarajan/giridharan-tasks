using System;
class age
{
public static void Main()
{
int age;
string name;
Console.WriteLine("Enter the name");
 name=Console.ReadLine();
Console.WriteLine("Enter the age");
 age=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<age;i++)
{
Console.WriteLine(name);
}
}
}