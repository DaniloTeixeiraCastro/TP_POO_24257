using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourist_Accommodation_System.Models;
using Tourist_Accommodation_System.Services;

namespace Tourist_Accommodation_System.Forms
{
    public partial class FormAddEditReview : Form
    {
        private Review _currentReview; // Referência à review sendo editada (se aplicável)
        private bool _isEditMode; // Flag para indicar se o formulário está no modo de edição

        /// <summary>
        /// Construtor para o formulário de adicionar/editar avaliações.
        /// </summary>
        /// <param name="review">A avaliação a ser editada. Se null, será no modo de adição.</param>
        public FormAddEditReview(Review? review=null)
        {
            InitializeComponent();
            // Define o modo (edição ou adição)
            _isEditMode = review != null;

            if (_isEditMode)
            {
                _currentReview = review!;
                PopulateFields(); // Preenche os campos com os dados da avaliação
            }
            else
            {
                _currentReview = new Review(); // Cria uma nova avaliação para adição
            }
            LoadClients();
            LoadRatings();
        }

        /// <summary>
        /// Carrega os clientes na ComboBox.
        /// </summary>
        private void LoadClients()
        {
            var clients = ClientService.GetClients();
            comboBox_client.DataSource = clients;
            comboBox_client.DisplayMember = "Name";
            comboBox_client.ValueMember = "Id";
            comboBox_client.SelectedIndex = -1; // Nenhum cliente selecionado por padrão
        }

        /// <summary>
        /// Carrega as opções de classificação (1 a 5 estrelas) na ComboBox.
        /// </summary>
        private void LoadRatings()
        {
            comboBox_rating.DataSource = Enum.GetValues(typeof(ReviewRating)).Cast<ReviewRating>().ToList();
        }

        /// <summary>
        /// Preenche os campos do formulário no modo de edição.
        /// </summary>
        private void PopulateFields()
        {
            if (_currentReview == null) return;

            // Se o cliente não for anônimo, seleciona o cliente na ComboBox
            if (!_currentReview.IsAnonymous && _currentReview.Client != null)
            {
                comboBox_client.SelectedValue = _currentReview.Client.Id;
                checkBox_anonymous.Checked = false;
                comboBox_client.Enabled = true; // Habilita a seleção de cliente
            }
            else
            {
                // Caso seja anônimo, marca o checkbox e desativa a ComboBox
                checkBox_anonymous.Checked = true;
                comboBox_client.SelectedIndex = -1; // Nenhum cliente selecionado
                comboBox_client.Enabled = false; // Desabilita a ComboBox
            }

            // Preenche o campo de comentário
            textBox_comment.Text = _currentReview.Comment;

            // Seleciona o rating correspondente
            comboBox_rating.SelectedItem = _currentReview.Rating;
        }

        /// <summary>
        /// Botão para salvar a nova avaliação.
        /// </summary>

        private void label_client_Click(object sender, EventArgs e)
        {

        }

        private void label_comment_Click(object sender, EventArgs e)
        {

        }

        private void label_rating_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_comment_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_rating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento para desativar o ComboBox de cliente quando "Anônimo" está marcado.
        /// </summary>
        private void checkBox_anonymous_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_client.Enabled = !checkBox_anonymous.Checked;
            if (checkBox_anonymous.Checked)
            {
                comboBox_client.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Evento para salvar a avaliação no modo de adição ou edição.
        /// </summary>
        private void button_save_Click(object sender, EventArgs e)
        {
            // Verificar se o comentário foi preenchido
            if (string.IsNullOrWhiteSpace(textBox_comment.Text))
            {
                MessageBox.Show("Por favor, insira um comentário.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se uma classificação foi selecionada
            if (comboBox_rating.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma classificação (rating).", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter os valores do formulário
            var selectedClient = checkBox_anonymous.Checked ? null : (Client?)comboBox_client.SelectedItem;
            var comment = textBox_comment.Text;
            var rating = (ReviewRating)comboBox_rating.SelectedItem;
            var isAnonymous = checkBox_anonymous.Checked;

            if (_isEditMode)
            {
                // Atualizar os valores da avaliação existente
                _currentReview.Comment = comment;
                _currentReview.Rating = rating;
                _currentReview.IsAnonymous = isAnonymous;
                _currentReview.Client = selectedClient;

                MessageBox.Show("Review editada com sucesso!", "Editar Review", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Criar uma nova avaliação
                var newReview = new Review
                {
                    Comment = comment,
                    Rating = rating,
                    IsAnonymous = isAnonymous,
                    Client = selectedClient
                };

                // Adicionar a avaliação através do ReviewService
                string result = ReviewService.AddReview(newReview);
                MessageBox.Show(result, "Adicionar Review", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormAddEditReview_Load(object sender, EventArgs e)
        {

        }
    }
}
