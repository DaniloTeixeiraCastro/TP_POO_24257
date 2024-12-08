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
    public partial class ReservationManagementForm : Form
    {
        public ReservationManagementForm()
        {
            InitializeComponent();
        }

        private void InitializeReservationGrid()
        {
            // Limpa as colunas existentes, se houver
            dataGridView_reservation.Columns.Clear();

            // Adiciona as colunas necessárias
            dataGridView_reservation.Columns.Add("Id", "Reservation ID");
            dataGridView_reservation.Columns.Add("Client", "Client");
            dataGridView_reservation.Columns.Add("Accommodation", "Accommodation");
            dataGridView_reservation.Columns.Add("CheckIn", "Check-In Date");
            dataGridView_reservation.Columns.Add("CheckOut", "Check-Out Date");
            dataGridView_reservation.Columns.Add("TotalPrice", "Total Price");
            dataGridView_reservation.Columns.Add("Status", "Status");
        }

        private void LoadReservationsToGrid()
        {
            // Inicializa as colunas (se necessário)
            InitializeReservationGrid();

            // Limpa as linhas existentes
            dataGridView_reservation.Rows.Clear();

            // Carrega as reservas
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

        private void dataGridView_reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_reservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma reserva para editar.");
                return;
            }

            var selectedRow = dataGridView_reservation.SelectedRows[0];
            var reservationId = (int)selectedRow.Cells["Id"].Value;

            var reservation = ReservationService.GetReservations().FirstOrDefault(r => r.Id == reservationId);

            if (reservation != null)
            {
                var formAddEditReservation = new FormAddEditReservation(reservation);
                formAddEditReservation.ShowDialog();

                // Atualiza a DataGridView após edição
                LoadReservationsToGrid();
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dataGridView_reservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma reserva para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID da reserva a partir da célula selecionada
            int selectedReservationId = Convert.ToInt32(dataGridView_reservation.SelectedRows[0].Cells["Id"].Value);

            // Confirmação do usuário antes de remover
            var confirmation = MessageBox.Show(
                "Tem certeza de que deseja remover esta reserva?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation == DialogResult.Yes)
            {
                // Remove a reserva usando o serviço
                var result = ReservationService.RemoveReservation(selectedReservationId);

                // Exibe mensagem de sucesso ou erro
                MessageBox.Show(result, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a grade de reservas
                LoadReservationsToGrid();
            }
        }

        private void ReservationManagementForm_Load(object sender, EventArgs e)
        {
            LoadReservationsToGrid();
        }
    }
}
