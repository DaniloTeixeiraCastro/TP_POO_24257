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
    /// Form to manage reservations, including viewing, editing, and removing reservations.
    /// </summary>
    public partial class ReservationManagementForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationManagementForm"/> class.
        /// </summary>
        public ReservationManagementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the reservation DataGridView with the necessary columns.
        /// </summary>
        private void InitializeReservationGrid()
        {
            // Clears existing columns if any
            dataGridView_reservation.Columns.Clear();

            // Adds the required columns
            dataGridView_reservation.Columns.Add("Id", "Reservation ID");
            dataGridView_reservation.Columns.Add("Client", "Client");
            dataGridView_reservation.Columns.Add("Accommodation", "Accommodation");
            dataGridView_reservation.Columns.Add("CheckIn", "Check-In Date");
            dataGridView_reservation.Columns.Add("CheckOut", "Check-Out Date");
            dataGridView_reservation.Columns.Add("TotalPrice", "Total Price");
            dataGridView_reservation.Columns.Add("Status", "Status");
        }

        /// <summary>
        /// Loads reservations into the DataGridView from the ReservationService.
        /// </summary>
        private void LoadReservationsToGrid()
        {
            // Initialize the columns if necessary
            InitializeReservationGrid();

            // Clears existing rows
            dataGridView_reservation.Rows.Clear();

            // Loads reservations
            foreach (var reservation in ReservationService.GetReservations())
            {
                dataGridView_reservation.Rows.Add(
                    reservation.Id,
                    reservation.Client.Name,
                    reservation.Accommodation.Name,
                    reservation.CheckInDate.ToShortDateString(),
                    reservation.CheckOutDate.ToShortDateString(),
                    reservation.TotalPrice.ToString("C"),
                    reservation.Status.ToString()
                );
            }
        }

        /// <summary>
        /// Handles cell content click events in the DataGridView.
        /// </summary>
        private void dataGridView_reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder for future logic when a cell is clicked
        }

        /// <summary>
        /// Handles the click event for the edit button.
        /// </summary>
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_reservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to edit.");
                return;
            }

            var selectedRow = dataGridView_reservation.SelectedRows[0];
            var reservationId = (int)selectedRow.Cells["Id"].Value;

            var reservation = ReservationService.GetReservations().FirstOrDefault(r => r.Id == reservationId);

            if (reservation != null)
            {
                var formAddEditReservation = new FormAddEditReservation(reservation);
                formAddEditReservation.ShowDialog();

                // Updates the DataGridView after editing
                LoadReservationsToGrid();
            }
        }

        /// <summary>
        /// Handles the click event for the remove button.
        /// </summary>
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_reservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedReservationId = Convert.ToInt32(dataGridView_reservation.SelectedRows[0].Cells["Id"].Value);

            var confirmation = MessageBox.Show(
                "Are you sure you want to remove this reservation?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation == DialogResult.Yes)
            {
                var result = ReservationService.RemoveReservation(selectedReservationId);

                MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadReservationsToGrid();
            }
        }

        /// <summary>
        /// Handles the load event for the ReservationManagementForm.
        /// </summary>
        private void ReservationManagementForm_Load(object sender, EventArgs e)
        {
            LoadReservationsToGrid();
        }
    }
}
