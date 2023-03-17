using System;

namespace ChangeString
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            char b = Convert.ToChar(Console.ReadLine());
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] != b)
                {
                    Console.Write(a[i]);
                } 
            }
        }
    }
}
