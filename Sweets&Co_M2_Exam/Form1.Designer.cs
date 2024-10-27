namespace Sweets_Co_M2_Exam
{
    partial class frmLogin
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
            panel1 = new Panel();
            btnExit = new Label();
            panel2 = new Panel();
            btnShowPass = new CheckBox();
            btnSignUpHere = new Label();
            btnLogin = new Button();
            lblAccountCreation = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLogo = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblAccount = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bkground__2_;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 446);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(803, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 21);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(btnShowPass);
            panel2.Controls.Add(btnSignUpHere);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(lblAccountCreation);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblLogo);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblAccount);
            panel2.Location = new Point(61, 32);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 379);
            panel2.TabIndex = 0;
            // 
            // btnShowPass
            // 
            btnShowPass.AutoSize = true;
            btnShowPass.Location = new Point(535, 185);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(108, 19);
            btnShowPass.TabIndex = 13;
            btnShowPass.Text = "Show Password";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.CheckedChanged += btnShowPass_CheckedChanged;
            // 
            // btnSignUpHere
            // 
            btnSignUpHere.AutoSize = true;
            btnSignUpHere.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUpHere.Location = new Point(536, 312);
            btnSignUpHere.Name = "btnSignUpHere";
            btnSignUpHere.Size = new Size(107, 21);
            btnSignUpHere.TabIndex = 7;
            btnSignUpHere.Text = "Sign Up Here";
            btnSignUpHere.Click += btnSignUpHere_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.AntiqueWhite;
            btnLogin.BackgroundImage = Properties.Resources.login;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Image = Properties.Resources.login;
            btnLogin.Location = new Point(368, 201);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 65);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "\r\n";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblAccountCreation
            // 
            lblAccountCreation.Location = new Point(0, 0);
            lblAccountCreation.Name = "lblAccountCreation";
            lblAccountCreation.Size = new Size(100, 23);
            lblAccountCreation.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(368, 157);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(275, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(368, 86);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(275, 23);
            txtUsername.TabIndex = 3;
            // 
            // lblLogo
            // 
            lblLogo.Image = Properties.Resources.nobg;
            lblLogo.Location = new Point(32, 16);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(328, 345);
            lblLogo.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.Image = Properties.Resources._5;
            lblPassword.Location = new Point(365, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 49);
            lblPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.Image = Properties.Resources._4;
            lblUsername.Location = new Point(365, 52);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(124, 44);
            lblUsername.TabIndex = 0;
            // 
            // lblAccount
            // 
            lblAccount.FlatStyle = FlatStyle.Flat;
            lblAccount.Image = Properties.Resources._3;
            lblAccount.Location = new Point(355, 303);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(194, 43);
            lblAccount.TabIndex = 15;
            lblAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(833, 442);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLogin;
        private Label lblAccountCreation;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblLogo;
        private Label lblPassword;
        private Label lblUsername;
        private Label btnExit;
        private Label btnSignUpHere;
        private CheckBox btnShowPass;
        private Label lblAccount;
    }
}
