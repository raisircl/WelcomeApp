//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace WelcomeApp
//{
//    internal class CallByValueRefOut
//    {
//        // Call by value, call by reference, and call by out are three different ways to pass arguments to a method in C#.
//        // arguments - data which we pass to a method when we call it.
//        // parameters - a variable which receive the data

//        static void Main()
//        {
//            int x = 10;
//            Console.WriteLine($"Before Call X={x}");
//            cbv(x); // x is here actual argument 
//            Console.WriteLine($"After Call X={x}"); // in call by value if any change in formal argument it does not affect actual arguments

//            Console.WriteLine($"Before Call X={x}");
//            cbr(ref x); // x is here actual argument 
//            Console.WriteLine($"After Call X={x}"); // in call by ref if any change in formal argument it  affect actual arguments


//            Console.WriteLine($"Before Call X={x}");
//            cbo(out x); // x is here actual argument 
//            Console.WriteLine($"After Call X={x}"); // in call by ref if any change in formal argument it  affect actual arguments

//        }
//        static void cbv( int num) // num is here formal argument 
//        {
//            num = 100;
//        }
//        static void cbr(ref int num)
//        {
//            Console.WriteLine($"Inside cbr Num={num}");
//            num = 100;
//        }
//        static void cbo(out int num) // value of x will un assigned in num but if any change in num it send to x
//        {
//            //Console.WriteLine($"Inside cbo Num={num}");
//            num = 150;
//        }
//    }
//}
