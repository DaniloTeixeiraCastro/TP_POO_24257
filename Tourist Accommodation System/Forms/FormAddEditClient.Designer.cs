namespace Tourist_Accommodation_System.Forms
{
    partial class FormAddEditClient
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
            textBox_name = new TextBox();
            textBox_email = new TextBox();
            textBox_number = new TextBox();
            label_name = new Label();
            label_email = new Label();
            label_number = new Label();
            dateTimePicker = new DateTimePicker();
            label_BirthDate = new Label();
            label_tin = new Label();
            textBox_tin = new TextBox();
            button_save = new Button();
            button_cancel = new Button();
            SuspendLayout();
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(351, 43);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(275, 27);
            textBox_name.TabIndex = 0;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(351, 123);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(275, 27);
            textBox_email.TabIndex = 1;
            textBox_email.TextChanged += textBox_email_TextChanged;
            // 
            // textBox_number
            // 
            textBox_number.Location = new Point(351, 199);
            textBox_number.Name = "textBox_number";
            textBox_number.Size = new Size(275, 27);
            textBox_number.TabIndex = 2;
            textBox_number.TextChanged += textBox_number_TextChanged;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 12F);
            label_name.Location = new Point(143, 42);
            label_name.Name = "label_name";
            label_name.Size = new Size(68, 28);
            label_name.TabIndex = 3;
            label_name.Text = "NAME";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Segoe UI", 12F);
            label_email.Location = new Point(143, 123);
            label_email.Name = "label_email";
            label_email.Size = new Size(75, 28);
            label_email.TabIndex = 4;
            label_email.Text = "E-MAIL";
            label_email.Click += label_email_Click;
            // 
            // label_number
            // 
            label_number.AutoSize = true;
            label_number.Font = new Font("Segoe UI", 12F);
            label_number.Location = new Point(127, 199);
            label_number.Name = "label_number";
            label_number.Size = new Size(162, 28);
            label_number.TabIndex = 5;
            label_number.Text = "PHONE NUMBER";
            label_number.Click += label_number_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(351, 266);
            dateTimePicker.MinDate = new DateTime(1924, 1, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(275, 27);
            dateTimePicker.TabIndex = 6;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label_BirthDate
            // 
            label_BirthDate.AutoSize = true;
            label_BirthDate.Font = new Font("Segoe UI", 12F);
            label_BirthDate.Location = new Point(136, 264);
            label_BirthDate.Name = "label_BirthDate";
            label_BirthDate.Size = new Size(114, 28);
            label_BirthDate.TabIndex = 7;
            label_BirthDate.Text = "BIRTH DATE";
            label_BirthDate.Click += label_BirthDate_Click;
            // 
            // label_tin
            // 
            label_tin.AutoSize = true;
            label_tin.Font = new Font("Segoe UI", 12F);
            label_tin.Location = new Point(160, 324);
            label_tin.Name = "label_tin";
            label_tin.Size = new Size(42, 28);
            label_tin.TabIndex = 8;
            label_tin.Text = "TIN";
            label_tin.Click += label_tin_Click;
            // 
            // textBox_tin
            // 
            textBox_tin.Location = new Point(351, 325);
            textBox_tin.Name = "textBox_tin";
            textBox_tin.Size = new Size(275, 27);
            textBox_tin.TabIndex = 9;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Lime;
            button_save.Location = new Point(454, 394);
            button_save.Name = "button_save";
            button_save.Size = new Size(172, 37);
            button_save.TabIndex = 10;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.Red;
            button_cancel.Location = new Point(161, 394);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(198, 37);
            button_cancel.TabIndex = 11;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // FormAddEditClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textBox_tin);
            Controls.Add(label_tin);
            Controls.Add(label_BirthDate);
            Controls.Add(dateTimePicker);
            Controls.Add(label_number);
            Controls.Add(label_email);
            Controls.Add(label_name);
            Controls.Add(textBox_number);
            Controls.Add(textBox_email);
            Controls.Add(textBox_name);
            Name = "FormAddEditClient";
            Text = "FormAddEditClient";
            Load += FormAddEditClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_name;
        private TextBox textBox_email;
        private TextBox textBox_number;
        private Label label_name;
        private Label label_email;
        private Label label_number;
        private DateTimePicker dateTimePicker;
        private Label label_BirthDate;
        private Label label_tin;
        private TextBox textBox_tin;
        private Button button_save;
        private Button button_cancel;
    }
}