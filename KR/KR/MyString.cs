using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public class MyString
    {
        public string String;

        public MyString(string str = " ")
        {
            String = str;
        }

        public void GetInfo()
        {
            Console.WriteLine(String);
        }
    }


    public static class StringExtension
    {
        public static string Vivod(this string str)
        {
            Console.WriteLine(str);
            return str;
        }

        public static string Symb(this string str)
        {
            int j = 5;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == j)
                {
                    Console.WriteLine(str[i]);
                }
            }
            return str;
        }

        public static string Size(this string size)
        {
            Console.WriteLine(size.Length);
            return size;
        }
    }


}
