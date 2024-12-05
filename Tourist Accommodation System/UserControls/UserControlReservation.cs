namespace Tourist_Accommodation_System
{
    public partial class UserControlReservation : UserControl
    {
        private MainWindow mainForm;
        public UserControlReservation()
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

        private void button_addreservation_Click(object sender, EventArgs e)
        {

        }

        private void button_editreservation_Click(object sender, EventArgs e)
        {

        }

        private void button_removereservation_Click(object sender, EventArgs e)
        {

        }

        private void button_listreservation_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            var mainForm = (MainWindow)this.ParentForm;
            mainForm.Hide(); // Ou mainForm.Close() se quiser fechar permanentemente

            // Cria e abre uma nova instância da MainWindow
            MainWindow newMainForm = new MainWindow();
            newMainForm.Show();
        }
    }
}
