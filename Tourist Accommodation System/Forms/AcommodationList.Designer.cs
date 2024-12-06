namespace Tourist_Accommodation_System.Forms
{
    partial class AcommodationList
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
            dataGridView_Accommodations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Accommodations).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Accommodations
            // 
            dataGridView_Accommodations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Accommodations.Dock = DockStyle.Fill;
            dataGridView_Accommodations.Location = new Point(0, 0);
            dataGridView_Accommodations.Name = "dataGridView_Accommodations";
            dataGridView_Accommodations.RowHeadersWidth = 51;
            dataGridView_Accommodations.Size = new Size(800, 450);
            dataGridView_Accommodations.TabIndex = 0;
            dataGridView_Accommodations.CellContentClick += dataGridView_Accommodations_CellContentClick;
            // 
            // AcommodationList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_Accommodations);
            Name = "AcommodationList";
            Text = "AcommodationList";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Accommodations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Accommodations;
    }
}