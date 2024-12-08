namespace Tourist_Accommodation_System.Forms
{
    partial class FormAddEditReview
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
            label_client = new Label();
            comboBox_client = new ComboBox();
            label_comment = new Label();
            textBox_comment = new TextBox();
            label_rating = new Label();
            comboBox_rating = new ComboBox();
            checkBox_anonymous = new CheckBox();
            button_save = new Button();
            SuspendLayout();
            // 
            // label_client
            // 
            label_client.AutoSize = true;
            label_client.Location = new Point(111, 79);
            label_client.Name = "label_client";
            label_client.Size = new Size(141, 20);
            label_client.TabIndex = 0;
            label_client.Text = "CLIENT (OPCIONAL)";
            label_client.Click += label_client_Click;
            // 
            // comboBox_client
            // 
            comboBox_client.FormattingEnabled = true;
            comboBox_client.Location = new Point(440, 76);
            comboBox_client.Name = "comboBox_client";
            comboBox_client.Size = new Size(252, 28);
            comboBox_client.TabIndex = 1;
            comboBox_client.SelectedIndexChanged += comboBox_client_SelectedIndexChanged;
            // 
            // label_comment
            // 
            label_comment.AutoSize = true;
            label_comment.Location = new Point(111, 134);
            label_comment.Name = "label_comment";
            label_comment.Size = new Size(82, 20);
            label_comment.TabIndex = 2;
            label_comment.Text = "COMMENT";
            label_comment.Click += label_comment_Click;
            // 
            // textBox_comment
            // 
            textBox_comment.Location = new Point(440, 131);
            textBox_comment.Name = "textBox_comment";
            textBox_comment.Size = new Size(252, 27);
            textBox_comment.TabIndex = 3;
            textBox_comment.TextChanged += textBox_comment_TextChanged;
            // 
            // label_rating
            // 
            label_rating.AutoSize = true;
            label_rating.Location = new Point(111, 197);
            label_rating.Name = "label_rating";
            label_rating.Size = new Size(116, 20);
            label_rating.TabIndex = 4;
            label_rating.Text = "RATING (1 TO 5)";
            label_rating.Click += label_rating_Click;
            // 
            // comboBox_rating
            // 
            comboBox_rating.FormattingEnabled = true;
            comboBox_rating.Location = new Point(440, 198);
            comboBox_rating.Name = "comboBox_rating";
            comboBox_rating.Size = new Size(252, 28);
            comboBox_rating.TabIndex = 5;
            comboBox_rating.SelectedIndexChanged += comboBox_rating_SelectedIndexChanged;
            // 
            // checkBox_anonymous
            // 
            checkBox_anonymous.AutoSize = true;
            checkBox_anonymous.Location = new Point(300, 274);
            checkBox_anonymous.Name = "checkBox_anonymous";
            checkBox_anonymous.Size = new Size(124, 24);
            checkBox_anonymous.TabIndex = 6;
            checkBox_anonymous.Text = "ANONYMOUS";
            checkBox_anonymous.UseVisualStyleBackColor = true;
            checkBox_anonymous.CheckedChanged += checkBox_anonymous_CheckedChanged;
            // 
            // button_save
            // 
            button_save.Location = new Point(314, 348);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 7;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // FormAddEditReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_save);
            Controls.Add(checkBox_anonymous);
            Controls.Add(comboBox_rating);
            Controls.Add(label_rating);
            Controls.Add(textBox_comment);
            Controls.Add(label_comment);
            Controls.Add(comboBox_client);
            Controls.Add(label_client);
            Name = "FormAddEditReview";
            Text = "FormAddEditReview";
            Load += FormAddEditReview_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_client;
        private ComboBox comboBox_client;
        private Label label_comment;
        private TextBox textBox_comment;
        private Label label_rating;
        private ComboBox comboBox_rating;
        private CheckBox checkBox_anonymous;
        private Button button_save;
    }
}