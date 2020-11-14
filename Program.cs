using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter first number - ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter second number - ");
            int b = Convert.ToInt32(Console.ReadLine());

        }
        public static int Sum (int a, int b, int nums)
        {

            nums = 0;

            if (nums == a && nums == b)
            {
                Console.WriteLine((a + b) * 3);
            }
            else
            {
                Console.WriteLine(a + b);

            }

            return nums;


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





//    Console.WriteLine(test("Python", 1));
//    Console.WriteLine(test("Python", 0));
//    Console.WriteLine(test("Python", 4));
//    Console.ReadLine();
//}

//public static string test(string str, int n)
//{
//    return str.Remove(n, 1);
