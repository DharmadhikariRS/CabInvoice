using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceProgram
{
    public class CabInvoice
    {
        public double CabInvoiceFare(Ride ride)
        {
            double totalFare = 0;

            if (ride.Distance <= 0)
            {
                throw new CabInvoiceException(CabInvoiceException.cabException.ZERO_DISTANCE, "Distance cant be Negative");
            }
            else if (ride.Time <= 0)
            {
                throw new CabInvoiceException(CabInvoiceException.cabException.ZERO_TIME, "Time cant be Negative");
            }
            else
            {
                totalFare = ride.Distance * ride.FarePerKm + ride.FarePerMin * ride.Time;
            }
            return Math.Max(totalFare, ride.MinFare);
        }
        public double CabInvoiceFare(Ride[] ride)
        {
            double totalFare = 0;
            foreach (Ride ride1 in ride)
            {
                totalFare += CabInvoiceFare(ride1);
            }
            return totalFare;
        }


    }
    }