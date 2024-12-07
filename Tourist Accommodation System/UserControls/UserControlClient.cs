using Tourist_Accommodation_System.Forms;
using System.Windows.Forms;
using Tourist_Accommodation_System.Services;

namespace Tourist_Accommodation_System
{
    public partial class UserControlClient : UserControl
    {
        private MainWindow mainForm;
        public UserControlClient()
        {
            InitializeComponent();
        }

        #region
        private void UpdateClientListBox()
        {
            // Limpa a ListBox
            listbox_clients.Items.Clear();

            // Preenche com os dados atualizados
            var clients = ClientService.GetClients();
            foreach (var client in clients)
            {
                listbox_clients.Items.Add($"ID: {client.Id}, Nome: {client.Name}, Email: {client.Email}");
            }
        }

        private void button_listclient_Click(object sender, EventArgs e)
        {
            listbox_clients.Items.Clear();

            var clients = ClientService.GetClients(); // Obtém a lista completa
            foreach (var client in clients)
            {
                listbox_clients.Items.Add($"ID: {client.Id}, Nome: {client.Name}, Email: {client.Email}, TIN: {client.TIN}, Phone: {client.Phone}");
            }
        }

        #endregion

        public void LoadUserControlClient()
        {
            UserControlClient usercontrol = new UserControlClient();
            usercontrol.Dock = DockStyle.Fill;
            mainForm.Controls.Clear();
            mainForm.MainPanel.Controls.Add(usercontrol); // Adiciona o novo controle ao painel

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            // Verifica se ParentForm não é nulo e se é uma instância de MainWindow
            if (this.ParentForm is MainWindow mainForm)
            {
                // Fecha o formulário atual (se necessário)
                mainForm.Hide(); // Ou mainForm.Close() para fechar permanentemente

                // Cria e abre uma nova instância da MainWindow
                MainWindow newMainForm = new MainWindow();
                newMainForm.Show();
            }
            else
            {
                MessageBox.Show("Erro: Não foi possível retornar à janela principal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_addclient_Click(object sender, EventArgs e)
        {
            FormAddEditClient addClientForm = new FormAddEditClient();
            addClientForm.ShowDialog();

        }

        private void button_editclient_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do ClientManagementForm
            ClientManagementForm clientManagementForm = new ClientManagementForm();

            // Exibe o formulário como uma janela modal
            clientManagementForm.ShowDialog();

        }

        private void button_removeclient_Click(object sender, EventArgs e)
        {
            {
                // Cria uma nova instância do ClientManagementForm
                ClientManagementForm clientManagementForm = new ClientManagementForm();

                // Exibe o formulário como uma janela modal
                clientManagementForm.ShowDialog();
            }

        }
        private void UserControlClient_Load(object sender, EventArgs e)
        {

        }

        private void button_listClient_Click(object sender, EventArgs e)
        {
            {
                // Limpa a ListBox antes de adicionar novos itens
                listbox_clients.Items.Clear();

                // Adiciona um cliente de exemplo (para testes)
                listbox_clients.Items.Add("Exemplo de Cliente");

                // Ou preenche com dados reais
                var clients = ClientService.GetClients();
                foreach (var client in clients)
                {
                    listbox_clients.Items.Add($"ID: {client.Id}, Nome: {client.Name}, Email: {client.Email}, TIN: {client.TIN}");
                }
            }
        }

        private void listbox_clients_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }


}
