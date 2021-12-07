using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    sealed class Cartoons : Film
    {
        public Cartoons(string name, int showsPerWeek, Date datee, string zhanr, string filme)
            : base(name, showsPerWeek, datee, zhanr, filme)
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
