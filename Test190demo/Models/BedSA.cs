using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test190demo.Models
{
    public class BedSA
    {
        public Selection1 OpenWindow { get; set; }

        public Selection2 Mould { get; set; }

        public Selection2 Plants { get; set; }

        public Selection1 Smoke { get; set; }

        public Selection2 Carpet { get; set; }

        public enum Selection1
        {
            Yes, No, Often
        }

        public enum Selection2
        {
            Yes, No
        }
    }
}