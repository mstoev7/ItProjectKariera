namespace ItProjectKariera
{
    partial class Form1
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
            button_login = new Button();
            label1 = new Label();
            txt_username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_password = new TextBox();
            button_clear = new Button();
            button_exit = new Button();
            button_login.Click += button_login_Click;
            button_exit.Click += button_exit_Click;
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.BackColor = Color.Lavender;
            button_login.Location = new Point(245, 153);
            button_login.Name = "button_login";
            button_login.Size = new Size(71, 23);
            button_login.TabIndex = 0;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_username.Location = new Point(113, 62);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(218, 23);
            txt_username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 65);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_password.Location = new Point(113, 114);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(218, 23);
            txt_password.TabIndex = 5;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.Lavender;
            button_clear.Location = new Point(130, 153);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(71, 23);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Lavender;
            button_exit.Location = new Point(42, 217);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 23);
            button_exit.TabIndex = 7;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(415, 267);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Controls.Add(button_login);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_login;
        private Label label1;
        private TextBox txt_username;
        private Label label2;
        private Label label3;
        private TextBox txt_password;
        private Button button_clear;
        private Button button_exit;
        private EventHandler label1_Click;
    }
}