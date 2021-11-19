using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class Ads : TVProgramm
    {
        public string AdsProducts;
        public override string ToString()
        {
            if (String.IsNullOrEmpty(AdsProducts))
                return base.ToString();
            return "Продукты рекламируемые: " + AdsProducts;
        }
        public Ads(string name, int showsPerWeek, string ads)
           : base(name, showsPerWeek)
        {

            AdsProducts = ads;
        }

    }
}
