using System;
public class A
{
	
public static void Main()
	{
		Console.WriteLine("limit");

		int n = Convert.ToInt32(Console.ReadLine());
		
		int[] a = new int[n];
	
		for (int i = 0; i < n; i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());

		}
		Console.WriteLine("number of rotation");

		int k = Convert.ToInt32(Console.ReadLine());
var	c=rotat(a,k);
Console.WriteLine("elements after rotation");
	for (int i = 0; i < c.Length; i++)
		{
			Console.WriteLine(c[i]);
		}
	
}
public static int[] rotat(int[] a,int k)
{
	int m=1;
	int n=a.Length;
	int[] b = new int[a.Length];
		do
		{
			for (int i = 0; i < n; i++)
			{
				if (i == 0)
				{
					b[0] = a[n - 1];
				}
				else
				{
					b[i] = a[i - 1];
				}
				//b[i] = a[n - 1];

			}
			a= (int[])b.Clone();
			m++;
			
			
			
  
		}while(m<= k);
	return b;
}
		
	}
