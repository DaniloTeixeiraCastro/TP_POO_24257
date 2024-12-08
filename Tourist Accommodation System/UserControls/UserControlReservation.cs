using Tourist_Accommodation_System.Forms;

namespace Tourist_Accommodation_System
{
    public partial class UserControlReservation : UserControl
    {
        private MainWindow? mainForm;
        public UserControlReservation()
        {
            InitializeComponent();

        }

        private void label_menu_Click(object sender, EventArgs e)
        {

        }

        private void button_addreservation_Click(object sender, EventArgs e)
        {
            // Abre o formulário no modo de adição (sem uma reserva existente)
            var addReservationForm = new FormAddEditReservation();
            addReservationForm.ShowDialog();

        }

        private void button_editreservation_Click(object sender, EventArgs e)
        {
            // Abre o novo formulário ReservationManagementForm
            ReservationManagementForm managementForm = new ReservationManagementForm();
            managementForm.ShowDialog(); // Abre como janela modal
        }

        private void button_removereservation_Click(object sender, EventArgs e)
        {
            // Abre o novo formulário ReservationManagementForm
            ReservationManagementForm managementForm = new ReservationManagementForm();
            managementForm.ShowDialog(); // Abre como janela modal
        }

        private void button_listreservation_Click(object sender, EventArgs e)
        {
            var ReservationList = new ReservationList();
            ReservationList.ShowDialog();

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            // Verifica se ParentForm não é nulo e se é uma instância de MainWindow
            if (this.ParentForm is MainWindow mainForm)
            {
                mainForm.Hide(); // Ou mainForm.Close() para fechar permanentemente
                                 // Cria e exibe novamente a MainWindow
                MainWindow newMainForm = new ();
                newMainForm.Show();
            }
            else
            {
                MessageBox.Show("Erro: Não foi possível retornar à janela principal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
