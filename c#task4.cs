using System;
class array
{
public static void Main()
{
int[]marks=new int[5]; 
int sum=0,percentage;
Console.WriteLine("enter the marks");
for(int i=0;i<5;i++)
{
marks[i]=Convert.ToInt32(Console.ReadLine());
sum=sum+marks[i];
}
Console.WriteLine("The total is {0}",sum);
percentage=sum/5;
Console.WriteLine("The percentage is {0}",percentage);
}}