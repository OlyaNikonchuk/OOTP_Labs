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
        

        public Set(string ownerName, int ownerId)
        {
            this.owner = new Owner(ownerName, ownerId);
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

        public class Owner
        {
            private readonly string name;
            private readonly int id;


            public Owner(string name, int id)
            {
                this.name = name;
                this.id = id;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Имя: {name}, ID: {id}");
            }
        }
    }
}
