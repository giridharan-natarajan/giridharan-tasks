using System;
class Mass
{ 
    int num1;
	public Mass()
	{
		Console.WriteLine("Giridharan");
		
	}
	public Mass(int num1)
	{
		this.num1=num1;
		
	}
	public static void Main()
{
   Mass obj= new Mass();
  Mass obj2=new Mass(24);
  Console.WriteLine(obj2.num1);
    
	}
}