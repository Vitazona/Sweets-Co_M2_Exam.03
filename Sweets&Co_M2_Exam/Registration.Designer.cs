namespace Sweets_Co_M2_Exam
{
    partial class Registration
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
            panel1 = new Panel();
            panel2 = new Panel();
            txtAddress = new TextBox();
            lbladdress = new Label();
            btnLoginHere = new Label();
            label8 = new Label();
            label7 = new Label();
            btnShowPass = new CheckBox();
            txtUsername = new TextBox();
            txtNumber = new TextBox();
            txtLastName = new TextBox();
            txtPassword = new TextBox();
            txtFirstName = new TextBox();
            btnSignUp = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources._2;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(72, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 638);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(lbladdress);
            panel2.Controls.Add(btnLoginHere);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnShowPass);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(txtNumber);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(btnSignUp);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(128, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 637);
            panel2.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(57, 248);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(326, 23);
            txtAddress.TabIndex = 15;
            // 
            // lbladdress
            // 
            lbladdress.BackColor = Color.Transparent;
            lbladdress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladdress.Image = Properties.Resources.address;
            lbladdress.Location = new Point(57, 213);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(100, 58);
            lbladdress.TabIndex = 2;
            // 
            // btnLoginHere
            // 
            btnLoginHere.AutoSize = true;
            btnLoginHere.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginHere.Location = new Point(237, 611);
            btnLoginHere.Name = "btnLoginHere";
            btnLoginHere.Size = new Size(68, 15);
            btnLoginHere.TabIndex = 14;
            btnLoginHere.Text = "Login Here";
            btnLoginHere.Click += btnLoginHere_Click;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 611);
            label7.Name = "label7";
            label7.Size = new Size(142, 15);
            label7.TabIndex = 13;
            label7.Text = "Already have an account?";
            // 
            // btnShowPass
            // 
            btnShowPass.AutoSize = true;
            btnShowPass.Location = new Point(275, 487);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(108, 19);
            btnShowPass.TabIndex = 12;
            btnShowPass.Text = "Show Password";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.CheckedChanged += btnShowPass_CheckedChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(57, 388);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 23);
            txtUsername.TabIndex = 11;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(57, 319);
            txtNumber.Margin = new Padding(3, 2, 3, 2);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(326, 23);
            txtNumber.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(57, 179);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(326, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(57, 459);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(326, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(57, 109);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(326, 23);
            txtFirstName.TabIndex = 7;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.BackgroundImageLayout = ImageLayout.None;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Image = Properties.Resources.bkground;
            btnSignUp.Location = new Point(57, 510);
            btnSignUp.Margin = new Padding(3, 2, 3, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(129, 56);
            btnSignUp.TabIndex = 6;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Image = Properties.Resources._51;
            label6.Location = new Point(54, 425);
            label6.Name = "label6";
            label6.Size = new Size(117, 57);
            label6.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Image = Properties.Resources._41;
            label5.Location = new Point(57, 356);
            label5.Name = "label5";
            label5.Size = new Size(117, 46);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Image = Properties.Resources._8;
            label4.Location = new Point(57, 287);
            label4.Name = "label4";
            label4.Size = new Size(158, 55);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Image = Properties.Resources._7;
            label3.Location = new Point(54, 134);
            label3.Name = "label3";
            label3.Size = new Size(111, 68);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Image = Properties.Resources._6;
            label2.Location = new Point(57, 72);
            label2.Name = "label2";
            label2.Size = new Size(114, 62);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = Properties.Resources.logo__2_;
            label1.Location = new Point(109, 7);
            label1.Name = "label1";
            label1.Size = new Size(253, 100);
            label1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(825, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 21);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(857, 636);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Registration";
            Text = "Registration";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label btnExit;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private CheckBox btnShowPass;
        private TextBox txtUsername;
        private TextBox txtNumber;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtFirstName;
        private Button btnSignUp;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label btnLoginHere;
        private Label lbladdress;
        private TextBox txtAddress;
    }
}