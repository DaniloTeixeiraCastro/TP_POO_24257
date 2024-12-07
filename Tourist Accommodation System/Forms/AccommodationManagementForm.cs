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
            // Verificar se a ComboBox está inicializada
            if (comboBox_accommodation == null)
            {
                MessageBox.Show("Erro: ComboBox de acomodações não está inicializada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se uma acomodação foi selecionada
            if (comboBox_accommodation.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma acomodação para remover.");
                return;
            }

            // Obter o número do quarto da acomodação selecionada
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

            // Remover a acomodação do serviço
            string resultMessage = AccommodationService.RemoveAccommodation(roomNumber);

            // Exibir mensagem de confirmação ou erro
            MessageBox.Show(resultMessage);

            // Atualizar a ComboBox com as acomodações restantes
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

                // Obter a acomodação selecionada
                var selectedAccommodation = AccommodationService.GetAccommodations()[comboBox_accommodation.SelectedIndex];

                // Abrir o formulário de edição com os dados pré-carregados
                FormAddEditAccommodation editForm = new FormAddEditAccommodation(selectedAccommodation);
                editForm.ShowDialog();

                // Após a edição, atualize o JSON
                AccommodationService.AddOrUpdateAccommodation(selectedAccommodation);

                // Atualizar a ComboBox com os novos dados
                LoadAccommodationsToComboBox();
            }


        }

        private void comboBox_accommodation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox_accommodation = new System.Windows.Forms.ComboBox();
        }

        private void UpdateAccommodationList()
        {
            // Obtém a lista de acomodações do serviço
            var accommodations = AccommodationService.GetAccommodations();

            // Atualiza a ComboBox ou ListBox com as acomodações
            comboBox_accommodation.Items.Clear(); // ou listBox_accommodations.Items.Clear();
            foreach (var accommodation in accommodations)
            {
                comboBox_accommodation.Items.Add($"Quarto {accommodation.RoomNumber}: {accommodation.Name}, {accommodation.Capacity} pessoas, {accommodation.PricePerNight:C}");
            }

            // Nenhum item selecionado por padrão
            comboBox_accommodation.SelectedIndex = -1; // Caso esteja usando ComboBox
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
            comboBox_accommodation.Items.Clear(); // Limpa a ComboBox

            var accommodations = AccommodationService.GetAccommodations(); // Obter a lista de acomodações
            foreach (var accommodation in accommodations)
            {
                comboBox_accommodation.Items.Add($"Room {accommodation.RoomNumber}: {accommodation.Name}, Price: {accommodation.PricePerNight:C}");
            }

            comboBox_accommodation.SelectedIndex = -1; // Nenhum item selecionado por padrão
        }
    }
}

