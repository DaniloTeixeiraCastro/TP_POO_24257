namespace Tourist_Accommodation_System.Forms
{
    partial class FormAddEditReservation
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
            label_title = new Label();
            label_client = new Label();
            label_accommodation = new Label();
            label_checkin = new Label();
            label_price = new Label();
            comboBox_client = new ComboBox();
            comboBox_accommodation = new ComboBox();
            label_checkout = new Label();
            dateTimePicker_checkIn = new DateTimePicker();
            dateTimePicker_checkOut = new DateTimePicker();
            button_save = new Button();
            label_totalPrice = new Label();
            label_status = new Label();
            comboBox_status = new ComboBox();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 18F);
            label_title.Location = new Point(216, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(344, 41);
            label_title.TabIndex = 0;
            label_title.Text = "ADD/EDIT RESERVATION";
            label_title.Click += label_title_Click;
            // 
            // label_client
            // 
            label_client.AutoSize = true;
            label_client.Location = new Point(110, 93);
            label_client.Name = "label_client";
            label_client.Size = new Size(56, 20);
            label_client.TabIndex = 1;
            label_client.Text = "CLIENT";
            label_client.Click += label_client_Click;
            // 
            // label_accommodation
            // 
            label_accommodation.AutoSize = true;
            label_accommodation.Location = new Point(110, 154);
            label_accommodation.Name = "label_accommodation";
            label_accommodation.Size = new Size(139, 20);
            label_accommodation.TabIndex = 2;
            label_accommodation.Text = "ACCOMMODATION";
            label_accommodation.Click += label_accommodation_Click;
            // 
            // label_checkin
            // 
            label_checkin.AutoSize = true;
            label_checkin.Location = new Point(110, 212);
            label_checkin.Name = "label_checkin";
            label_checkin.Size = new Size(76, 20);
            label_checkin.TabIndex = 3;
            label_checkin.Text = "CHECK-IN";
            label_checkin.Click += label_checkin_Click;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(110, 330);
            label_price.Name = "label_price";
            label_price.Size = new Size(47, 20);
            label_price.TabIndex = 4;
            label_price.Text = "PRICE";
            label_price.Click += label_price_Click;
            // 
            // comboBox_client
            // 
            comboBox_client.FormattingEnabled = true;
            comboBox_client.Location = new Point(383, 85);
            comboBox_client.Name = "comboBox_client";
            comboBox_client.Size = new Size(315, 28);
            comboBox_client.TabIndex = 5;
            comboBox_client.SelectedIndexChanged += comboBox_client_SelectedIndexChanged;
            // 
            // comboBox_accommodation
            // 
            comboBox_accommodation.FormattingEnabled = true;
            comboBox_accommodation.Location = new Point(383, 154);
            comboBox_accommodation.Name = "comboBox_accommodation";
            comboBox_accommodation.Size = new Size(315, 28);
            comboBox_accommodation.TabIndex = 6;
            comboBox_accommodation.SelectedIndexChanged += comboBox_accommodation_SelectedIndexChanged;
            // 
            // label_checkout
            // 
            label_checkout.AutoSize = true;
            label_checkout.Location = new Point(110, 271);
            label_checkout.Name = "label_checkout";
            label_checkout.Size = new Size(90, 20);
            label_checkout.TabIndex = 7;
            label_checkout.Text = "CHECK-OUT";
            label_checkout.Click += label_checkout_Click;
            // 
            // dateTimePicker_checkIn
            // 
            dateTimePicker_checkIn.Location = new Point(383, 212);
            dateTimePicker_checkIn.Name = "dateTimePicker_checkIn";
            dateTimePicker_checkIn.Size = new Size(315, 27);
            dateTimePicker_checkIn.TabIndex = 8;
            dateTimePicker_checkIn.ValueChanged += dateTimePicker_checkIn_ValueChanged;
            // 
            // dateTimePicker_checkOut
            // 
            dateTimePicker_checkOut.Location = new Point(383, 271);
            dateTimePicker_checkOut.Name = "dateTimePicker_checkOut";
            dateTimePicker_checkOut.Size = new Size(315, 27);
            dateTimePicker_checkOut.TabIndex = 9;
            dateTimePicker_checkOut.ValueChanged += dateTimePicker_checkOut_ValueChanged;
            // 
            // button_save
            // 
            button_save.Location = new Point(326, 409);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 10;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label_totalPrice
            // 
            label_totalPrice.AutoSize = true;
            label_totalPrice.Location = new Point(506, 330);
            label_totalPrice.Name = "label_totalPrice";
            label_totalPrice.Size = new Size(17, 20);
            label_totalPrice.TabIndex = 11;
            label_totalPrice.Text = "€";
            label_totalPrice.Click += label_totalPrice_Click;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(114, 374);
            label_status.Name = "label_status";
            label_status.Size = new Size(59, 20);
            label_status.TabIndex = 12;
            label_status.Text = "STATUS";
            label_status.Click += label_status_Click;
            // 
            // comboBox_status
            // 
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Location = new Point(383, 371);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(315, 28);
            comboBox_status.TabIndex = 13;
            comboBox_status.SelectedIndexChanged += comboBox_status_SelectedIndexChanged;
            // 
            // FormAddEditReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_status);
            Controls.Add(label_status);
            Controls.Add(label_totalPrice);
            Controls.Add(button_save);
            Controls.Add(dateTimePicker_checkOut);
            Controls.Add(dateTimePicker_checkIn);
            Controls.Add(label_checkout);
            Controls.Add(comboBox_accommodation);
            Controls.Add(comboBox_client);
            Controls.Add(label_price);
            Controls.Add(label_checkin);
            Controls.Add(label_accommodation);
            Controls.Add(label_client);
            Controls.Add(label_title);
            Name = "FormAddEditReservation";
            Text = "FormAddEditReservation";
            Load += FormAddEditReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_client;
        private Label label_accommodation;
        private Label label_checkin;
        private Label label_price;
        private ComboBox comboBox_client;
        private ComboBox comboBox_accommodation;
        private Label label_checkout;
        private DateTimePicker dateTimePicker_checkIn;
        private DateTimePicker dateTimePicker_checkOut;
        private Button button_save;
        private Label label_totalPrice;
        private Label label_status;
        private ComboBox comboBox_status;
    }
}