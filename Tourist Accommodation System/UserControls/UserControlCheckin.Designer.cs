namespace Tourist_Accommodation_System
{
    partial class UserControlCheckin
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
            button_listcheckin = new Button();
            button_removecheckin = new Button();
            button_editcheckin = new Button();
            button_addcheckin = new Button();
            button_back = new Button();
            label_menu = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_listcheckin
            // 
            button_listcheckin.Location = new Point(365, 310);
            button_listcheckin.Name = "button_listcheckin";
            button_listcheckin.Size = new Size(250, 80);
            button_listcheckin.TabIndex = 7;
            button_listcheckin.Text = "LIST CHECK-IN";
            button_listcheckin.UseVisualStyleBackColor = true;
            button_listcheckin.Click += button_listcheckin_Click;
            // 
            // button_removecheckin
            // 
            button_removecheckin.Location = new Point(76, 310);
            button_removecheckin.Name = "button_removecheckin";
            button_removecheckin.Size = new Size(250, 80);
            button_removecheckin.TabIndex = 6;
            button_removecheckin.Text = "REMOVE CHECK-IN";
            button_removecheckin.UseVisualStyleBackColor = true;
            button_removecheckin.Click += button_removecheckin_Click;
            // 
            // button_editcheckin
            // 
            button_editcheckin.Location = new Point(365, 191);
            button_editcheckin.Name = "button_editcheckin";
            button_editcheckin.Size = new Size(250, 80);
            button_editcheckin.TabIndex = 5;
            button_editcheckin.Text = "EDIT CHECK-IN";
            button_editcheckin.UseVisualStyleBackColor = true;
            button_editcheckin.Click += button_editcheckin_Click;
            // 
            // button_addcheckin
            // 
            button_addcheckin.Location = new Point(75, 190);
            button_addcheckin.Name = "button_addcheckin";
            button_addcheckin.Size = new Size(250, 80);
            button_addcheckin.TabIndex = 4;
            button_addcheckin.Text = "ADD CHECK-IN";
            button_addcheckin.UseVisualStyleBackColor = true;
            button_addcheckin.Click += button_addcheckin_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(455, 90);
            button_back.Name = "button_back";
            button_back.Size = new Size(70, 41);
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
            label_menu.ForeColor = SystemColors.Control;
            label_menu.Location = new Point(178, 90);
            label_menu.Name = "label_menu";
            label_menu.Size = new Size(244, 41);
            label_menu.TabIndex = 9;
            label_menu.Text = "CHECK-IN MENU";
            label_menu.Click += label_menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(178, 274);
            label1.Name = "label1";
            label1.Size = new Size(295, 41);
            label1.TabIndex = 10;
            label1.Text = "FUNCTIONS TO ADD";
            label1.Click += label1_Click;
            // 
            // UserControlCheckin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label_menu);
            Controls.Add(button_back);
            Controls.Add(button_listcheckin);
            Controls.Add(button_removecheckin);
            Controls.Add(button_editcheckin);
            Controls.Add(button_addcheckin);
            Name = "UserControlCheckin";
            Size = new Size(650, 550);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_listcheckin;
        private Button button_removecheckin;
        private Button button_editcheckin;
        private Button button_addcheckin;
        private Button button_back;
        private Label label_menu;
        private Label label1;
    }
}
