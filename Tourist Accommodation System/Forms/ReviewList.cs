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
    /// <summary>
    /// Form to display, edit, and remove reviews.
    /// </summary>
    public partial class ReviewList : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewList"/> class.
        /// </summary>
        public ReviewList()
        {
            InitializeComponent();
            LoadReviewsToGrid();
        }

        /// <summary>
        /// Handles the load event for the ReviewList form.
        /// </summary>
        private void ReviewList_Load(object sender, EventArgs e)
        {
            // Placeholder for logic when the form loads
        }

        /// <summary>
        /// Handles cell content click events in the DataGridView.
        /// </summary>
        private void dataGridView_reviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder for future logic when a cell is clicked
        }

        /// <summary>
        /// Loads reviews from the ReviewService into the DataGridView.
        /// </summary>
        private void LoadReviewsToGrid()
        {
            // Get all reviews
            var reviews = ReviewService.GetReviews();

            // Configure the DataGridView
            dataGridView_reviews.Columns.Clear();
            dataGridView_reviews.Rows.Clear();

            // Add columns
            dataGridView_reviews.Columns.Add("ReviewId", "ID");
            dataGridView_reviews.Columns.Add("ClientName", "Client");
            dataGridView_reviews.Columns.Add("Comment", "Comment");
            dataGridView_reviews.Columns.Add("Rating", "Rating");
            dataGridView_reviews.Columns.Add("IsAnonymous", "Anonymous");

            // Populate the DataGridView
            foreach (var review in reviews)
            {
                dataGridView_reviews.Rows.Add(
                    review.ReviewId,
                    review.IsAnonymous ? "Anonymous" : review.Client?.Name ?? "Not Provided",
                    review.Comment,
                    review.Rating,
                    review.IsAnonymous ? "Yes" : "No"
                );
            }

            // Additional settings
            dataGridView_reviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Handles the click event for the remove button.
        /// </summary>
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_reviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView_reviews.SelectedRows[0];
            if (selectedRow.Cells["ReviewId"].Value == null)
            {
                MessageBox.Show("Error retrieving the review ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reviewId = Convert.ToInt32(selectedRow.Cells["ReviewId"].Value);

            var confirmResult = MessageBox.Show($"Are you sure you want to remove the review with ID {reviewId}?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string result = ReviewService.RemoveReview(reviewId);
                MessageBox.Show(result, "Remove Review", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadReviewsToGrid();
            }
        }

        /// <summary>
        /// Handles the click event for the edit button.
        /// </summary>
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_reviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView_reviews.SelectedRows[0];
            if (selectedRow.Cells["ReviewId"].Value == null)
            {
                MessageBox.Show("Error retrieving the review ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reviewId = Convert.ToInt32(selectedRow.Cells["ReviewId"].Value);

            var reviewToEdit = ReviewService.GetReviews().FirstOrDefault(r => r.ReviewId == reviewId);
            if (reviewToEdit == null)
            {
                MessageBox.Show("Review not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var formAddEditReview = new FormAddEditReview(reviewToEdit))
            {
                if (formAddEditReview.ShowDialog() == DialogResult.OK)
                {
                    LoadReviewsToGrid();
                }
            }
        }
    }
}
