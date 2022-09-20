using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceProgram
{
    public class Ride
    {
        public double Distance;
        public double Time;
        public int FarePerKm;
        public int FarePerMin;
        public int MinFare;
        public Ride(double Distance, double Time, CabType cabType)
        {
            if (cabType == CabType.NORMAL_RIDE)
            {
                this.Distance = Distance;
                this.Time = Time;
                FarePerKm = 10;
                FarePerMin = 1;
                MinFare = 5;
            }
            else
            {
                this.Distance = Distance;
                this.Time = Time;
                FarePerKm = 15;
                FarePerMin = 2;
                MinFare = 20;
            }

        }
    }
}
