
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Accommodation_System.Models
{
    /// <summary>
    /// Types of available accommodations.
    /// </summary>
    public enum AccommodationType
    {
        /// <summary>
        /// Double room with garden view.
        /// </summary>
        DoubleRoomGardenView,

        /// <summary>
        /// Double room with pool view.
        /// </summary>
        DoubleRoomPoolView,

        /// <summary>
        /// Triple room with garden view.
        /// </summary>
        TripleRoomGardenView,

        /// <summary>
        /// Triple room with pool view.
        /// </summary>
        TripleRoomPoolView
    }

    /// <summary>
    /// Availability status of accommodations.
    /// </summary>
    public enum AccommodationStatus
    {
        /// <summary>
        /// The room is available for booking.
        /// </summary>
        Available,

        /// <summary>
        /// The room is currently occupied.
        /// </summary>
        Occupied
    }

    /// <summary>
    /// Status of a payment.
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        /// Payment has not been processed yet.
        /// </summary>
        Pending,

        /// <summary>
        /// Payment has been successfully completed.
        /// </summary>
        Completed,

        /// <summary>
        /// Payment has failed.
        /// </summary>
        Failed,

        /// <summary>
        /// Payment has been refunded.
        /// </summary>
        Refunded,

        /// <summary>
        /// Payment has been partially completed.
        /// </summary>
        PartiallyCompleted
    }

    /// <summary>
    /// Status of a reservation.
    /// </summary>
    public enum ReservationStatus
    {
        /// <summary>
        /// Reservation is pending confirmation.
        /// </summary>
        Pending,

        /// <summary>
        /// Reservation has been confirmed and is active.
        /// </summary>
        Confirmed,

        /// <summary>
        /// Reservation has been cancelled.
        /// </summary>
        Cancelled,

        /// <summary>
        /// Reservation has expired and is no longer valid.
        /// </summary>
        Expired
    }

    /// <summary>
    /// Rating for reviews (from 1 to 5 stars).
    /// </summary>
    public enum ReviewRating
    {
        /// <summary>
        /// One star (lowest rating).
        /// </summary>
        OneStar = 1,

        /// <summary>
        /// Two stars.
        /// </summary>
        TwoStars = 2,

        /// <summary>
        /// Three stars (average rating).
        /// </summary>
        ThreeStars = 3,

        /// <summary>
        /// Four stars.
        /// </summary>
        FourStars = 4,

        /// <summary>
        /// Five stars (highest rating).
        /// </summary>
        FiveStars = 5
    }

    /// <summary>
    /// Available payment methods.
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// Payment in cash.
        /// </summary>
        Cash,

        /// <summary>
        /// Payment via credit card.
        /// </summary>
        CreditCard,

        /// <summary>
        /// Payment via debit card.
        /// </summary>
        DebitCard,

        /// <summary>
        /// Payment via bank transfer.
        /// </summary>
        BankTransfer
    }
}
