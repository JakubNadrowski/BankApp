namespace Bank
{
    partial class CreateUser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            UsernameTxt = new TextBox();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            PhonenumTxt = new TextBox();
            button1 = new Button();
            lblDisplay = new Label();
            CheckUnames = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 65);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 126);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(298, 9);
            label3.Name = "label3";
            label3.Size = new Size(172, 41);
            label3.TabIndex = 2;
            label3.Text = "Create User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 181);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 241);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "PhoneNum";
            // 
            // UsernameTxt
            // 
            UsernameTxt.Location = new Point(322, 88);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(125, 27);
            UsernameTxt.TabIndex = 5;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(322, 151);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(125, 27);
            PasswordTxt.TabIndex = 6;
            PasswordTxt.UseSystemPasswordChar = true;
            PasswordTxt.TextChanged += PasswordTxt_TextChanged;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(322, 204);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(125, 27);
            EmailTxt.TabIndex = 7;
            // 
            // PhonenumTxt
            // 
            PhonenumTxt.Location = new Point(322, 264);
            PhonenumTxt.Name = "PhonenumTxt";
            PhonenumTxt.Size = new Size(125, 27);
            PhonenumTxt.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(263, 325);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "CreateUser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(345, 376);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 20);
            lblDisplay.TabIndex = 10;
            // 
            // CheckUnames
            // 
            CheckUnames.AutoSize = true;
            CheckUnames.Location = new Point(36, 126);
            CheckUnames.Name = "CheckUnames";
            CheckUnames.Size = new Size(0, 20);
            CheckUnames.TabIndex = 11;
            CheckUnames.Click += CheckUnames_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(418, 328);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(CheckUnames);
            Controls.Add(lblDisplay);
            Controls.Add(button1);
            Controls.Add(PhonenumTxt);
            Controls.Add(EmailTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateUser";
            Text = "CreateUser";
            Load += CreateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox UsernameTxt;
        private TextBox PasswordTxt;
        private TextBox EmailTxt;
        private TextBox PhonenumTxt;
        private Button button1;
        private Label lblDisplay;
        private Label CheckUnames;
        private CheckBox checkBox1;
    }
}