using Tourist_Accommodation_System.Forms;

namespace Tourist_Accommodation_System
{
    public partial class UserControlAccommodation : UserControl
    {
        private MainWindow mainForm;
        public UserControlAccommodation()
        {
            InitializeComponent();
        }
        public void LoadUserControlClient()
        {
            UserControlClient usercontrol = new UserControlClient();
            usercontrol.Dock = DockStyle.Fill;
            mainForm.Controls.Clear();
            mainForm.MainPanel.Controls.Add(usercontrol); // Adiciona o novo controle ao painel

        }

        private void button_editaccommodation_Click(object sender, EventArgs e)
        {
            // Abre o formulário de gerenciamento de acomodações
            AccommodationManagementForm managementForm = new AccommodationManagementForm();
            managementForm.ShowDialog();
        }

        private void button_removeaccommodation_Click(object sender, EventArgs e)
        {
            // Abre o formulário de gerenciamento de acomodações
            AccommodationManagementForm managementForm = new AccommodationManagementForm();
            managementForm.ShowDialog();
        }

        private void button_addaccommodation_Click(object sender, EventArgs e)
        {
            // Abre o formulário FormAddEditAccommodation
            FormAddEditAccommodation formAddEdit = new FormAddEditAccommodation();
            formAddEdit.ShowDialog();

        }

        private void button_listaccommodation_Click(object sender, EventArgs e)
        {
            AcommodationList accommodationListForm = new AcommodationList();
            accommodationListForm.ShowDialog();
        }

        private void UserControlAccommodation_Load(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            var mainForm = (MainWindow)this.ParentForm;
            mainForm.Hide(); // Ou mainForm.Close() 

            // Cria e abre uma nova instância da MainWindow
            MainWindow newMainForm = new MainWindow();
            newMainForm.Show();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário AccommodationDetails
            AccommodationDetails detailsForm = new AccommodationDetails();

            // Exibe o formulário como diálogo
            detailsForm.ShowDialog();
        }
    }
}
