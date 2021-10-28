using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    static class StatisticOperations
    {
        public static int Max(this Set set)
        {
            int len = set.GetItemByIndex(0).Length;
            foreach (string item in set.GetHash())
            {
                if (len < item.Length)
                    len = item.Length;
            }
            return len;
        }

        public static int Min(this Set set)
        {
            int len = set.GetItemByIndex(0).Length;
            foreach (string item in set.GetHash())
            {
                if (len > item.Length)
                    len = item.Length;
            }
            return len;
        }

        public static int Dif(this Set set)
        {
            return Max(set) - Min(set);
        }

        public static int CountOfWords(this string str)
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            count += words.Length;
            return count;
        }

        public static int Sum(this Set set)
        {
            int len = 0;
            foreach (string item in set.GetHash())
            {
                len += item.Length;
            }
            return len;
        }

        public static void CommaAfterWord(this Set set)
        {
            int len = set.GetSize();
            HashSet<string> res = new HashSet<string>();
            string buf = "0";
            for (int i = 0; i < len; i++)
            {
                buf = set.GetItemByIndex(i);
                res.Add(buf);
                res.Add("Удалено");
            }
            //foreach (string item in res)
            //{
            //    Console.WriteLine(item);
            //}
            set.collection = res;
        }

        public static void RemoveSpace(this Set set)
        {
            set.collection.Remove("0");
        }
    }
}
