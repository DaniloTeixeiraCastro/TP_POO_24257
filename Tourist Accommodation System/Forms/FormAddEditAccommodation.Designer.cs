namespace Tourist_Accommodation_System.Forms
{
    partial class FormAddEditAccommodation
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
            label_name = new Label();
            label_location = new Label();
            label_roomnumber = new Label();
            label_capacity = new Label();
            label_price = new Label();
            textBox_name = new TextBox();
            textBox_location = new TextBox();
            textBox_roomnumber = new TextBox();
            textBox_capacity = new TextBox();
            textBox_price = new TextBox();
            button_save = new Button();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(113, 85);
            label_name.Name = "label_name";
            label_name.Size = new Size(51, 20);
            label_name.TabIndex = 0;
            label_name.Text = "NAME";
            label_name.Click += label_name_Click;
            // 
            // label_location
            // 
            label_location.AutoSize = true;
            label_location.Location = new Point(113, 139);
            label_location.Name = "label_location";
            label_location.Size = new Size(78, 20);
            label_location.TabIndex = 1;
            label_location.Text = "LOCATION";
            label_location.Click += label_location_Click;
            // 
            // label_roomnumber
            // 
            label_roomnumber.AutoSize = true;
            label_roomnumber.Location = new Point(113, 189);
            label_roomnumber.Name = "label_roomnumber";
            label_roomnumber.Size = new Size(117, 20);
            label_roomnumber.TabIndex = 2;
            label_roomnumber.Text = "ROOM NUMBER";
            label_roomnumber.Click += label_roomnumber_Click;
            // 
            // label_capacity
            // 
            label_capacity.AutoSize = true;
            label_capacity.Location = new Point(113, 242);
            label_capacity.Name = "label_capacity";
            label_capacity.Size = new Size(74, 20);
            label_capacity.TabIndex = 3;
            label_capacity.Text = "CAPACITY";
            label_capacity.Click += label_capacity_Click;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(117, 293);
            label_price.Name = "label_price";
            label_price.Size = new Size(124, 20);
            label_price.TabIndex = 4;
            label_price.Text = "PRICE PER NIGHT";
            label_price.Click += label_price_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(403, 85);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(241, 27);
            textBox_name.TabIndex = 5;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // textBox_location
            // 
            textBox_location.Location = new Point(403, 132);
            textBox_location.Name = "textBox_location";
            textBox_location.Size = new Size(241, 27);
            textBox_location.TabIndex = 6;
            textBox_location.TextChanged += textBox_location_TextChanged;
            // 
            // textBox_roomnumber
            // 
            textBox_roomnumber.Location = new Point(403, 186);
            textBox_roomnumber.Name = "textBox_roomnumber";
            textBox_roomnumber.Size = new Size(241, 27);
            textBox_roomnumber.TabIndex = 7;
            textBox_roomnumber.TextChanged += textBox_roomnumber_TextChanged;
            // 
            // textBox_capacity
            // 
            textBox_capacity.Location = new Point(403, 235);
            textBox_capacity.Name = "textBox_capacity";
            textBox_capacity.Size = new Size(241, 27);
            textBox_capacity.TabIndex = 8;
            textBox_capacity.TextChanged += textBox_capacity_TextChanged;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(403, 290);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(241, 27);
            textBox_price.TabIndex = 9;
            textBox_price.TextChanged += textBox_price_TextChanged;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Lime;
            button_save.Location = new Point(318, 364);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 10;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // FormAddEditAccommodation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_save);
            Controls.Add(textBox_price);
            Controls.Add(textBox_capacity);
            Controls.Add(textBox_roomnumber);
            Controls.Add(textBox_location);
            Controls.Add(textBox_name);
            Controls.Add(label_price);
            Controls.Add(label_capacity);
            Controls.Add(label_roomnumber);
            Controls.Add(label_location);
            Controls.Add(label_name);
            Name = "FormAddEditAccommodation";
            Text = "FormAddEditAccommodation";
            Load += FormAddEditAccommodation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private Label label_location;
        private Label label_roomnumber;
        private Label label_capacity;
        private Label label_price;
        private TextBox textBox_name;
        private TextBox textBox_location;
        private TextBox textBox_roomnumber;
        private TextBox textBox_capacity;
        private TextBox textBox_price;
        private Button button_save;
    }
}