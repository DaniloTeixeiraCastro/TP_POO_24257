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
    public partial class ReservationList : Form
    {
        public ReservationList()
        {
            InitializeComponent();
            LoadReservationsToGrid();
        }
        private void LoadReservationsToGrid()
        {
            // Obtém a lista de reservas do serviço
            var reservations = ReservationService.GetReservations();

            // Adiciona as colunas ao DataGridView, se necessário
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

            // Limpa as linhas existentes
            dataGridView_reservations.Rows.Clear();

            // Adiciona as reservas ao DataGridView
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

        private void dataGridView_reservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
