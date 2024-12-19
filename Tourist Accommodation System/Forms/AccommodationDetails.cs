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
    public partial class AccommodationDetails : Form
    {
        public AccommodationDetails()
        {
            InitializeComponent();
        }
        #region
        private void label_type_Click(object sender, EventArgs e)
        {

        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }

        private void label_view_Click(object sender, EventArgs e)
        {

        }

        private void label_price_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Carregar ComboBox e ListBox
        /// <summary>
        /// Preenche as ComboBox com os valores dos enums.
        /// </summary>
        private void LoadComboBoxFilters()
        {
            comboBox_type.DataSource = Enum.GetValues(typeof(AccommodationType));
            comboBox_status.DataSource = Enum.GetValues(typeof(AccommodationStatus));

            // Preencher com valores fictícios para "View" e "Price" caso não haja enums correspondentes
            comboBox_price.Items.AddRange(new string[] { "< 100", "100-200", "> 200" });

            comboBox_type.SelectedIndex = -1;
            comboBox_status.SelectedIndex = -1;
            comboBox_price.SelectedIndex = -1;
        }

        /// <summary>
        /// Atualiza a ListBox com a lista de acomodações.
        /// </summary>
        private void UpdateAccommodationList(List<Accommodation> accommodations = null)
        {
            if (accommodations == null)
            {
                accommodations = AccommodationService.GetAccommodations();
            }

            listBox_details.Items.Clear();
            foreach (var accommodation in accommodations)
            {
                listBox_details.Items.Add($"Room {accommodation.RoomNumber}: {accommodation.Type}, Status: {accommodation.Status}, Price: {accommodation.PricePerNight:C}");
            }
        }
        #endregion
        #region Eventos das ComboBox
        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_price_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_details_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region Botões "Clean" e "Apply"
        private void button_clean_Click(object sender, EventArgs e)
        {
            // Limpa todas as seleções das ComboBox
            comboBox_type.SelectedIndex = -1;
            comboBox_status.SelectedIndex = -1;
            comboBox_price.SelectedIndex = -1;

            // Limpa a ListBox
            listBox_details.Items.Clear();

            // Recarrega todas as acomodações
            UpdateAccommodationList();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            // Obter os filtros selecionados
            var selectedType = (AccommodationType?)comboBox_type.SelectedItem;
            var selectedStatus = (AccommodationStatus?)comboBox_status.SelectedItem;

            // Determinar os valores de preço
            decimal? minPrice = comboBox_price.SelectedItem?.ToString() switch
            {
                "< 100" => 0,
                "100-200" => 100,
                _ => null
            };

            decimal? maxPrice = comboBox_price.SelectedItem?.ToString() switch
            {
                "< 100" => 100,
                "100-200" => 200,
                "> 200" => null,
                _ => null
            };

            // Aplicar os filtros
            var filteredAccommodations = AccommodationService.FilterAccommodations(
                selectedType,
                selectedStatus,
                minPrice,
                maxPrice
            );

            // Atualizar a lista
            UpdateAccommodationList(filteredAccommodations);
        }
        #endregion

        #region Load do Formulário
        private void AccommodationDetails_Load(object sender, EventArgs e)
        {
            LoadComboBoxFilters(); // Carrega os filtros
            UpdateAccommodationList(); // Carrega a lista inicial
        }
        #endregion
    }
}
