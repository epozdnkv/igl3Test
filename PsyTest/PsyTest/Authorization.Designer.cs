namespace PsyTest
{
    partial class Authorization
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llAdmin = new System.Windows.Forms.LinkLabel();
            this.btnComing = new System.Windows.Forms.Button();
            this.llRegistration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 26);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(181, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 74);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(181, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // llAdmin
            // 
            this.llAdmin.AutoSize = true;
            this.llAdmin.LinkColor = System.Drawing.Color.DimGray;
            this.llAdmin.Location = new System.Drawing.Point(32, 159);
            this.llAdmin.Name = "llAdmin";
            this.llAdmin.Size = new System.Drawing.Size(139, 13);
            this.llAdmin.TabIndex = 4;
            this.llAdmin.TabStop = true;
            this.llAdmin.Text = "Войти как администратор";
            this.llAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdmin_LinkClicked);
            // 
            // btnComing
            // 
            this.btnComing.Location = new System.Drawing.Point(65, 111);
            this.btnComing.Name = "btnComing";
            this.btnComing.Size = new System.Drawing.Size(72, 23);
            this.btnComing.TabIndex = 5;
            this.btnComing.Text = "Войти";
            this.btnComing.UseVisualStyleBackColor = true;
            this.btnComing.Click += new System.EventHandler(this.btnComing_Click);
            // 
            // llRegistration
            // 
            this.llRegistration.AutoSize = true;
            this.llRegistration.Location = new System.Drawing.Point(66, 137);
            this.llRegistration.Name = "llRegistration";
            this.llRegistration.Size = new System.Drawing.Size(72, 13);
            this.llRegistration.TabIndex = 6;
            this.llRegistration.TabStop = true;
            this.llRegistration.Text = "Регистрация";
            this.llRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRegistration_LinkClicked);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 192);
            this.Controls.Add(this.llRegistration);
            this.Controls.Add(this.btnComing);
            this.Controls.Add(this.llAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Authorization";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llAdmin;
        private System.Windows.Forms.Button btnComing;
        private System.Windows.Forms.LinkLabel llRegistration;
    }
}