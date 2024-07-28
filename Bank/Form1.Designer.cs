namespace Bank
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
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label3 = new Label();
            button1 = new Button();
            PasswordTb = new TextBox();
            UsernameTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(UsernameTb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(283, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 332);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(17, 245);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Create User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 11);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 8;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(114, 290);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "ShowPassword";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 291);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "Clear";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(129, 245);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(57, 167);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(125, 27);
            PasswordTb.TabIndex = 3;
            PasswordTb.UseSystemPasswordChar = true;
            PasswordTb.TextChanged += textBox2_TextChanged;
            // 
            // UsernameTb
            // 
            UsernameTb.Location = new Point(57, 134);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(125, 27);
            UsernameTb.TabIndex = 2;
            UsernameTb.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 41);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(134, 60);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(570, 32);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(178, 60);
            label2.TabIndex = 1;
            label2.Text = "JBBANK";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox PasswordTb;
        private TextBox UsernameTb;
        private CheckBox checkBox1;
        private Label label4;
        private Button button2;
    }
}