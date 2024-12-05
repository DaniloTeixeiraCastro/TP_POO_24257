using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System.Interfaces
{
    public interface IReservable
    {
        void Reserve(DateTime date); // Método que realiza uma reserva para uma data específica
        void CancelReservation(); // Método que cancela a reserva
        bool IsReserved { get; }
        DateTime ReservationDate { get; set; }

        bool IsAvailable(DateTime date); // Método que verifica disponibilidade
    }


}
