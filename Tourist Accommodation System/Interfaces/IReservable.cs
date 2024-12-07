using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System.Interfaces
{
    public interface IReservable
    {
        /// <summary>
        /// Realiza uma reserva para uma data específica.
        /// </summary>
        /// <param name="date">Data para a qual a reserva será feita.</param>
        /// <returns>True se a reserva foi bem-sucedida, False caso contrário.</returns>
        bool Reserve(DateTime date);

        /// <summary>
        /// Cancela uma reserva existente.
        /// </summary>
        /// <returns>True se o cancelamento foi bem-sucedido, False caso contrário.</returns>
        bool CancelReservation();

        /// <summary>
        /// Indica se a entidade está reservada.
        /// </summary>
        bool IsReserved { get; }

        /// <summary>
        /// Data da reserva atual, ou null se não houver reserva.
        /// </summary>
        DateTime? ReservationDate { get; set; }

        /// <summary>
        /// Verifica a disponibilidade para uma data específica.
        /// </summary>
        /// <param name="date">Data a ser verificada.</param>
        /// <returns>True se disponível, False caso contrário.</returns>
        bool IsAvailable(DateTime date);
    }


}
