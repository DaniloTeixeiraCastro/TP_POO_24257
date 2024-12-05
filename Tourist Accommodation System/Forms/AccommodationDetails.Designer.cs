namespace Tourist_Accommodation_System.Forms
{
    partial class AccommodationDetails
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
            comboBox_type = new ComboBox();
            comboBox_status = new ComboBox();
            comboBox_view = new ComboBox();
            comboBox_price = new ComboBox();
            label_type = new Label();
            label_status = new Label();
            label_view = new Label();
            label_price = new Label();
            listBox_details = new ListBox();
            button_apply = new Button();
            button_clean = new Button();
            SuspendLayout();
            // 
            // comboBox_type
            // 
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Location = new Point(31, 65);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(151, 28);
            comboBox_type.TabIndex = 0;
            comboBox_type.SelectedIndexChanged += comboBox_type_SelectedIndexChanged;
            // 
            // comboBox_status
            // 
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Location = new Point(204, 65);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(151, 28);
            comboBox_status.TabIndex = 1;
            comboBox_status.SelectedIndexChanged += comboBox_status_SelectedIndexChanged;
            // 
            // comboBox_view
            // 
            comboBox_view.FormattingEnabled = true;
            comboBox_view.Location = new Point(389, 65);
            comboBox_view.Name = "comboBox_view";
            comboBox_view.Size = new Size(151, 28);
            comboBox_view.TabIndex = 2;
            comboBox_view.SelectedIndexChanged += comboBox_view_SelectedIndexChanged;
            // 
            // comboBox_price
            // 
            comboBox_price.FormattingEnabled = true;
            comboBox_price.Location = new Point(569, 65);
            comboBox_price.Name = "comboBox_price";
            comboBox_price.Size = new Size(151, 28);
            comboBox_price.TabIndex = 3;
            comboBox_price.SelectedIndexChanged += comboBox_price_SelectedIndexChanged;
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Location = new Point(62, 22);
            label_type.Name = "label_type";
            label_type.Size = new Size(41, 20);
            label_type.TabIndex = 4;
            label_type.Text = "TYPE";
            label_type.Click += label_type_Click;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(234, 19);
            label_status.Name = "label_status";
            label_status.Size = new Size(59, 20);
            label_status.TabIndex = 5;
            label_status.Text = "STATUS";
            label_status.Click += label_status_Click;
            // 
            // label_view
            // 
            label_view.AutoSize = true;
            label_view.Location = new Point(434, 21);
            label_view.Name = "label_view";
            label_view.Size = new Size(44, 20);
            label_view.TabIndex = 6;
            label_view.Text = "VIEW";
            label_view.Click += label_view_Click;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(625, 19);
            label_price.Name = "label_price";
            label_price.Size = new Size(47, 20);
            label_price.TabIndex = 7;
            label_price.Text = "PRICE";
            label_price.Click += label_price_Click;
            // 
            // listBox_details
            // 
            listBox_details.FormattingEnabled = true;
            listBox_details.Location = new Point(31, 153);
            listBox_details.Name = "listBox_details";
            listBox_details.Size = new Size(689, 204);
            listBox_details.TabIndex = 8;
            listBox_details.SelectedIndexChanged += listBox_details_SelectedIndexChanged;
            // 
            // button_apply
            // 
            button_apply.Location = new Point(141, 379);
            button_apply.Name = "button_apply";
            button_apply.Size = new Size(94, 29);
            button_apply.TabIndex = 9;
            button_apply.Text = "APPLY FILTERS";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // button_clean
            // 
            button_clean.Location = new Point(498, 379);
            button_clean.Name = "button_clean";
            button_clean.Size = new Size(94, 29);
            button_clean.TabIndex = 10;
            button_clean.Text = "CLEAN FILTERS";
            button_clean.UseVisualStyleBackColor = true;
            button_clean.Click += button_clean_Click;
            // 
            // AccommodationDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_clean);
            Controls.Add(button_apply);
            Controls.Add(listBox_details);
            Controls.Add(label_price);
            Controls.Add(label_view);
            Controls.Add(label_status);
            Controls.Add(label_type);
            Controls.Add(comboBox_price);
            Controls.Add(comboBox_view);
            Controls.Add(comboBox_status);
            Controls.Add(comboBox_type);
            Name = "AccommodationDetails";
            Text = "AccommodationDetails";
            Load += AccommodationDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_type;
        private ComboBox comboBox_status;
        private ComboBox comboBox_view;
        private ComboBox comboBox_price;
        private Label label_type;
        private Label label_status;
        private Label label_view;
        private Label label_price;
        private ListBox listBox_details;
        private Button button_apply;
        private Button button_clean;
    }
}