namespace Tourist_Accommodation_System.Forms
{
    partial class AccommodationManagementForm
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
            comboBox_accommodation = new ComboBox();
            button_remove = new Button();
            button_edit = new Button();
            SuspendLayout();
            // 
            // comboBox_accommodation
            // 
            comboBox_accommodation.FormattingEnabled = true;
            comboBox_accommodation.Location = new Point(94, 76);
            comboBox_accommodation.Name = "comboBox_accommodation";
            comboBox_accommodation.Size = new Size(642, 28);
            comboBox_accommodation.TabIndex = 0;
            comboBox_accommodation.SelectedIndexChanged += comboBox_accommodation_SelectedIndexChanged;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(458, 247);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(94, 29);
            button_remove.TabIndex = 1;
            button_remove.Text = "REMOVE";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(209, 248);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 2;
            button_edit.Text = "EDIT";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // AccommodationManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_edit);
            Controls.Add(button_remove);
            Controls.Add(comboBox_accommodation);
            Name = "AccommodationManagementForm";
            Text = "AccommodationManagementForm";
            Load += AccommodationManagementForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_accommodation;
        private Button button_remove;
        private Button button_edit;
    }
}