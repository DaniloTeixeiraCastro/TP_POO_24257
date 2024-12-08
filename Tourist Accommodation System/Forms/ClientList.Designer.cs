namespace Tourist_Accommodation_System.Forms
{
    partial class ClientList
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
            dataGridView_clients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_clients).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_clients
            // 
            dataGridView_clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_clients.Location = new Point(1, 3);
            dataGridView_clients.Name = "dataGridView_clients";
            dataGridView_clients.RowHeadersWidth = 51;
            dataGridView_clients.Size = new Size(797, 444);
            dataGridView_clients.TabIndex = 0;
            dataGridView_clients.CellContentClick += dataGridView_clients_CellContentClick;
            // 
            // ClientList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_clients);
            Name = "ClientList";
            Text = "ClientList";
            ((System.ComponentModel.ISupportInitialize)dataGridView_clients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_clients;
    }
}