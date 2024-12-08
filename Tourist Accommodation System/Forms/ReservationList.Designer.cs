namespace Tourist_Accommodation_System.Forms
{
    partial class ReservationList
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
            dataGridView_reservations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservations).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_reservations
            // 
            dataGridView_reservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reservations.Location = new Point(2, 2);
            dataGridView_reservations.Name = "dataGridView_reservations";
            dataGridView_reservations.RowHeadersWidth = 51;
            dataGridView_reservations.Size = new Size(798, 447);
            dataGridView_reservations.TabIndex = 0;
            dataGridView_reservations.CellContentClick += dataGridView_reservations_CellContentClick;
            // 
            // ReservationList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_reservations);
            Name = "ReservationList";
            Text = "ReservationList";
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_reservations;
    }
}