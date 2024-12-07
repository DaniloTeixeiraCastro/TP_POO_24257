
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System.Models
{
    public enum AccommodationType
    {
        DoubleRoomGardenView, //Quarto duplo vista jardim
        DoubleRoomPoolView,   // Quarto duplo vista piscina
        TripleRoomGardenView, // Quarto triplo vista jardim
        TripleRoomPoolView    // Quarto triplo vista piscina
    }
    public enum AccommodationStatus
    {
        Available,  // Quarto está disponível
        Occupied    // Quarto está ocupado
    }
    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded,
        PartiallyCompleted
    }

    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Expired
    }
}
