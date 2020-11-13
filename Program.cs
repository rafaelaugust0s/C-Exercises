using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();
        }

        public static string test(string str, int n)
        {
            return str.Remove(n, 1);



        }

    }

}







//    Console.WriteLine(test("if else"));
//    Console.WriteLine(test("else"));
//    Console.ReadLine();
//}

//  public static string test(string s)
//   {
//    if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
//    {
//        return s;
//    }
//    return "if " + s;


//Console.WriteLine(" Enter a number - ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(" Enter a number - ");
//int b = Convert.ToInt32(Console.ReadLine());

//if (a == 30 || b == 30 || (a + b) == 30)
//{
//    Console.WriteLine("true");
//}else{
//    Console.WriteLine("false");
//}
//return;


//    Console.WriteLine("Hello World!");

//        Console.WriteLine(SumTriple(2, 2));
//        Console.WriteLine(SumTriple(12, 20));
//        Console.WriteLine(SumTriple(-5, 2));
//}
//    public static int SumTriple(int a, int b)
//    {
//        return a == b ? (a + b) * 3 : a + b;
//    }



