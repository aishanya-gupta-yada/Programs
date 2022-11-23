using System;
using System.Collections;
public class Class1
{
	public Class1(string args[])
	{
		int n = int16.Parse(Console.ReadLine());
		String s = Console.ReadLine();
		Stack s1 = new Stack();
		String[] a = s.split();
		for(int i=0;i<n;i++)
		{
			if(a[i][0]!='.')
			{
				s1.Push(a[i]);
			}
            else if (a[i]=="./")
            {
				;
            }
            else if (a[i]=="../")
			{
				s1.Pop();
			}
		}
		Console.WriteLine(s1.Length);
	}
}
