namespace Tourist_Accommodation_System
{
    partial class UserControlReservation
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
            button_listreservation = new Button();
            button_removereservation = new Button();
            button_editreservation = new Button();
            button_addreservation = new Button();
            button_back = new Button();
            label_menu = new Label();
            SuspendLayout();
            // 
            // button_listreservation
            // 
            button_listreservation.Location = new Point(336, 316);
            button_listreservation.Name = "button_listreservation";
            button_listreservation.Size = new Size(300, 80);
            button_listreservation.TabIndex = 7;
            button_listreservation.Text = "LIST RESERVATION";
            button_listreservation.UseVisualStyleBackColor = true;
            button_listreservation.Click += button_listreservation_Click;
            // 
            // button_removereservation
            // 
            button_removereservation.Location = new Point(30, 316);
            button_removereservation.Name = "button_removereservation";
            button_removereservation.Size = new Size(300, 80);
            button_removereservation.TabIndex = 6;
            button_removereservation.Text = "REMOVE RESERVATION";
            button_removereservation.UseVisualStyleBackColor = true;
            button_removereservation.Click += button_removereservation_Click;
            // 
            // button_editreservation
            // 
            button_editreservation.Location = new Point(336, 200);
            button_editreservation.Name = "button_editreservation";
            button_editreservation.Size = new Size(300, 80);
            button_editreservation.TabIndex = 5;
            button_editreservation.Text = "EDIT RESERVATION";
            button_editreservation.UseVisualStyleBackColor = true;
            button_editreservation.Click += button_editreservation_Click;
            // 
            // button_addreservation
            // 
            button_addreservation.Location = new Point(30, 200);
            button_addreservation.Name = "button_addreservation";
            button_addreservation.Size = new Size(300, 80);
            button_addreservation.TabIndex = 4;
            button_addreservation.Text = "ADD RESERVATION";
            button_addreservation.UseVisualStyleBackColor = true;
            button_addreservation.Click += button_addreservation_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(491, 99);
            button_back.Name = "button_back";
            button_back.Size = new Size(55, 41);
            button_back.TabIndex = 8;
            button_back.Text = "<-";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label_menu
            // 
            label_menu.AutoSize = true;
            label_menu.BackColor = SystemColors.ActiveCaptionText;
            label_menu.Font = new Font("Segoe UI", 18F);
            label_menu.ForeColor = SystemColors.ControlLightLight;
            label_menu.Location = new Point(162, 99);
            label_menu.Name = "label_menu";
            label_menu.Size = new Size(296, 41);
            label_menu.TabIndex = 9;
            label_menu.Text = "RESERVATION MENU";
            label_menu.Click += label_menu_Click;
            // 
            // UserControlReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_menu);
            Controls.Add(button_back);
            Controls.Add(button_listreservation);
            Controls.Add(button_removereservation);
            Controls.Add(button_editreservation);
            Controls.Add(button_addreservation);
            Name = "UserControlReservation";
            Size = new Size(650, 550);
            Load += UserControlReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_listreservation;
        private Button button_removereservation;
        private Button button_editreservation;
        private Button button_addreservation;
        private Button button_back;
        private Label label_menu;
    }
}
