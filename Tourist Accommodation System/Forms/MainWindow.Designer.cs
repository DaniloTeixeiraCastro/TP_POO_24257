namespace Tourist_Accommodation_System
{
    partial class MainWindow

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button_CLIENT = new Button();
            button_accommodation = new Button();
            button_reservation = new Button();
            button_reviews = new Button();
            button_checkin = new Button();
            MainPanel = new Panel();
            button_payments = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(484, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 31);
            label1.TabIndex = 0;
            label1.Text = "TOURIST MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 548);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 263);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_CLIENT
            // 
            button_CLIENT.Location = new Point(44, 110);
            button_CLIENT.Margin = new Padding(3, 4, 3, 4);
            button_CLIENT.Name = "button_CLIENT";
            button_CLIENT.Size = new Size(240, 62);
            button_CLIENT.TabIndex = 7;
            button_CLIENT.Text = "CLIENT";
            button_CLIENT.UseVisualStyleBackColor = true;
            button_CLIENT.Click += button_client_Click;
            // 
            // button_accommodation
            // 
            button_accommodation.Location = new Point(44, 183);
            button_accommodation.Name = "button_accommodation";
            button_accommodation.Size = new Size(240, 62);
            button_accommodation.TabIndex = 8;
            button_accommodation.Text = "ACCOMMODATION";
            button_accommodation.UseVisualStyleBackColor = true;
            button_accommodation.Click += button_accommodation_Click;
            // 
            // button_reservation
            // 
            button_reservation.Location = new Point(44, 261);
            button_reservation.Name = "button_reservation";
            button_reservation.Size = new Size(240, 62);
            button_reservation.TabIndex = 9;
            button_reservation.Text = "RESERVATION";
            button_reservation.UseVisualStyleBackColor = true;
            button_reservation.Click += button_reservation_Click;
            // 
            // button_reviews
            // 
            button_reviews.Location = new Point(369, 110);
            button_reviews.Name = "button_reviews";
            button_reviews.Size = new Size(240, 62);
            button_reviews.TabIndex = 10;
            button_reviews.Text = "REVIEWS";
            button_reviews.UseVisualStyleBackColor = true;
            button_reviews.Click += button_reviews_Click;
            // 
            // button_checkin
            // 
            button_checkin.Location = new Point(369, 183);
            button_checkin.Name = "button_checkin";
            button_checkin.Size = new Size(240, 62);
            button_checkin.TabIndex = 11;
            button_checkin.Text = "CHECK-IN";
            button_checkin.UseVisualStyleBackColor = true;
            button_checkin.Click += button_checkin_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Controls.Add(button_payments);
            MainPanel.Controls.Add(button_checkin);
            MainPanel.Controls.Add(button_reservation);
            MainPanel.Controls.Add(button_reviews);
            MainPanel.Controls.Add(button_CLIENT);
            MainPanel.Controls.Add(button_accommodation);
            MainPanel.Location = new Point(334, 36);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(650, 514);
            MainPanel.TabIndex = 12;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // button_payments
            // 
            button_payments.Location = new Point(369, 261);
            button_payments.Name = "button_payments";
            button_payments.Size = new Size(240, 62);
            button_payments.TabIndex = 12;
            button_payments.Text = "PAYMENTS";
            button_payments.UseVisualStyleBackColor = true;
            button_payments.Click += button_payments_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 543);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(MainPanel);
            Name = "MainWindow";
            Text = "HOME";
            Load += HOME_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button_CLIENT;
        private Button button_accommodation;
        private Button button_reservation;
        private Button button_reviews;
        private Button button_checkin;
        public Panel MainPanel;
        private Button button_payments;
    }
}
