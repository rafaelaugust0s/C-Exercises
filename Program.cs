using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum1(10, 10));
            Console.WriteLine(Sum2(15, 15));
            Console.WriteLine(AddIf("if else"));
            Console.WriteLine(AddIf("If else"));
            Console.WriteLine(AddIf(" else"));
            Remove("Python", 1);
            Remove("Python", 0);
            Remove("Python", 4);
            Reverse("abcd");
            Reverse("a");
            Reverse("xy");
            Console.WriteLine(Copies("C Sharp"));
            Console.WriteLine(Copies("JS"));
            Console.WriteLine(Copies("a"));
            Console.WriteLine(AddBothEnds("Red"));
            Console.WriteLine(AddBothEnds("Green"));
            Console.WriteLine(AddBothEnds("1"));
            Console.WriteLine(ThreeChar("Python"));
            Console.WriteLine(ThreeChar("JS"));
            Console.WriteLine(ThreeChar("Code"));
            Console.WriteLine(StartWithC("C#Sharp"));
            Console.WriteLine(StartWithC("cocunut"));
            Console.WriteLine(StartWithC("kocunut"));
            Console.WriteLine(Range(10, 21, 12));
            Console.WriteLine(Range(1, 4, 8));
            Console.WriteLine(LeftRotation("0",));

        }
        //QUESTION # 1
        public static int Sum1(int a, int b)

        {
            return a == b ? (a + b) * 3 : (a + b);
        }
        //QUESTION # 2
        public static Boolean Sum2(int a, int b)
        {
            return a == 30 || b == 30 || (a + b) == 30 ? true : false;   
        }
        //QUESTION # 3
        public static string AddIf(string str)
        {

            return str.Length > 2 && str.Substring(0, 2).Equals("if") ? str : "if " + str;

        }

        //QUESTION # 4
        public static string Remove(string str, int a)
        {
            Console.WriteLine(str.Remove(a, 1));

            return " ";
        }

        //QUESTION # 5
        public static string Reverse(string str) {
            Console.WriteLine(str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str);

            return " ";
        }

        //QUESTION # 6

        public static string Copies(string str)
        {
            return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);

        }

        //QUESTION # 7
        public static string AddBothEnds(string str)
        {
            var w = str.Substring(str.Length - 1);

            return w+ str +w;
        }

        //QUESTION # 8

        public static string ThreeChar(string str)
        { 
            return str.Length < 3 ? str + str + str : str.Substring(0, 3) + str + str.Substring(0, 3);
        }

        //QUESTION # 9
        public static Boolean StartWithC(string str)
        {

            return str.StartsWith("c", 0) || str.StartsWith("C", 0) ?  true : false;
        }

        //QUESTION # 10

        public static Boolean Range(int num1, int num2, int num3)
        {

            return (num1 <= 20 && num1 >= 50) || (num2 <= 20 && num2 >= 50) || (num3 <= 20 && num3 >= 50) ? true: false;
        }

        //QUESTION # 11

        public static int[] LeftRotation(int[]a, int d)
        {
            int n = a.Length;

            int[] NewArray = new int[n];

            for (int oldIndex = 0; oldIndex < n; oldIndex++)
            {

                int newIndex = (oldIndex + n - d) % n;

                NewArray[newIndex] = a[oldIndex];
            }
            return NewArray;
        }

    }
} 
        


           






            

    
















