namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int16.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            String[] arr = s.Split();
            int c = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i][0]!='.'){
                    c++;
                }
                else if ((arr[i][0] == '.') && (arr[i].Length == 2))
                {
                    ;
                }
                else if((arr[i][0]=='.') && (arr[i].Length==3)) {
                    c--;
                }
            }
            Console.WriteLine(c);
        }
    }
}