namespace Tourist_Accommodation_System
{
    partial class UserControlAccommodation
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
            button_listaccommodation = new Button();
            button_removeaccommodation = new Button();
            button_editaccommodation = new Button();
            button_addaccommodation = new Button();
            button_back = new Button();
            button_filter = new Button();
            label_accommodationmenu = new Label();
            SuspendLayout();
            // 
            // button_listaccommodation
            // 
            button_listaccommodation.BackColor = SystemColors.ButtonHighlight;
            button_listaccommodation.Location = new Point(351, 279);
            button_listaccommodation.Name = "button_listaccommodation";
            button_listaccommodation.Size = new Size(250, 80);
            button_listaccommodation.TabIndex = 7;
            button_listaccommodation.Text = "LIST ACCOMMODATION";
            button_listaccommodation.UseVisualStyleBackColor = false;
            button_listaccommodation.Click += button_listaccommodation_Click;
            // 
            // button_removeaccommodation
            // 
            button_removeaccommodation.Location = new Point(62, 279);
            button_removeaccommodation.Name = "button_removeaccommodation";
            button_removeaccommodation.Size = new Size(250, 80);
            button_removeaccommodation.TabIndex = 6;
            button_removeaccommodation.Text = "REMOVE ACCOMMODATION";
            button_removeaccommodation.UseVisualStyleBackColor = true;
            button_removeaccommodation.Click += button_removeaccommodation_Click;
            // 
            // button_editaccommodation
            // 
            button_editaccommodation.Location = new Point(351, 159);
            button_editaccommodation.Name = "button_editaccommodation";
            button_editaccommodation.Size = new Size(250, 80);
            button_editaccommodation.TabIndex = 5;
            button_editaccommodation.Text = "EDIT ACCOMMODATION";
            button_editaccommodation.UseVisualStyleBackColor = true;
            button_editaccommodation.Click += button_editaccommodation_Click;
            // 
            // button_addaccommodation
            // 
            button_addaccommodation.Location = new Point(57, 159);
            button_addaccommodation.Name = "button_addaccommodation";
            button_addaccommodation.Size = new Size(250, 80);
            button_addaccommodation.TabIndex = 4;
            button_addaccommodation.Text = "ADD ACCOMMODATION";
            button_addaccommodation.UseVisualStyleBackColor = true;
            button_addaccommodation.Click += button_addaccommodation_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(506, 80);
            button_back.Name = "button_back";
            button_back.Size = new Size(58, 40);
            button_back.TabIndex = 8;
            button_back.Text = "<-";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_filter
            // 
            button_filter.BackColor = SystemColors.ButtonHighlight;
            button_filter.Location = new Point(148, 412);
            button_filter.Name = "button_filter";
            button_filter.Size = new Size(300, 67);
            button_filter.TabIndex = 9;
            button_filter.Text = "FILTER";
            button_filter.UseVisualStyleBackColor = false;
            button_filter.Click += button_filter_Click;
            // 
            // label_accommodationmenu
            // 
            label_accommodationmenu.AutoSize = true;
            label_accommodationmenu.BackColor = SystemColors.ActiveCaptionText;
            label_accommodationmenu.Font = new Font("Segoe UI", 18F);
            label_accommodationmenu.ForeColor = SystemColors.ControlLightLight;
            label_accommodationmenu.Location = new Point(114, 79);
            label_accommodationmenu.Name = "label_accommodationmenu";
            label_accommodationmenu.Size = new Size(371, 41);
            label_accommodationmenu.TabIndex = 10;
            label_accommodationmenu.Text = "ACCOMMODATION MENU";
            // 
            // UserControlAccommodation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_accommodationmenu);
            Controls.Add(button_filter);
            Controls.Add(button_back);
            Controls.Add(button_listaccommodation);
            Controls.Add(button_removeaccommodation);
            Controls.Add(button_editaccommodation);
            Controls.Add(button_addaccommodation);
            Name = "UserControlAccommodation";
            Size = new Size(650, 550);
            Load += UserControlAccommodation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_listaccommodation;
        private Button button_removeaccommodation;
        private Button button_editaccommodation;
        private Button button_addaccommodation;
        private Button button_back;
        private Button button_filter;
        private Label label_accommodationmenu;
    }
}
