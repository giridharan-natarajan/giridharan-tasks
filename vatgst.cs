using System;
class vatgst
{
public virtual void taxcalculation()
{
int x;
double vat;
Console.WriteLine("enter the value x:");
x=Convert.ToInt32(Console.ReadLine());
vat=x*(1+0.2);
Console.WriteLine(vat);
}
}
class gstcalculation:vatgst
{
public override void taxcalculation()
{
int y;
double gst;
Console.WriteLine("enter the value of y:");
y=Convert.ToInt32(Console.ReadLine());
gst =y*1.2;
Console.WriteLine(gst);
}}
class inherit
{
public static void Main()
{
vatgst obj=new vatgst();
gstcalculation obj2=new gstcalculation();
obj.taxcalculation();
obj2.taxcalculation();
}}
                  