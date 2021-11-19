using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    sealed class Cartoons : Film
    {
        public Cartoons(string name, int showsPerWeek, string zhanr, string filme)
            : base(name, showsPerWeek, zhanr, filme)
        {
            Console.WriteLine("Ok");
        }
        enum Creation
        {
            painting,
            marionette,
            computer,
            plasticine,
        }
    }
}
