namespace Tourist_Accommodation_System.UserControls
{
    partial class UserControlPayments
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button_addpayment = new Button();
            button_editpayment = new Button();
            button_listpayment = new Button();
            button_back = new Button();
            label_menu = new Label();
            SuspendLayout();
            // 
            // button_addpayment
            // 
            button_addpayment.Location = new Point(150, 181);
            button_addpayment.Name = "button_addpayment";
            button_addpayment.Size = new Size(250, 80);
            button_addpayment.TabIndex = 0;
            button_addpayment.Text = "ADD PAYMENT";
            button_addpayment.UseVisualStyleBackColor = true;
            button_addpayment.Click += button_addpayment_Click;
            // 
            // button_editpayment
            // 
            button_editpayment.Location = new Point(150, 281);
            button_editpayment.Name = "button_editpayment";
            button_editpayment.Size = new Size(250, 80);
            button_editpayment.TabIndex = 1;
            button_editpayment.Text = "EDIT PAYMENT";
            button_editpayment.UseVisualStyleBackColor = true;
            button_editpayment.Click += button_editpayment_Click;
            // 
            // button_listpayment
            // 
            button_listpayment.Location = new Point(150, 381);
            button_listpayment.Name = "button_listpayment";
            button_listpayment.Size = new Size(250, 80);
            button_listpayment.TabIndex = 2;
            button_listpayment.Text = "LIST PAYMENT";
            button_listpayment.UseVisualStyleBackColor = true;
            button_listpayment.Click += button_listpayment_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(494, 83);
            button_back.Name = "button_back";
            button_back.Size = new Size(44, 41);
            button_back.TabIndex = 3;
            button_back.Text = "<-";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label_menu
            // 
            label_menu.AutoSize = true;
            label_menu.BackColor = SystemColors.ActiveCaptionText;
            label_menu.Font = new Font("Segoe UI", 18F);
            label_menu.ForeColor = SystemColors.ButtonHighlight;
            label_menu.Location = new Point(180, 83);
            label_menu.Name = "label_menu";
            label_menu.Size = new Size(240, 41);
            label_menu.TabIndex = 4;
            label_menu.Text = "PAYMENT MENU";
            label_menu.Click += label_menu_Click;
            // 
            // UserControlPayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_menu);
            Controls.Add(button_back);
            Controls.Add(button_listpayment);
            Controls.Add(button_editpayment);
            Controls.Add(button_addpayment);
            Name = "UserControlPayments";
            Size = new Size(650, 550);
            Load += UserControlPayments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_addpayment;
        private Button button_editpayment;
        private Button button_listpayment;
        private Button button_back;
        private Label label_menu;
    }
}
