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
            int[] a = { 1, 2, 3, 4, 5 };
            LeftRotation(a, 2);
            Console.WriteLine(Sub("HelloWorld", 3, 6));
            Console.WriteLine(Validation("a_a"));
            Console.WriteLine(FunnyString("acxz"));
            Console.WriteLine(FunnyString("bcxztyu"));


        }
        /**
         * QUESTION # 1 
         * @param int a  
         * @param int b   
         * @return int 
         */
        public static int Sum1(int a, int b)
        {
            return a == b ? (a + b) * 3 : (a + b);
        }

        /**
         * QUESTION # 2 
         * @param int a  
         * @param int b   
         * @return boolean 
         */
        public static Boolean Sum2(int a, int b)
        {
            return a == 30 || b == 30 || (a + b) == 30 ? true : false;
        }

        /**
         * QUESTION # 3 
         * @param string str 
         * @return string int
         */
        public static string AddIf(string str)
        {
            return str.Length > 2 && str.Substring(0, 2).Equals("if") ? str : "if " + str;
        }

        /**
         * QUESTION # 4
         * @param string str 
         * @param int a
         * @return string
         */
        public static string Remove(string str, int a)
        {
            Console.WriteLine(str.Remove(a, 1));
            return " ";
        }

        /**
         * QUESTION # 5 
         * @param string str 
         * @return string 
         **/
        public static string Reverse(string str)
        {
            Console.WriteLine(str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str);
            return " ";
        }

        /**
         * QUESTION # 6 
         * @param string str
         * @return string 
         */
        public static string Copies(string str)
        {
            return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }

        /**
         * QUESTION # 7 
         * @param string str
         * @return string 
         */
        public static string AddBothEnds(string str)
        {
            var w = str.Substring(str.Length - 1);
            return w + str + w;
        }

        /**
         * QUESTION # 8
         * @param string str
         * @return string
         */
        public static string ThreeChar(string str)
        {
            return str.Length < 3 ? str + str + str : str.Substring(0, 3) + str + str.Substring(0, 3);
        }

        /**
         * QUESTION # 9 
         * @ param string str 
         * @ return boolean
         */
        public static Boolean StartWithC(string str)
        {
            return str.StartsWith("c", 0) || str.StartsWith("C", 0) ? true : false;
        }

        /**
         * QUESTION # 10 
         * @param int num1 
         * @param int num2
         * @param int num3 
         * @return boolean
         */
        public static Boolean Range(int num1, int num2, int num3)
        {
            return (num1 <= 20 && num1 >= 50) || (num2 <= 20 && num2 >= 50) || (num3 <= 20 && num3 >= 50) ? true : false;
        }

        /**
         * QUESTION # 11 
         * @param int[]a
         * @int d  
         * @return int[]
         */
        public static int[] LeftRotation(int[] a, int d)
        {
            int n = a.Length;
            int[] NewArray = new int[n];
            for (int oldIndex = 0; oldIndex < n; oldIndex++)
            {
                int newIndex = (oldIndex + n - d) % n;
                NewArray[newIndex] = a[oldIndex];
                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine(a[i]);
                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine(NewArray[i]);
            }
            return NewArray;
        }

        /**
         * QUESTION # 12 
         * @param String s
         * @String[]ns 
         * @return String[]
         */
        public static string Sub(String s, int start, int end)
        {
            return s.Substring(start, end - 1);
        }

        /**
            * QUESTION # 13
            * @param String userName
            * @return String
            */

        public static String Validation(String userName)
        {
            int n = userName.Length;
            if (n > 8 && n < 30)
            {
                return "Valid User name";
            }
            else
            {
                for (int i = 0; i < userName.Length; i++)
                {
                    int first = (int)userName[0];
                    if ((first >= 97 && first <= 122) || (first >= 65 && first <= 90))
                    {
                        return "Valid User name";
                    }
                    else
                    {
                        for (int j = 0; j < userName.Length; j++)
                        {
                            int alpha = (int)userName[j];

                            if ((alpha == 95) || (alpha >= 97 && alpha <= 122) || (alpha >= 65 && alpha <= 90) || (alpha >= 48 && alpha <= 57))
                            {
                                return "Valid User name";
                            }
                            else
                            {
                                return "Invalid user name";
                            }
                        }
                    }

                }
                return userName;

            }
        }

        /**
        * QUESTION # 14
        * @param String str
        * @return String
        */
        public static String FunnyString(String str)
        {
            string rev = " ";
            int n = str.Length;
            for (int i = n - 1; i >= 0; i--)
                rev += str[i];
            int j; 
            for (j = 0; j < n - 1; j++)
            {
                int right = Math.Abs(str[j] - str[j + 1]);
                int left = Math.Abs(rev[j] - rev[j + 1]);
            }
            return (j == n - 1) ? "funny" : "not funny";
        } 
    }
}
