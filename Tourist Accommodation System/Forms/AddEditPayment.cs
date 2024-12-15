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
        private Payment _currentPayment; // Reference to the payment being edited
        private bool _isEditMode; // Flag to indicate edit mode

        /// <summary>
        /// Default constructor for adding a new payment.
        /// </summary>
        public AddEditPayment()
        {
            InitializeComponent();
            _isEditMode = false; // Indicates new payment
        }

        /// <summary>
        /// Constructor for editing an existing payment.
        /// </summary>
        /// <param name="payment">The payment to be edited.</param>
        public AddEditPayment(Payment payment) : this() // Calls the default constructor
        {
            _currentPayment = payment;
            _isEditMode = true;
        }

        /// <summary>
        /// Handles the form load event.
        /// </summary>
        private void AddEditPayment_Load(object sender, EventArgs e)
        {
            // Load dropdowns
            LoadReservationsFromJson();
            LoadPaymentStatus();
            LoadPaymentMethods();

            if (_isEditMode && _currentPayment != null)
            {
                PopulateFields(); // Pre-fill fields for editing
            }
        }

        /// <summary>
        /// Populates form fields with payment data for editing.
        /// </summary>
        private void PopulateFields()
        {
            comboBox_reservation.SelectedValue = _currentPayment.Reservation.Id;
            numericUpDown.Value = _currentPayment.Amount;
            dateTimePicker1.Value = _currentPayment.PaymentDate;
            comboBox_status.SelectedItem = _currentPayment.Status;
            comboBox_method.SelectedItem = _currentPayment.Method;
        }
        /// <summary>
        /// Loads all reservations into the ComboBox, displaying only the room number.
        /// </summary>
        private void LoadReservationsFromJson()
        {
            // Obtém todas as reservas do serviço
            var reservations = ReservationService.GetReservations();

            // Formata apenas com o número do quarto
            var formattedReservations = reservations.Select(r => new
            {
                Display = $"Room {r.Accommodation.RoomNumber}", // Shows room number only
                Reservation = r // Keeps the full reservation object
            }).ToList();

            comboBox_reservation.DataSource = formattedReservations;
            comboBox_reservation.DisplayMember = "Display"; // Display the room number
            comboBox_reservation.ValueMember = "Reservation"; // Keeps the full reservation object
            comboBox_reservation.SelectedIndex = -1; // No selection by default
        }

        /// <summary>
        /// Loads the payment status options from the PaymentStatus enum.
        /// </summary>
        private void LoadPaymentStatus()
        {
            comboBox_status.DataSource = Enum.GetValues(typeof(PaymentStatus))
                                                   .Cast<PaymentStatus>()
                                                   .ToList();
        }

        /// <summary>
        /// Loads the payment method options from the PaymentMethod enum.
        /// </summary>
        private void LoadPaymentMethods()
        {
            comboBox_method.DataSource = Enum.GetValues(typeof(PaymentMethod))
                                                    .Cast<PaymentMethod>()
                                                    .ToList();
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

        /// <summary>
        /// Updates the payment amount (TotalPrice) when a reservation is selected.
        /// </summary>
        private void comboBox_reservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_reservation.SelectedItem != null)
            {
                var selectedReservation = (comboBox_reservation.SelectedItem as dynamic)?.Reservation;

                if (selectedReservation != null)
                {
                    // Sets the TotalPrice to numericUpDown, ensuring it stays within the valid range
                    numericUpDown.Value = Math.Min((decimal)selectedReservation.TotalPrice, numericUpDown.Maximum);
                }
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
        /// <summary>
        /// Handles the Save button click event to save the payment details.
        /// </summary>
        private void button_save_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (comboBox_reservation.SelectedItem == null ||
                comboBox_status.SelectedItem == null ||
                comboBox_method.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve values from the form
            var selectedReservationId = (int)comboBox_reservation.SelectedValue;
            var selectedReservation = ReservationService.GetReservations()
                                        .FirstOrDefault(r => r.Id == selectedReservationId);

            var amount = numericUpDown.Value;
            var paymentDate = dateTimePicker1.Value;
            var status = (PaymentStatus)comboBox_status.SelectedItem;
            var method = (PaymentMethod)comboBox_method.SelectedItem;

            if (_isEditMode)
            {
                // Update existing payment
                _currentPayment.Reservation = selectedReservation;
                _currentPayment.Amount = amount;
                _currentPayment.PaymentDate = paymentDate;
                _currentPayment.Status = status;
                _currentPayment.Method = method;

                PaymentService.UpdatePayment(_currentPayment);
                MessageBox.Show("Pagamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Add new payment
                var newPayment = new Payment(0, selectedReservation, amount, paymentDate, status, method);
                PaymentService.AddPayment(newPayment);
                MessageBox.Show("Pagamento adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close(); // Close the form
        }
        /// <summary>
        /// Handles the Cancel button click event to close the form without saving.
        /// </summary>
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
