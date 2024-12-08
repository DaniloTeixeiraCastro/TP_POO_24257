namespace Tourist_Accommodation_System.Forms
{
    partial class ReviewList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_reviews = new DataGridView();
            button_remove = new Button();
            button_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reviews).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_reviews
            // 
            dataGridView_reviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reviews.Location = new Point(0, 0);
            dataGridView_reviews.Name = "dataGridView_reviews";
            dataGridView_reviews.RowHeadersWidth = 51;
            dataGridView_reviews.Size = new Size(799, 327);
            dataGridView_reviews.TabIndex = 0;
            dataGridView_reviews.CellContentClick += dataGridView_reviews_CellContentClick;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(477, 372);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(139, 41);
            button_remove.TabIndex = 1;
            button_remove.Text = "REMOVE";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(157, 372);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(118, 41);
            button_edit.TabIndex = 2;
            button_edit.Text = "EDIT";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // ReviewList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_edit);
            Controls.Add(button_remove);
            Controls.Add(dataGridView_reviews);
            Name = "ReviewList";
            Text = "ReviewList";
            Load += ReviewList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_reviews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_reviews;
        private Button button_remove;
        private Button button_edit;
    }
}