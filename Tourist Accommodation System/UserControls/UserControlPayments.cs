using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourist_Accommodation_System.Forms;

namespace Tourist_Accommodation_System.UserControls
{
    public partial class UserControlPayments : UserControl
    {
        public UserControlPayments()
        {
            InitializeComponent();
        }
        private void label_menu_Click(object sender, EventArgs e)
        {

        }

        private void UserControlPayments_Load(object sender, EventArgs e)
        {

        }

        private void button_addpayment_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário AddEditPayment
            var addEditPaymentForm = new AddEditPayment();

            // Mostra o formulário como uma janela modal
            addEditPaymentForm.ShowDialog();

        }

        private void button_editpayment_Click(object sender, EventArgs e)
        {

        }

        private void button_listpayment_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            var mainForm = (MainWindow)this.ParentForm;
            mainForm.Hide();

            MainWindow newMainForm = new MainWindow();
            newMainForm.Show();

        }

    }
}
