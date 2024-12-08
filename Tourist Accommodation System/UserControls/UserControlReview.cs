using Tourist_Accommodation_System.Forms;

namespace Tourist_Accommodation_System
{
    public partial class UserControlReview : UserControl
    {
        public UserControlReview()
        {
            InitializeComponent();
        }

        private void button_addreview_Click(object sender, EventArgs e)
        {
            FormAddEditReview addReviewForm = new FormAddEditReview();
            addReviewForm.ShowDialog();
        }

        private void button_editreview_Click(object sender, EventArgs e)
        {
            ReviewList addReviewForm = new ReviewList();
            addReviewForm.ShowDialog();

        }

        private void button_removereview_Click(object sender, EventArgs e)
        {
            ReviewList addReviewForm = new ReviewList();
            addReviewForm.ShowDialog();

        }

        private void button_listreview_Click(object sender, EventArgs e)
        {
            ReviewList addReviewForm = new ReviewList();
            addReviewForm.ShowDialog();

        }

        private void UserControlReview_Load(object sender, EventArgs e)
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
