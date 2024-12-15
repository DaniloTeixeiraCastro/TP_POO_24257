namespace Tourist_Accommodation_System.Forms
{
    partial class PaymentList
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
            dataGridView1 = new DataGridView();
            button_edit = new Button();
            button_remove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 404);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(114, 413);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 1;
            button_edit.Text = "EDIT";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(510, 413);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(94, 29);
            button_remove.TabIndex = 2;
            button_remove.Text = "REMOVE";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // PaymentList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_remove);
            Controls.Add(button_edit);
            Controls.Add(dataGridView1);
            Name = "PaymentList";
            Text = "PaymentList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_edit;
        private Button button_remove;
    }
}