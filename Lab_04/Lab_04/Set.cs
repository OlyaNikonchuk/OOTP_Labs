using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class Set
    {

        private readonly Data data;
        private readonly Owner owner;
        public HashSet<String> collection;
        public int Size;

        public Set(string ownerName, int ownerId)
        {
            this.owner = new Owner(ownerName, ownerId);
            this.collection = new HashSet<string>();
            this.data = new Data();
        }

        public Owner GetOwner()
        {
            return owner;
        }
        public HashSet<string> GetHash()
        {
            return collection;
        }
        internal class Data
        {
            public readonly DateTime time;

            public Data()
            {
                time = DateTime.Now;
            }

        }
        public void Show()
        {
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public int GetSize()
        {
            int size = 0;
            foreach (string item in collection)
            {
                size++;
            }
            return size;
        }

        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public class Date
        {
            public readonly DateTime time;

            public Date()
            {
                time = DateTime.Now;
            }
        }

        public string GetItemByIndex(int index)
        {
            if (index > this.GetSize() - 1)
                throw new Exception("GetItemByIndex: OutOfRange");

            int size = -1;
            foreach (string item in collection)
            {
                size++;
                if (size == index)
                    return item;
            }
            return "";
        }


        #region Overload

        public static Set operator *(Set set, Set set2)
        {
            set.collection.IntersectWith(set2.collection);
            return set;
        }

        public static Set operator >(Set set, Set set2)
        {
            Set result = set;
            foreach (string item in set.collection)
            {
                if (!set2.collection.Contains(item))
                {
                    set.AddItem(item);
                }
                result = set;
            }
            foreach (string item in set2.collection)
            {
                if (!set.collection.Contains(item))
                {
                    set2.AddItem(item);
                }
                result = set2;

            }
            return result;
        }

        public static Set operator <(Set set, Set set2)
        {
            if (set.collection.IsSubsetOf(set2.collection))
                return set;
            else
                return set2;
        }

        #endregion
    }
}
