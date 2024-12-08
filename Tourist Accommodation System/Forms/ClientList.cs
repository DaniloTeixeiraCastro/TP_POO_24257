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
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();
            LoadClientsToGrid();
        }

        private void dataGridView_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Carrega os clientes no DataGridView.
        /// </summary>
        private void LoadClientsToGrid()
        {
            // Obter os clientes da ClientService
            var clients = ClientService.GetClients();

            // Configurar o DataGridView
            dataGridView_clients.DataSource = null; // Limpar o DataSource antes de configurar
            dataGridView_clients.AutoGenerateColumns = false;

            // Configurar as colunas
            dataGridView_clients.Columns.Clear();
            dataGridView_clients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id" });
            dataGridView_clients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nome", DataPropertyName = "Name" });
            dataGridView_clients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            dataGridView_clients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Telefone", DataPropertyName = "Phone" });
            dataGridView_clients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "NIF", DataPropertyName = "TIN" });
            dataGridView_clients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data de Nascimento", DataPropertyName = "BirthDate" });

            // Exemplo: Ocultar a lista de reservas (se necessário)
            // dataGridView_clients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Reservas", DataPropertyName = "Reservations" });

            // Adicionar dados ao DataGridView
            dataGridView_clients.DataSource = clients;

            // Ajustar o tamanho das colunas
            dataGridView_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

