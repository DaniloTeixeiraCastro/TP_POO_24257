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
    /// <summary>
    /// Form for managing clients, including editing and removing existing clients.
    /// </summary>
    public partial class ClientManagementForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientManagementForm"/> class.
        /// </summary>
        public ClientManagementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the edit button.
        /// </summary>
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            var selectedClientText = comboBox1.SelectedItem.ToString();
            var clientId = int.Parse(selectedClientText.Split(':')[1].Split(',')[0].Trim());

            var client = ClientService.GetClients().FirstOrDefault(c => c.Id == clientId);
            if (client == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            FormAddEditClient editClientForm = new FormAddEditClient(client);
            editClientForm.ShowDialog();

            UpdateClientComboBox();
        }

        /// <summary>
        /// Handles the click event for the remove button.
        /// </summary>
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um cliente para remover.");
                return;
            }

            string selectedClient = comboBox1.SelectedItem.ToString();
            int clientId = int.Parse(selectedClient.Split(':')[1].Split(',')[0].Trim());

            string result = ClientService.RemoveClient(clientId);

            MessageBox.Show(result);

            LoadClientsIntoComboBox();
        }

        /// <summary>
        /// Updates the items in the client ComboBox.
        /// </summary>
        private void UpdateClientComboBox()
        {
            comboBox1.Items.Clear(); // Clears the ComboBox

            var clients = ClientService.GetClients();
            foreach (var client in clients)
            {
                comboBox1.Items.Add($"ID: {client.Id}, Nome: {client.Name}, TIN: {client.TIN}");
            }

            comboBox1.SelectedIndex = -1; // No item selected by default
        }

        /// <summary>
        /// Handles the load event for the form, populating the ComboBox with client data.
        /// </summary>
        private void ClientManagementForm_Load(object sender, EventArgs e)
        {
            LoadClientsIntoComboBox();
        }

        /// <summary>
        /// Loads clients from the ClientService into the ComboBox.
        /// </summary>
        private void LoadClientsIntoComboBox()
        {
            comboBox1.Items.Clear(); // Clears the ComboBox

            // Gets the list of clients from the ClientService
            var clients = ClientService.GetClients();

            // Populates the ComboBox with client data
            foreach (var client in clients)
            {
                comboBox1.Items.Add($"ID: {client.Id}, Nome: {client.Name}, TIN: {client.TIN}");
            }

            comboBox1.SelectedIndex = -1; // No client selected by default
        }

        /// <summary>
        /// Handles the selected index changed event for the ComboBox.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event placeholder for future logic if needed
        }
    }
}
