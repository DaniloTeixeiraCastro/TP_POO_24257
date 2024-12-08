namespace Tourist_Accommodation_System.Forms
{
    partial class ReservationManagementForm
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
            button_remove = new Button();
            button_edit = new Button();
            dataGridView_reservation = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservation).BeginInit();
            SuspendLayout();
            // 
            // button_remove
            // 
            button_remove.Location = new Point(528, 378);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(186, 29);
            button_remove.TabIndex = 5;
            button_remove.Text = "REMOVE";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(104, 378);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(185, 29);
            button_edit.TabIndex = 4;
            button_edit.Text = "EDIT";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // dataGridView_reservation
            // 
            dataGridView_reservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reservation.Location = new Point(40, 44);
            dataGridView_reservation.Name = "dataGridView_reservation";
            dataGridView_reservation.RowHeadersWidth = 51;
            dataGridView_reservation.Size = new Size(721, 264);
            dataGridView_reservation.TabIndex = 3;
            dataGridView_reservation.CellContentClick += dataGridView_reservation_CellContentClick;
            // 
            // ReservationManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_remove);
            Controls.Add(button_edit);
            Controls.Add(dataGridView_reservation);
            Name = "ReservationManagementForm";
            Text = "ReservationManagementForm";
            Load += ReservationManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_remove;
        private Button button_edit;
        private DataGridView dataGridView_reservation;
    }
}