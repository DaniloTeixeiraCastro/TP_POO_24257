using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourist_Accommodation_System.Services;

namespace Tourist_Accommodation_System.Forms
{
    /// <summary>
    /// Form to display and manage the list of reservations.
    /// </summary>
    public partial class ReservationList : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationList"/> class.
        /// </summary>
        public ReservationList()
        {
            InitializeComponent();
            LoadReservationsToGrid();
        }

        /// <summary>
        /// Loads reservations from the ReservationService into the DataGridView.
        /// </summary>
        private void LoadReservationsToGrid()
        {
            // Get the list of reservations from the service
            var reservations = ReservationService.GetReservations();

            // Add columns to the DataGridView if they don't already exist
            if (dataGridView_reservations.Columns.Count == 0)
            {
                dataGridView_reservations.Columns.Add("Id", "Reservation ID");
                dataGridView_reservations.Columns.Add("Client", "Client");
                dataGridView_reservations.Columns.Add("Accommodation", "Accommodation");
                dataGridView_reservations.Columns.Add("CheckInDate", "Check-In Date");
                dataGridView_reservations.Columns.Add("CheckOutDate", "Check-Out Date");
                dataGridView_reservations.Columns.Add("TotalPrice", "Total Price");
                dataGridView_reservations.Columns.Add("Status", "Status");
            }

            // Clear any existing rows
            dataGridView_reservations.Rows.Clear();

            // Add reservations to the DataGridView
            foreach (var reservation in reservations)
            {
                dataGridView_reservations.Rows.Add(
                    reservation.Id,
                    reservation.Client.Name,
                    reservation.Accommodation.Name,
                    reservation.CheckInDate.ToString("dd/MM/yyyy"),
                    reservation.CheckOutDate.ToString("dd/MM/yyyy"),
                    reservation.TotalPrice.ToString("C"),
                    reservation.Status.ToString()
                );
            }
        }

        /// <summary>
        /// Handles cell content click events in the DataGridView.
        /// </summary>
        private void dataGridView_reservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder for future logic when a cell is clicked
        }
    }
}

