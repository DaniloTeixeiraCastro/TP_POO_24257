namespace Tourist_Accommodation_System.Forms
{
    partial class ClientManagementForm
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
            comboBox1 = new ComboBox();
            button_edit = new Button();
            button_remove = new Button();
            button_list = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(586, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(115, 272);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(94, 29);
            button_edit.TabIndex = 1;
            button_edit.Text = "EDIT";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(337, 272);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(94, 29);
            button_remove.TabIndex = 2;
            button_remove.Text = "REMOVE";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button_list
            // 
            button_list.Location = new Point(561, 272);
            button_list.Name = "button_list";
            button_list.Size = new Size(94, 29);
            button_list.TabIndex = 3;
            button_list.Text = "LIST";
            button_list.UseVisualStyleBackColor = true;
            button_list.Click += button_list_Click;
            // 
            // ClientManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_list);
            Controls.Add(button_remove);
            Controls.Add(button_edit);
            Controls.Add(comboBox1);
            Name = "ClientManagementForm";
            Text = "ClientManagementForm";
            Load += ClientManagementForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button button_edit;
        private Button button_remove;
        private Button button_list;


    }
}