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
    public partial class AcommodationList : Form
    {
        public AcommodationList()
        {
            InitializeComponent();
            LoadAccommodationsToGrid();
        }

        private void dataGridView_Accommodations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAccommodationsToGrid()
        {
            // Obtém a lista de acomodações
            var accommodations = AccommodationService.GetAccommodations();

            // Configura o DataGridView
            dataGridView_Accommodations.DataSource = null;
            dataGridView_Accommodations.Rows.Clear();
            dataGridView_Accommodations.Columns.Clear();

            // Adiciona colunas ao DataGridView
            dataGridView_Accommodations.Columns.Add("RoomNumber", "Room Number");
            dataGridView_Accommodations.Columns.Add("Name", "Name");
            dataGridView_Accommodations.Columns.Add("Type", "Type");
            dataGridView_Accommodations.Columns.Add("Capacity", "Capacity");
            dataGridView_Accommodations.Columns.Add("PricePerNight", "Price Per Night");
            dataGridView_Accommodations.Columns.Add("Status", "Status");

            // Adiciona linhas ao DataGridView
            foreach (var accommodation in accommodations)
            {
                dataGridView_Accommodations.Rows.Add(
                    accommodation.RoomNumber,
                    accommodation.Name,
                    accommodation.Type.ToString(),
                    accommodation.Capacity,
                    accommodation.PricePerNight.ToString("C"), // Formatação de preço
                    accommodation.Status.ToString()
                );
            }

            // Configurações opcionais para o DataGridView
            dataGridView_Accommodations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Accommodations.ReadOnly = true;
            dataGridView_Accommodations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}

