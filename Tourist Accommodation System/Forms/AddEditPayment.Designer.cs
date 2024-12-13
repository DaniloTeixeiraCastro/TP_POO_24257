namespace Tourist_Accommodation_System.Forms
{
    partial class AddEditPayment
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
            label_reservation = new Label();
            label_amount = new Label();
            label_paymentdate = new Label();
            label_paymentmethod = new Label();
            button_save = new Button();
            button_cancel = new Button();
            comboBox_reservation = new ComboBox();
            numericUpDown = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label_status = new Label();
            comboBox_status = new ComboBox();
            comboBox_method = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label_reservation
            // 
            label_reservation.AutoSize = true;
            label_reservation.Location = new Point(105, 82);
            label_reservation.Name = "label_reservation";
            label_reservation.Size = new Size(102, 20);
            label_reservation.TabIndex = 0;
            label_reservation.Text = "RESERVATION";
            label_reservation.Click += label_reservation_Click;
            // 
            // label_amount
            // 
            label_amount.AutoSize = true;
            label_amount.Location = new Point(105, 134);
            label_amount.Name = "label_amount";
            label_amount.Size = new Size(72, 20);
            label_amount.TabIndex = 1;
            label_amount.Text = "AMOUNT";
            label_amount.Click += label_amount_Click;
            // 
            // label_paymentdate
            // 
            label_paymentdate.AutoSize = true;
            label_paymentdate.Location = new Point(105, 181);
            label_paymentdate.Name = "label_paymentdate";
            label_paymentdate.Size = new Size(113, 20);
            label_paymentdate.TabIndex = 2;
            label_paymentdate.Text = "PAYMENT DATE";
            label_paymentdate.Click += label_paymentdate_Click;
            // 
            // label_paymentmethod
            // 
            label_paymentmethod.AutoSize = true;
            label_paymentmethod.Location = new Point(105, 259);
            label_paymentmethod.Name = "label_paymentmethod";
            label_paymentmethod.Size = new Size(139, 20);
            label_paymentmethod.TabIndex = 3;
            label_paymentmethod.Text = "PAYMENT METHOD";
            label_paymentmethod.Click += label_paymentmethod_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(138, 369);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 4;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(527, 369);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // comboBox_reservation
            // 
            comboBox_reservation.FormattingEnabled = true;
            comboBox_reservation.Location = new Point(471, 79);
            comboBox_reservation.Name = "comboBox_reservation";
            comboBox_reservation.Size = new Size(151, 28);
            comboBox_reservation.TabIndex = 6;
            comboBox_reservation.SelectedIndexChanged += comboBox_reservation_SelectedIndexChanged;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(471, 127);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(150, 27);
            numericUpDown.TabIndex = 7;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(471, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(105, 221);
            label_status.Name = "label_status";
            label_status.Size = new Size(127, 20);
            label_status.TabIndex = 9;
            label_status.Text = "PAYMENT STATUS";
            label_status.Click += label_status_Click;
            // 
            // comboBox_status
            // 
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Location = new Point(471, 221);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(151, 28);
            comboBox_status.TabIndex = 10;
            comboBox_status.SelectedIndexChanged += comboBox_status_SelectedIndexChanged;
            // 
            // comboBox_method
            // 
            comboBox_method.FormattingEnabled = true;
            comboBox_method.Location = new Point(471, 259);
            comboBox_method.Name = "comboBox_method";
            comboBox_method.Size = new Size(151, 28);
            comboBox_method.TabIndex = 11;
            comboBox_method.SelectedIndexChanged += comboBox_method_SelectedIndexChanged;
            // 
            // AddEditPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_method);
            Controls.Add(comboBox_status);
            Controls.Add(label_status);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown);
            Controls.Add(comboBox_reservation);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(label_paymentmethod);
            Controls.Add(label_paymentdate);
            Controls.Add(label_amount);
            Controls.Add(label_reservation);
            Name = "AddEditPayment";
            Text = "AddEditPayment";
            Load += AddEditPayment_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_reservation;
        private Label label_amount;
        private Label label_paymentdate;
        private Label label_paymentmethod;
        private Button button_save;
        private Button button_cancel;
        private ComboBox comboBox_reservation;
        private NumericUpDown numericUpDown;
        private DateTimePicker dateTimePicker1;
        private Label label_status;
        private ComboBox comboBox_status;
        private ComboBox comboBox_method;
    }
}