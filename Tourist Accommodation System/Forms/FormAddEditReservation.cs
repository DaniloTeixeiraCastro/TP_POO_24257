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

            // Verifica se estamos no modo de edição
            _isEditMode = reservation != null;

            if (_isEditMode)
            {
                _currentReservation = reservation ?? throw new ArgumentNullException(nameof(reservation), "Reservation cannot be null in edit mode.");
                PopulateFields(); // Preenche os campos com os dados da reserva
            }
            else
            {
                _currentReservation = new Reservation(); // Cria uma nova reserva para adição
                LoadClientsAndAccommodations(); // Carrega os dados básicos
            }
        }
        /// <summary>
        /// Preenche os campos do formulário com os dados da reserva existente.
        /// </summary>
        private void PopulateFields()
        {
            if (_currentReservation == null) return;

            // Configura as fontes de dados das ComboBoxes antes de selecionar os itens
            LoadClientsAndAccommodations();

            // Seleciona o cliente
            comboBox_client.SelectedValue = _currentReservation.Client.Id;

            // Seleciona a acomodação
            comboBox_accommodation.SelectedValue = _currentReservation.Accommodation.RoomNumber;

            // Configura as datas
            dateTimePicker_checkIn.Value = _currentReservation.CheckInDate;
            dateTimePicker_checkOut.Value = _currentReservation.CheckOutDate;

            // Configura o preço e o status
            label_price.Text = _currentReservation.TotalPrice.ToString("C");
            comboBox_status.SelectedItem = _currentReservation.Status.ToString();
        }

        /// <summary>
        /// Carrega os clientes e acomodações disponíveis nas ComboBoxes.
        /// </summary>
        private void LoadClientsAndAccommodations()
        {
            // Carregar os clientes na ComboBox
            var clients = ClientService.GetClients();
            comboBox_client.DataSource = clients;
            comboBox_client.DisplayMember = "Name";
            comboBox_client.ValueMember = "Id";
            comboBox_client.SelectedIndex = -1; // Nenhum cliente selecionado por padrão

            // Carregar as acomodações na ComboBox
            var accommodations = AccommodationService.GetAccommodations()
                .Where(a => a.Status == AccommodationStatus.Available) // Apenas acomodações disponíveis
                .ToList();
            comboBox_accommodation.DataSource = accommodations;
            comboBox_accommodation.DisplayMember = "Name";
            comboBox_accommodation.ValueMember = "RoomNumber";
            comboBox_accommodation.SelectedIndex = -1; // Nenhuma acomodação selecionada por padrão

            // **Carregar os valores do enum na ComboBox Status**
            comboBox_status.DataSource = Enum.GetValues(typeof(AccommodationStatus));
            comboBox_status.SelectedIndex = -1; // Nenhum status selecionado por padrão
        }
        private void UpdateAvailableAccommodations()
        {
            if (dateTimePicker_checkIn.Value.Date >= dateTimePicker_checkOut.Value.Date)
            {
                MessageBox.Show("A data de Check-Out deve ser posterior à de Check-In.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Carrega as acomodações disponíveis para o intervalo selecionado
            var availableAccommodations = AccommodationService.GetAccommodations()
                .Where(a => ReservationService.ValidateAvailability(a, dateTimePicker_checkIn.Value, dateTimePicker_checkOut.Value))
                .ToList();

            if (!availableAccommodations.Any())
            {
                MessageBox.Show("Nenhuma acomodação está disponível para as datas selecionadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Atualiza a ComboBox de acomodações
            comboBox_accommodation.DataSource = availableAccommodations;
            comboBox_accommodation.DisplayMember = "Name";
            comboBox_accommodation.ValueMember = "RoomNumber";
            comboBox_accommodation.SelectedIndex = -1; // Nenhuma acomodação selecionada por padrão
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
            UpdateAvailableAccommodations();

        }

        /// <summary>
        /// Atualiza o preço total ao alterar a data de Check-Out.
        /// </summary>
        private void dateTimePicker_checkOut_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateAvailableAccommodations();
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

            if (dateTimePicker_checkOut.Value <= dateTimePicker_checkIn.Value)
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
