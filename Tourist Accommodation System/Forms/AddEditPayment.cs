using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourist_Accommodation_System.Models;
using Tourist_Accommodation_System.Services;

namespace Tourist_Accommodation_System.Forms
{
    public partial class AddEditPayment : Form
    {
        /// <summary>
        /// Carrega as reservas na ComboBox.
        /// </summary>
        private void LoadReservationsFromJson()
        {
            // Obtém todas as reservas do serviço
            var reservations = ReservationService.GetReservations();

            // Formata apenas com o número do quarto
            var formattedReservations = reservations.Select(r => new
            {
                RoomNumber = $"Room {r.Accommodation.RoomNumber}", // Apenas o número do quarto
                r.Id,
                r.TotalPrice
            }).ToList();

            comboBox_reservation.DataSource = formattedReservations;
            comboBox_reservation.DisplayMember = "RoomNumber"; // Mostra apenas o número do quarto
            comboBox_reservation.ValueMember = "Id"; // Usa o ID da reserva como valor
            comboBox_reservation.SelectedIndex = -1; // Nenhuma reserva selecionada por padrão
        }

        /// <summary>
        /// Carrega os valores do enum PaymentStatus na ComboBox.
        /// </summary>
        private void LoadPaymentStatus()
        {
            comboBox_status.DataSource = Enum.GetValues(typeof(PaymentStatus))
                                                   .Cast<PaymentStatus>()
                                                   .ToList();
        }

        /// <summary>
        /// Carrega os valores do enum PaymentMethod na ComboBox.
        /// </summary>
        private void LoadPaymentMethods()
        {
            comboBox_method.DataSource = Enum.GetValues(typeof(PaymentMethod))
                                                    .Cast<PaymentMethod>()
                                                    .ToList();
        }
        public AddEditPayment()
        {
            InitializeComponent();

        }

        private void AddEditPayment_Load(object sender, EventArgs e)
        {
            // Configura o limite máximo do NumericUpDown
            numericUpDown.Maximum = 10000; // Ajuste para o valor máximo necessário (ex: 10.000)
            numericUpDown.Minimum = 0;     // Limite mínimo (se necessário)

            // Carrega os dados necessários
            LoadReservationsFromJson();
            LoadPaymentStatus();
            LoadPaymentMethods();
        }

        private void label_reservation_Click(object sender, EventArgs e)
        {

        }

        private void label_amount_Click(object sender, EventArgs e)
        {

        }

        private void label_paymentdate_Click(object sender, EventArgs e)
        {

        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }

        private void label_paymentmethod_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_reservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_reservation.SelectedItem != null)
            {
                // Faz o cast para o tipo anônimo usado no DataSource
                var selectedReservation = comboBox_reservation.SelectedItem;

                // Usa reflection para acessar o TotalPrice
                var totalPrice = (decimal)selectedReservation.GetType().GetProperty("TotalPrice")?.GetValue(selectedReservation, null);

                // Define o TotalPrice no numericUpDown
                numericUpDown.Value = Math.Min(totalPrice, numericUpDown.Maximum); // Garante que não ultrapassa o limite
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // Valida se todos os campos obrigatórios foram preenchidos
            if (comboBox_reservation.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma reserva.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox_status.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um status de pagamento.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox_method.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um método de pagamento.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Captura os valores preenchidos no formulário
            var selectedReservation = comboBox_reservation.SelectedItem as Reservation;
            var amount = numericUpDown.Value;
            var paymentDate = dateTimePicker1.Value;
            var status = (PaymentStatus)comboBox_status.SelectedItem;
            var method = (PaymentMethod)comboBox_method.SelectedItem;

            // Cria um novo objeto Payment
            var newPayment = new Payment(0, selectedReservation, amount, paymentDate, status, method)
            {
                Method = method // Adicione o método ao pagamento
            };

            // Salva o pagamento usando o serviço
            string result = PaymentService.AddPayment(newPayment);

            // Exibe mensagem de sucesso ou erro
            MessageBox.Show(result, "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fecha o formulário após salvar
            Close();

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
