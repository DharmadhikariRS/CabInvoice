using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceProgram
{
    public class EnhancedInvoiceWithAvarageFare
    {
        public int TotalRide;
        public double TotalFare;
        public double AvarageFare;

        public EnhancedInvoiceWithAvarageFare(int totalRide, double totalFare)
        {
            TotalRide = totalRide;
            TotalFare = totalFare;
            AvarageFare = TotalFare / TotalRide;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is EnhancedInvoiceWithAvarageFare))
            {
                return false;
            }
            else
            {
                EnhancedInvoiceWithAvarageFare Invoice = (EnhancedInvoiceWithAvarageFare)obj;
                return this.TotalRide == Invoice.TotalRide && this.TotalFare == Invoice.TotalFare && this.AvarageFare == Invoice.AvarageFare;
            }
        }
    }
}
