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
    public partial class PaymentList : Form
    {
        public PaymentList()
        {
            InitializeComponent();
            LoadPayments(); // Carrega os pagamentos no DataGridView
        }
        /// <summary>
        /// Loads payments from the service into the DataGridView.
        /// </summary>


        private void LoadPayments()
        {
            try
            {
                // Retrieve the list of payments from the PaymentService
                var payments = PaymentService.GetPayments();

                // Check if there are payments to display
                if (payments == null || !payments.Any())
                {
                    MessageBox.Show("Nenhum pagamento encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Map payments data to display in the DataGridView
                dataGridView1.DataSource = payments
                    .Where(p => p.Reservation != null && p.Reservation.Accommodation != null) // Ensure null safety
                    .Select(p => new
                    {
                        PaymentID = p.PaymentId,
                        ReservationID = p.Reservation.Id,
                        RoomNumber = p.Reservation.Accommodation.RoomNumber,
                        Amount = p.Amount.ToString("C"), // Format as currency
                        PaymentDate = p.PaymentDate.ToShortDateString(),
                        Status = p.Status.ToString(),
                        Method = p.Method.ToString()
                    })
                    .ToList();

                // Configure DataGridView columns
                FormatDataGridColumns();
            }
            catch (Exception ex)
            {
                // Display any errors that occur during the process
                MessageBox.Show($"Ocorreu um erro ao carregar os pagamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configures DataGridView column headers and properties.
        /// </summary>
        private void FormatDataGridColumns()
        {
            dataGridView1.Columns["PaymentID"].HeaderText = "ID do Pagamento";
            dataGridView1.Columns["ReservationID"].HeaderText = "ID da Reserva";
            dataGridView1.Columns["RoomNumber"].HeaderText = "Número do Quarto";
            dataGridView1.Columns["Amount"].HeaderText = "Montante";
            dataGridView1.Columns["PaymentDate"].HeaderText = "Data do Pagamento";
            dataGridView1.Columns["Status"].HeaderText = "Estado do Pagamento";
            dataGridView1.Columns["Method"].HeaderText = "Método de Pagamento";

            // Adjust column size to fit content
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true; // Prevents user editing directly in DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Placeholder for DataGridView cell click event.
        /// </summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event can be customized for actions on cell clicks if needed
        }

        /// <summary>
        /// Handles the Edit button click event to edit a selected payment.
        /// </summary>
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedPaymentId = (int)dataGridView1.SelectedRows[0].Cells["PaymentID"].Value;

                // Retrieve the payment to edit
                var paymentToEdit = PaymentService.GetPayments().FirstOrDefault(p => p.PaymentId == selectedPaymentId);

                if (paymentToEdit != null)
                {
                    var editForm = new AddEditPayment(paymentToEdit);
                    editForm.ShowDialog();

                    // Reload payments after editing
                    LoadPayments();
                }
                else
                {
                    MessageBox.Show("O pagamento selecionado não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um pagamento para editar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the Remove button click event to delete a selected payment.
        /// </summary>
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedPaymentId = (int)dataGridView1.SelectedRows[0].Cells["PaymentID"].Value;

                var confirmResult = MessageBox.Show("Tem certeza de que deseja remover este pagamento?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    string result = PaymentService.RemovePayment(selectedPaymentId);

                    MessageBox.Show(result, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload payments after removal
                    LoadPayments();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um pagamento para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
