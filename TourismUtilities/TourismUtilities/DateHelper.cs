using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismUtilities
{
    public class DateHelper
    {
        public int CalculateNights(DateTime checkIn, DateTime checkOut)
        {
            return (checkOut - checkIn).Days;
        }

        public bool IsOverlapping(DateTime checkIn1, DateTime checkOut1, DateTime checkIn2, DateTime checkOut2)
        {
            return checkIn1 < checkOut2 && checkIn2 < checkOut1;
        }
    }
}
