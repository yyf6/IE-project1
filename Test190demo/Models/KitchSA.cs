using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test190demo.Models
{
    public class KitchSA
    {
        public Selection2 RangeHood { get; set; }

        public Selection2 Heat { get; set; }

        public Selection2 Aerosol { get; set; }

        public enum Source
        {
            Electricity, NaturalGas, LPG
        }

        public enum Selection2
        {
            Yes, No
        }
    }
}