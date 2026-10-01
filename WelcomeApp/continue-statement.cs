using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeApp
{
    internal class continue_statement
    {
        static void Main()
        {
            int  i;
            for (i = 1; i <= 10; i++)
            {
                if(i==5 || i==7)
                {
                    continue;
                }
                Console.WriteLine($"{i}");
            }
        }
    }
}
