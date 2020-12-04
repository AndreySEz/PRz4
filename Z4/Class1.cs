using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Bus
    {
        public string busRiderName;
        public int busRouteNumber;
        public string busMark;
        public int busYear;
        public int busProbeg;

        public Bus(string busRiderName, int busNumber, string busMark, int busYear, int busProbeg)
        {
            this.busRiderName = busRiderName;
            this.busRouteNumber = busNumber;
            this.busMark = busMark;
            this.busYear = busYear;
            this.busProbeg = busProbeg;
        }
        public string GetInfo()
        {
            return $"{busRiderName}\t {busRouteNumber}\t {busMark}\t {busYear}\t {busProbeg}";
        }
    }
}
