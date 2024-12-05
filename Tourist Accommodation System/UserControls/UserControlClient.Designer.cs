namespace Tourist_Accommodation_System
{
    public partial class UserControlClient : UserControl
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
            button_removeclient = new Button();
            button_editclient = new Button();
            button_addclient = new Button();
            button_back = new Button();
            button_listclient = new Button();
            listbox_clients = new ListBox();
            label1 = new Label();
            label_clientmenu = new Label();
            SuspendLayout();
            // 
            // button_removeclient
            // 
            button_removeclient.Location = new Point(82, 143);
            button_removeclient.Margin = new Padding(3, 2, 3, 2);
            button_removeclient.Name = "button_removeclient";
            button_removeclient.Size = new Size(156, 60);
            button_removeclient.TabIndex = 7;
            button_removeclient.Text = "REMOVE CLIENT";
            button_removeclient.UseVisualStyleBackColor = true;
            button_removeclient.Click += button_removeclient_Click;
            // 
            // button_editclient
            // 
            button_editclient.Location = new Point(313, 69);
            button_editclient.Margin = new Padding(3, 2, 3, 2);
            button_editclient.Name = "button_editclient";
            button_editclient.Size = new Size(149, 60);
            button_editclient.TabIndex = 6;
            button_editclient.Text = "EDIT CLIENT";
            button_editclient.UseVisualStyleBackColor = true;
            button_editclient.Click += button_editclient_Click;
            // 
            // button_addclient
            // 
            button_addclient.Location = new Point(82, 69);
            button_addclient.Margin = new Padding(3, 2, 3, 2);
            button_addclient.Name = "button_addclient";
            button_addclient.Size = new Size(156, 60);
            button_addclient.TabIndex = 5;
            button_addclient.Text = "ADD CLIENT";
            button_addclient.UseVisualStyleBackColor = true;
            button_addclient.Click += button_addclient_Click;
            // 
            // button_back
            // 
            button_back.BackColor = Color.Transparent;
            button_back.Location = new Point(417, 11);
            button_back.Margin = new Padding(3, 2, 3, 2);
            button_back.Name = "button_back";
            button_back.Size = new Size(45, 33);
            button_back.TabIndex = 9;
            button_back.Text = "<-";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // button_listclient
            // 
            button_listclient.Location = new Point(313, 143);
            button_listclient.Margin = new Padding(3, 2, 3, 2);
            button_listclient.Name = "button_listclient";
            button_listclient.Size = new Size(149, 60);
            button_listclient.TabIndex = 10;
            button_listclient.Text = "LIST CLIENT";
            button_listclient.UseVisualStyleBackColor = true;
            button_listclient.Click += button_listclient_Click;
            // 
            // listbox_clients
            // 
            listbox_clients.FormattingEnabled = true;
            listbox_clients.ItemHeight = 15;
            listbox_clients.Location = new Point(55, 242);
            listbox_clients.Margin = new Padding(3, 2, 3, 2);
            listbox_clients.Name = "listbox_clients";
            listbox_clients.Size = new Size(469, 139);
            listbox_clients.TabIndex = 11;
            listbox_clients.SelectedIndexChanged += listbox_clients_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label_clientmenu
            // 
            label_clientmenu.AutoSize = true;
            label_clientmenu.BackColor = SystemColors.ActiveCaptionText;
            label_clientmenu.Font = new Font("Segoe UI", 18F);
            label_clientmenu.ForeColor = SystemColors.ButtonHighlight;
            label_clientmenu.Location = new Point(191, 11);
            label_clientmenu.Name = "label_clientmenu";
            label_clientmenu.Size = new Size(164, 32);
            label_clientmenu.TabIndex = 12;
            label_clientmenu.Text = "CLIENT MENU";
            // 
            // UserControlClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_clientmenu);
            Controls.Add(label1);
            Controls.Add(listbox_clients);
            Controls.Add(button_listclient);
            Controls.Add(button_back);
            Controls.Add(button_removeclient);
            Controls.Add(button_editclient);
            Controls.Add(button_addclient);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlClient";
            Size = new Size(569, 412);
            Load += UserControlClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_removeclient;
        private Button button_editclient;
        private Button button_addclient;
        private Button button_back;
        private Button button_listclient;
        private ListBox listbox_clients;
        private Label label1;
        private Label label_clientmenu;
    }
}
