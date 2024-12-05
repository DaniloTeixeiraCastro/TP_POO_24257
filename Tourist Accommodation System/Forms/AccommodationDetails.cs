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
    public partial class AccommodationDetails : Form
    {
        public AccommodationDetails()
        {
            InitializeComponent();
        }
        #region
        private void label_type_Click(object sender, EventArgs e)
        {

        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }

        private void label_view_Click(object sender, EventArgs e)
        {

        }

        private void label_price_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_price_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_details_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            {
                // Limpa todas as seleções das ComboBox
                comboBox_type.SelectedIndex = -1;
                comboBox_status.SelectedIndex = -1;
                comboBox_view.SelectedIndex = -1;
                comboBox_price.SelectedIndex = -1;

                // Limpa a ListBox
                listBox_details.Items.Clear();
            }

        }
        private void button_apply_Click(object sender, EventArgs e)
        {

        }

        private void AccommodationDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
