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
    public partial class ClientManagementForm : Form
    {

        public ClientManagementForm()
        {
            InitializeComponent();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            // Obtem o ID do cliente selecionado na ComboBox
            var selectedClientText = comboBox1.SelectedItem.ToString();
            var clientId = int.Parse(selectedClientText.Split(':')[1].Split(',')[0].Trim());

            // Obtenha o cliente pelo ID
            var client = ClientService.GetClients().FirstOrDefault(c => c.Id == clientId);
            if (client == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            // Abra o FormAddEditClient para editar o cliente
            FormAddEditClient editClientForm = new FormAddEditClient(client);
            editClientForm.ShowDialog();

            // Atualize a ComboBox após as alterações
            UpdateClientComboBox();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            {
                // Verifica se um cliente foi selecionado
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione um cliente para remover.");
                    return;
                }

                // Obtém o ID do cliente a partir da seleção
                string selectedClient = comboBox1.SelectedItem.ToString();
                int clientId = int.Parse(selectedClient.Split(':')[1].Split(',')[0].Trim());

                // Remove o cliente através do ClientService
                string result = ClientService.RemoveClient(clientId);

                // Exibe a mensagem de confirmação ou erro
                MessageBox.Show(result);

                // Atualiza a ComboBox após a remoção
                LoadClientsIntoComboBox();
            }
        }

        private void button_list_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateClientComboBox()
        {
            comboBox1.Items.Clear(); // Limpa a ComboBox

            var clients = ClientService.GetClients();
            foreach (var client in clients)
            {
                comboBox1.Items.Add($"ID: {client.Id}, Nome: {client.Name}, TIN: {client.TIN}");
            }

            comboBox1.SelectedIndex = -1; // Nenhum item selecionado por padrão
        }

        private void ClientManagementForm_Load(object sender, EventArgs e)
        {
            LoadClientsIntoComboBox();
        }

        private void LoadClientsIntoComboBox()
        {
            comboBox1.Items.Clear(); // Limpa a ComboBox

            // Obtém a lista de clientes do ClientService
            var clients = ClientService.GetClients();

            // Preenche a ComboBox com os dados dos clientes
            foreach (var client in clients)
            {
                comboBox1.Items.Add($"ID: {client.Id}, Nome: {client.Name}, TIN: {client.TIN}");
            }

            comboBox1.SelectedIndex = -1; // Nenhum cliente selecionado por padrão
        }

    }
}
