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
    public partial class AccommodationManagementForm : Form
    {
        public AccommodationManagementForm()
        {
            InitializeComponent();
            LoadAccommodationsToComboBox();

        }

        private void button_remove_Click(object sender, EventArgs e)
        {

            if (comboBox_accommodation == null)
            {
                MessageBox.Show("Erro: ComboBox de acomodações não está inicializada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox_accommodation.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma acomodação para remover.");
                return;
            }

            var selectedText = comboBox_accommodation.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedText))
            {
                MessageBox.Show("Erro ao obter a acomodação selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(selectedText, out int roomNumber))
            {
                MessageBox.Show("Erro: Não foi possível converter o número do quarto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string resultMessage = AccommodationService.RemoveAccommodation(roomNumber);

            MessageBox.Show(resultMessage);


            LoadAccommodationsToComboBox();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            {
                if (comboBox_accommodation.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecione uma acomodação para editar.");
                    return;
                }


                var selectedAccommodation = AccommodationService.GetAccommodations()[comboBox_accommodation.SelectedIndex];

                FormAddEditAccommodation editForm = new FormAddEditAccommodation(selectedAccommodation);
                editForm.ShowDialog();

                AccommodationService.AddOrUpdateAccommodation(selectedAccommodation);

                LoadAccommodationsToComboBox();
            }


        }

        private void comboBox_accommodation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAccommodationList()
        {

            var accommodations = AccommodationService.GetAccommodations();


            comboBox_accommodation.Items.Clear(); 
            foreach (var accommodation in accommodations)
            {
                comboBox_accommodation.Items.Add($"Quarto {accommodation.RoomNumber}: {accommodation.Name}, {accommodation.Capacity} pessoas, {accommodation.PricePerNight:C}");
            }


            comboBox_accommodation.SelectedIndex = -1; 
        }
        private void AccommodationManagementForm_Load(object sender, EventArgs e)
        {
            UpdateAccommodationList();
        }

        private void AccommodationManagementForm_Load_1(object sender, EventArgs e)
        {

        }
        private void LoadAccommodationsToComboBox()
        {
            comboBox_accommodation.Items.Clear(); 

            var accommodations = AccommodationService.GetAccommodations(); 
            foreach (var accommodation in accommodations)
            {
                comboBox_accommodation.Items.Add($"Room {accommodation.RoomNumber}: {accommodation.Name}, Price: {accommodation.PricePerNight:C}");
            }

            comboBox_accommodation.SelectedIndex = -1; 
        }
    }
}

