using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal
{
    internal class Vacation : Travel
    {
        public bool AllInclusive { get; set; }


        public Vacation(string destination, bool allInclusive) : base(destination)
        {
            AllInclusive = allInclusive;
        }

        public override string GetInfo()
        {
            string inclusiveText = AllInclusive ? "All - Inclusive" : "Not All-Inclusive";
            return $"Destination: {Destination},All-Inclusive: {inclusiveText}";
        }
    }
}
