using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourist_Accommodation_System.Interfaces;

namespace Tourist_Accommodation_System.Services
{
    internal class ReservationManager
    {
        public void MakeReservation(IReservable reservable, DateTime date)
        {
            // Chama o método Reserve no objeto que implementa IReservable
            reservable.Reserve(date);
        }

        public void CancelReservation(IReservable reservable)
        {
            // Chama o método CancelReservation no objeto que implementa IReservable
            reservable.CancelReservation();
        }
    }
}
