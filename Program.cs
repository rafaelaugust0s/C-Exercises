using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum1(10, 10);
            Sum2(15, 15);
            AddIf("if else");
            AddIf("else");
            Remove("Python", 1);
            Remove("Python", 0);
            Remove("Python", 4);
            Reverse("abcd");
            Reverse("a");
            Reverse("xy");



        }
        //QUESTION # 1
        public static int Sum1(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine((a + b) * 3);
            }
            else
            {
                Console.WriteLine((a + b));
            }
            return 0;
        }
        //QUESTION # 2
        public static int Sum2(int a, int b)
        {

            if (a == 30 || b == 30 || (a + b) == 30)
            {
                Console.WriteLine("true");
                }
                else
                {
                Console.WriteLine("false");
            }

            return 0;
        }
        //QUESTION # 3
        public static string AddIf(string str)
        {

            if (str.Length > 2 && str.Substring(0, 2).Equals("if"))
            {
                Console.WriteLine(str);
                }
                else
                {
                Console.WriteLine("if " + str);
            }
            return " ";
        }

        //QUESTION # 4
        public static string Remove(string str, int a)
        {

            Console.WriteLine(str.Remove(a, 1));

                return " ";

        }

        //QUESTION # 5
        public static string Reverse(string str)
        {

            Console.WriteLine(str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str);

            return " ";
        }


        //QUESTION # 6

        public static string 
    }
}
           






            

    
















//    Console.WriteLine(test("Python", 1));
//    Console.WriteLine(test("Python", 0));
//    Console.WriteLine(test("Python", 4));
//    Console.ReadLine();
//}

//public static string test(string str, int n)
//{
//    return str.Remove(n, 1);
