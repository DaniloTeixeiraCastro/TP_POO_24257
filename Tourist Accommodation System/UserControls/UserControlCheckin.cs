namespace Tourist_Accommodation_System
{
    public partial class UserControlCheckin : UserControl
    {
        public UserControlCheckin()
        {
            InitializeComponent();
        }

        private void button_addcheckin_Click(object sender, EventArgs e)
        {

        }

        private void button_editcheckin_Click(object sender, EventArgs e)
        {

        }

        private void button_removecheckin_Click(object sender, EventArgs e)
        {

        }

        private void button_listcheckin_Click(object sender, EventArgs e)
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
