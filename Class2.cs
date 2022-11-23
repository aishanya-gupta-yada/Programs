using System;
using System.Collections;
public class Class1
{
	public Class1(string args[])
	{
		string s = Console.ReadLine();
		Stack s1 = new Stack();
		string os = "[](){}";
		s1.Push(s[0]);
		for(int i=1;i<s.Length;i++)
		{
			char c = s1.Peek();
			int a = s.IndexOf(c);
			if (s[i] == os[a+1])
			{
				s1.Pop();
			}
			else
			{
				s1.Push(s[i]);
			}
		}
		if(s1.Length==0)
		{
			Console.WriteLine("Balanced");
		}
		else
		{
			Console.WriteLine("Not Balanced");
		}
	}
}
