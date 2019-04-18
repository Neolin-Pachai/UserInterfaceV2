namespace UserInterfaceV2
{
    partial class Register
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
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisterSubmit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(182, 582);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(351, 35);
            this.txtRePassword.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Re-Enter Password:";
            // 
            // btnRegisterSubmit
            // 
            this.btnRegisterSubmit.Location = new System.Drawing.Point(182, 667);
            this.btnRegisterSubmit.Name = "btnRegisterSubmit";
            this.btnRegisterSubmit.Size = new System.Drawing.Size(351, 49);
            this.btnRegisterSubmit.TabIndex = 23;
            this.btnRegisterSubmit.Text = "REGISTER";
            this.btnRegisterSubmit.UseVisualStyleBackColor = true;
            this.btnRegisterSubmit.Click += new System.EventHandler(this.btnRegisterSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(182, 453);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(351, 35);
            this.txtPassword.TabIndex = 22;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(182, 315);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(351, 35);
            this.txtUserName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "UserName:";
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Modern No. 20", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(168, 86);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(432, 80);
            this.LOGIN.TabIndex = 18;
            this.LOGIN.Text = "REGISTER";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 875);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOGIN);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegisterSubmit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LOGIN;
    }
}