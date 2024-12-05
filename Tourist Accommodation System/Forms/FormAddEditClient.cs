using Tourist_Accommodation_System.Models;
using Tourist_Accommodation_System.Services;

namespace Tourist_Accommodation_System.Forms
{
    public partial class FormAddEditClient : Form
    {
        private Client? clientToEdit; // Cliente que será editado, se houver

        public FormAddEditClient(Client? client = null)
        {
            InitializeComponent();

            // Se um cliente foi passado, inicializa os campos com os dados dele
            if (client != null)
            {
                clientToEdit = client;
                textBox_name.Text = client.Name;
                textBox_email.Text = client.Email;
                textBox_number.Text = client.Phone;
                textBox_tin.Text = client.TIN;
                dateTimePicker.Value = client.BirthDate;
            }
        }

        #region

        private void label_email_Click(object sender, EventArgs e)
        {

        }
        private void label_BirthDate_Click(object sender, EventArgs e)
        {

        }

        private void label_tin_Click(object sender, EventArgs e)
        {

        }
        private void label_number_Click(object sender, EventArgs e)
        {

        }
        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Today.AddYears(-18);
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            // Recolher os dados do formulário
            string name = textBox_name.Text;
            string email = textBox_email.Text;
            string phone = textBox_number.Text;
            string tin = textBox_tin.Text;
            DateTime birthDate = dateTimePicker.Value;

            // Validação básica 
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(tin))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }

            if (clientToEdit != null)
            {
                // Atualizar os dados do cliente existente
                clientToEdit.Name = name;
                clientToEdit.Email = email;
                clientToEdit.Phone = phone;
                clientToEdit.TIN = tin;
                clientToEdit.BirthDate = birthDate;

                // Atualiza o cliente no ClientService
                ClientService.UpdateClient(clientToEdit);

                MessageBox.Show("Cliente atualizado com sucesso!");
            }
            else
            {
                // Criar um novo cliente
                Client newClient = new Client
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    TIN = tin,
                    BirthDate = birthDate
                };

                // Tentar adicionar o cliente através do ClientService
                string resultMessage = ClientService.AddClient(newClient);

                // Exibir o resultado para o utilizador
                MessageBox.Show(resultMessage);

                // Se o cliente foi adicionado com sucesso, fechar o formulário
                if (resultMessage == "Cliente adicionado com sucesso!")
                {
                    this.Close();
                }
            }

            // Fechar o formulário após salvar
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {

        }

        private void FormAddEditClient_Load(object sender, EventArgs e)
        {

        }
    }
}
