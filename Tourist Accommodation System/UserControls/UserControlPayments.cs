using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_Accommodation_System.UserControls
{
    public partial class UserControlPayments : UserControl
    {
        public UserControlPayments()
        {
            InitializeComponent();
        }

        private void UserControlPayments_Load(object sender, EventArgs e)
        {

        }

        private void button_addpayment_Click(object sender, EventArgs e)
        {

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
