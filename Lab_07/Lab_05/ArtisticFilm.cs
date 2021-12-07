using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class ArtisticFilm : Film
    {
        public string[] actors;
        //public string Actoris;
        //Actoris+=actors.value;
        public ArtisticFilm(string name, int showsPerWeek, Date datee, string Zhanr, string felm, string[] actor)
            : base(name, showsPerWeek, datee, Zhanr, felm)
        {
            actors = actor;
        }

    }
}
