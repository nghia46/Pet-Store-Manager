namespace TestTrial_1_2
{
    partial class Login
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new Label();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Location = new Point(113, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(294, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.ControlText;
            txtUserName.Location = new Point(47, 123);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(36, 15);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 152);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(171, 30);
            label2.Name = "label2";
            label2.Size = new Size(171, 62);
            label2.TabIndex = 4;
            label2.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(190, 178);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 275);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label txtUserName;
        private Label label1;
        private Label label2;
        private Button btnLogin;
    }
}