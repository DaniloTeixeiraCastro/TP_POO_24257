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
    public partial class FormAddEditReservation : Form
    {
        private Reservation _currentReservation;
        private bool _isEditMode;

        public FormAddEditReservation(Reservation? reservation = null)
        {
            InitializeComponent();

            // Inicializa _currentReservation
            _currentReservation = reservation ?? new Reservation();

            // Verifica se estamos no modo de edição
            _isEditMode = reservation != null;

            // Configura o formulário para edição ou adição
            if (_isEditMode)
            {
                PopulateFields(); // Preenche os campos com os dados da reserva
            }
            else
            {
                _currentReservation = new Reservation(); // Cria uma nova reserva para o modo de adição
                LoadClientsAndAccommodations(); // Carrega clientes e acomodações disponíveis
            }
        }
        /// <summary>
        /// Preenche os campos do formulário com os dados da reserva existente.
        /// </summary>
        private void PopulateFields()
        {
            if (_currentReservation == null) return;

            comboBox_client.SelectedValue = _currentReservation.Client.Id;
            comboBox_accommodation.SelectedValue = _currentReservation.Accommodation.RoomNumber;
            dateTimePicker_checkIn.Value = _currentReservation.CheckInDate;
            dateTimePicker_checkOut.Value = _currentReservation.CheckOutDate;
            UpdateTotalPrice(); // Atualiza o preço total
        }

        /// <summary>
        /// Carrega os clientes e acomodações disponíveis nas ComboBoxes.
        /// </summary>
        private void LoadClientsAndAccommodations()
        {
            // Carregar clientes
            var clients = ClientService.GetClients();
            comboBox_client.DataSource = clients;
            comboBox_client.DisplayMember = "Name";
            comboBox_client.ValueMember = "Id";
            comboBox_client.SelectedIndex = -1;

            // Carregar acomodações disponíveis
            var accommodations = AccommodationService.GetAccommodations()
                .Where(a => a.Status == AccommodationStatus.Available)
                .ToList();
            comboBox_accommodation.DataSource = accommodations;
            comboBox_accommodation.DisplayMember = "Name";
            comboBox_accommodation.ValueMember = "RoomNumber";
            comboBox_accommodation.SelectedIndex = -1;

            // Carregar status da reserva
            comboBox_status.DataSource = Enum.GetValues(typeof(ReservationStatus));
            comboBox_status.SelectedIndex = -1;
        }

        /// <summary>
        /// Atualiza o preço total baseado no número de noites.
        /// </summary>
        private void UpdateTotalPrice()
        {
            if (comboBox_accommodation.SelectedItem is Accommodation selectedAccommodation &&
                dateTimePicker_checkIn.Value.Date < dateTimePicker_checkOut.Value.Date)
            {
                var checkIn = dateTimePicker_checkIn.Value.Date;
                var checkOut = dateTimePicker_checkOut.Value.Date;
                int numberOfNights = (checkOut - checkIn).Days;

                decimal totalPrice = numberOfNights * selectedAccommodation.PricePerNight;
                label_totalPrice.Text = $"€ {totalPrice:F2}";
            }
            else
            {
                label_totalPrice.Text = "€ 0.00"; // Reseta se as condições não forem atendidas
            }
        }

        /// <summary>
        /// Configura o mínimo permitido para a data de Check-In.
        /// </summary>
        private void FormAddEditReservation_Load(object sender, EventArgs e)
        {
            dateTimePicker_checkIn.MinDate = DateTime.Today;
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void label_client_Click(object sender, EventArgs e)
        {

        }

        private void label_accommodation_Click(object sender, EventArgs e)
        {

        }

        private void label_checkin_Click(object sender, EventArgs e)
        {

        }

        private void label_checkout_Click(object sender, EventArgs e)
        {

        }

        private void label_price_Click(object sender, EventArgs e)
        {

        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Atualiza o preço total ao alterar a acomodação selecionada.
        /// </summary>
        private void comboBox_accommodation_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        /// <summary>
        /// Atualiza o preço total ao alterar a data de Check-In.
        /// </summary>
        private void dateTimePicker_checkIn_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }

        /// <summary>
        /// Atualiza o preço total ao alterar a data de Check-Out.
        /// </summary>
        private void dateTimePicker_checkOut_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void label_totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (comboBox_client.SelectedItem == null || comboBox_accommodation.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um cliente e uma acomodação.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedClient = (Client)comboBox_client.SelectedItem;
            var selectedAccommodation = (Accommodation)comboBox_accommodation.SelectedItem;
            var checkInDate = dateTimePicker_checkIn.Value.Date;
            var checkOutDate = dateTimePicker_checkOut.Value.Date;

            if (checkOutDate <= checkInDate)
            {
                MessageBox.Show("A data de Check-Out deve ser posterior à data de Check-In.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isEditMode)
            {
                // Atualiza os dados da reserva existente
                _currentReservation.Client = selectedClient;
                _currentReservation.Accommodation = selectedAccommodation;
                _currentReservation.CheckInDate = checkInDate;
                _currentReservation.CheckOutDate = checkOutDate;

                var result = ReservationService.UpdateReservation(_currentReservation);
                MessageBox.Show(result, "Atualização de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cria uma nova reserva
                var newReservation = new Reservation(
                    0, // ID será gerado automaticamente
                    selectedClient,
                    selectedAccommodation,
                    checkInDate,
                    checkOutDate
                );

                var result = ReservationService.AddReservation(newReservation);
                MessageBox.Show(result, "Nova Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
    }
}
