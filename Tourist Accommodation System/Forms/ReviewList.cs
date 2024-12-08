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
    public partial class ReviewList : Form
    {
        public ReviewList()
        {
            InitializeComponent();
            LoadReviewsToGrid();
        }

        private void ReviewList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_reviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Carrega as avaliações no DataGridView.
        /// </summary>
        private void LoadReviewsToGrid()
        {
            // Obter todas as avaliações
            var reviews = ReviewService.GetReviews();

            // Configurar o DataGridView
            dataGridView_reviews.Columns.Clear();
            dataGridView_reviews.Rows.Clear();

            // Adicionar colunas
            dataGridView_reviews.Columns.Add("ReviewId", "ID");
            dataGridView_reviews.Columns.Add("ClientName", "Cliente");
            dataGridView_reviews.Columns.Add("Comment", "Comentário");
            dataGridView_reviews.Columns.Add("Rating", "Classificação");
            dataGridView_reviews.Columns.Add("IsAnonymous", "Anônimo");

            // Preencher o DataGridView
            foreach (var review in reviews)
            {
                dataGridView_reviews.Rows.Add(
                    review.ReviewId,
                    review.IsAnonymous ? "Anônimo" : review.Client?.Name ?? "Não informado",
                    review.Comment,
                    review.Rating,
                    review.IsAnonymous ? "Sim" : "Não"
                );
            }

            // Configurações adicionais
            dataGridView_reviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            // Verifica se uma linha está selecionada no DataGridView
            if (dataGridView_reviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma avaliação para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID da avaliação selecionada
            var selectedRow = dataGridView_reviews.SelectedRows[0];
            if (selectedRow.Cells["ReviewId"].Value == null)
            {
                MessageBox.Show("Erro ao obter o ID da avaliação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reviewId = Convert.ToInt32(selectedRow.Cells["ReviewId"].Value);

            // Confirmação antes de remover
            var confirmResult = MessageBox.Show($"Tem certeza de que deseja remover a avaliação com ID {reviewId}?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Remove a avaliação usando o ReviewService
                string result = ReviewService.RemoveReview(reviewId);
                MessageBox.Show(result, "Remover Avaliação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza o DataGridView
                LoadReviewsToGrid();
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Verifica se uma linha está selecionada no DataGridView
            if (dataGridView_reviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma avaliação para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID da avaliação selecionada
            var selectedRow = dataGridView_reviews.SelectedRows[0];
            if (selectedRow.Cells["ReviewId"].Value == null)
            {
                MessageBox.Show("Erro ao obter o ID da avaliação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reviewId = Convert.ToInt32(selectedRow.Cells["ReviewId"].Value);

            // Busca a avaliação do ReviewService
            var reviewToEdit = ReviewService.GetReviews().FirstOrDefault(r => r.ReviewId == reviewId);
            if (reviewToEdit == null)
            {
                MessageBox.Show("Avaliação não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abre o FormAddEditReview no modo de edição
            using (var formAddEditReview = new FormAddEditReview(reviewToEdit))
            {
                if (formAddEditReview.ShowDialog() == DialogResult.OK)
                {
                    // Atualiza o DataGridView após salvar as alterações
                    LoadReviewsToGrid();
                }
            }
        }
    }
}
