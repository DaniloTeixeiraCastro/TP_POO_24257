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
    public partial class FormAddEditAccommodation : Form
    {
        private Accommodation accommodation;
        public FormAddEditAccommodation()
        {
            InitializeComponent();
        }
        // Construtor para editar uma acomodação existente
        public FormAddEditAccommodation(Accommodation accommodation) : this()
        {
            this.accommodation = accommodation;

            // Preencher os campos com os dados da acomodação
            textBox_name.Text = accommodation.Name;
            textBox_location.Text = accommodation.Location;
            textBox_roomnumber.Text = accommodation.RoomNumber.ToString();
            textBox_capacity.Text = accommodation.Capacity.ToString();
            textBox_price.Text = accommodation.PricePerNight.ToString("F2");
        }

        #region

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void label_location_Click(object sender, EventArgs e)
        {

        }

        private void label_roomnumber_Click(object sender, EventArgs e)
        {

        }

        private void label_capacity_Click(object sender, EventArgs e)
        {

        }

        private void label_price_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_roomnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddEditAccommodation_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // Recolher os dados do formulário
            string name = textBox_name.Text;
            string location = textBox_location.Text;
            int roomNumber = int.TryParse(textBox_roomnumber.Text, out var rn) ? rn : 0;
            int capacity = int.TryParse(textBox_capacity.Text, out var cap) ? cap : 0;
            decimal pricePerNight = decimal.TryParse(textBox_price.Text, out var price) ? price : 0;

            // Criar ou atualizar a acomodação
            Accommodation accommodation = new Accommodation
            {
                RoomNumber = roomNumber,
                Name = name,
                Location = location,
                Capacity = capacity,
                PricePerNight = pricePerNight,
                IsAvailable = true // Ou ajuste conforme necessário
            };

            // Salva ou atualiza no serviço
            string result = AccommodationService.AddOrUpdateAccommodation(accommodation);

            // Exibe a mensagem de resultado
            MessageBox.Show(result);

            // Fecha o formulário se tudo ocorreu bem
            if (result == "Acomodação salva com sucesso!")
            {
                this.Close();
            }
        }

    }
}
