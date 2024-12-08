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

        private void button_listclient_Click(object sender, EventArgs e)
        {
            ClientList clientListForm = new ClientList();
            clientListForm.ShowDialog();
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
    }


}
