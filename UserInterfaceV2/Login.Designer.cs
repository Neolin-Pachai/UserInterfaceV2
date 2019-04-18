namespace UserInterfaceV2
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
            this.btnLoginSubmit = new System.Windows.Forms.Button();
            this.llForgotPassword = new System.Windows.Forms.LinkLabel();
            this.llNewUser = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.Location = new System.Drawing.Point(214, 561);
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.Size = new System.Drawing.Size(351, 49);
            this.btnLoginSubmit.TabIndex = 15;
            this.btnLoginSubmit.Text = "SUBMIT";
            this.btnLoginSubmit.UseVisualStyleBackColor = true;
            this.btnLoginSubmit.Click += new System.EventHandler(this.btnLoginSubmit_Click);
            // 
            // llForgotPassword
            // 
            this.llForgotPassword.AutoSize = true;
            this.llForgotPassword.Location = new System.Drawing.Point(209, 725);
            this.llForgotPassword.Name = "llForgotPassword";
            this.llForgotPassword.Size = new System.Drawing.Size(215, 29);
            this.llForgotPassword.TabIndex = 14;
            this.llForgotPassword.TabStop = true;
            this.llForgotPassword.Text = "Forgot Password ?";
            this.llForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llForgotPassword_LinkClicked);
            // 
            // llNewUser
            // 
            this.llNewUser.AutoSize = true;
            this.llNewUser.Location = new System.Drawing.Point(209, 658);
            this.llNewUser.Name = "llNewUser";
            this.llNewUser.Size = new System.Drawing.Size(138, 29);
            this.llNewUser.TabIndex = 13;
            this.llNewUser.TabStop = true;
            this.llNewUser.Text = "New User ?";
            this.llNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNewUser_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 460);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(351, 35);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "1606";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(214, 319);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(351, 35);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Text = "Neolin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "UserName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 80);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 860);
            this.Controls.Add(this.btnLoginSubmit);
            this.Controls.Add(this.llForgotPassword);
            this.Controls.Add(this.llNewUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginSubmit;
        private System.Windows.Forms.LinkLabel llForgotPassword;
        private System.Windows.Forms.LinkLabel llNewUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}