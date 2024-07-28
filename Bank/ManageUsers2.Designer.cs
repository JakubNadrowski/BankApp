namespace Bank
{
    partial class ManageUsers2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MngUserID = new TextBox();
            MngUserUsrName = new TextBox();
            MngUserPassword = new TextBox();
            MngUserEmail = new TextBox();
            MngUserPhoneNum = new TextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            userView = new DataGridView();
            test = new Label();
            Decider = new Label();
            ((System.ComponentModel.ISupportInitialize)userView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(340, 29);
            label1.Name = "label1";
            label1.Size = new Size(323, 62);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 234);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 270);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 5;
            label6.Text = "PhoneNum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 310);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 6;
            label7.Text = "AdminStatus";
            // 
            // MngUserID
            // 
            MngUserID.Location = new Point(118, 124);
            MngUserID.Name = "MngUserID";
            MngUserID.Size = new Size(125, 27);
            MngUserID.TabIndex = 7;
            // 
            // MngUserUsrName
            // 
            MngUserUsrName.Location = new Point(118, 160);
            MngUserUsrName.Name = "MngUserUsrName";
            MngUserUsrName.Size = new Size(125, 27);
            MngUserUsrName.TabIndex = 8;
            // 
            // MngUserPassword
            // 
            MngUserPassword.Location = new Point(118, 195);
            MngUserPassword.Name = "MngUserPassword";
            MngUserPassword.Size = new Size(125, 27);
            MngUserPassword.TabIndex = 9;
            // 
            // MngUserEmail
            // 
            MngUserEmail.Location = new Point(118, 231);
            MngUserEmail.Name = "MngUserEmail";
            MngUserEmail.Size = new Size(125, 27);
            MngUserEmail.TabIndex = 10;
            // 
            // MngUserPhoneNum
            // 
            MngUserPhoneNum.Location = new Point(118, 267);
            MngUserPhoneNum.Name = "MngUserPhoneNum";
            MngUserPhoneNum.Size = new Size(125, 27);
            MngUserPhoneNum.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "1" });
            comboBox1.Location = new Point(118, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 28);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Select Role";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1003, 9);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 15;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 364);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 16;
            label9.Text = "Add";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 364);
            label10.Name = "label10";
            label10.Size = new Size(35, 20);
            label10.TabIndex = 17;
            label10.Text = "Edit";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(118, 364);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 18;
            label11.Text = "Delete";
            label11.Click += label11_Click;
            // 
            // userView
            // 
            userView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userView.Location = new Point(340, 106);
            userView.MultiSelect = false;
            userView.Name = "userView";
            userView.RowHeadersWidth = 51;
            userView.RowTemplate.Height = 29;
            userView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userView.Size = new Size(713, 243);
            userView.TabIndex = 19;
            userView.CellContentClick += userView_CellContentClick;
            // 
            // test
            // 
            test.AutoSize = true;
            test.Location = new Point(229, 429);
            test.Name = "test";
            test.Size = new Size(0, 20);
            test.TabIndex = 20;
            test.Click += label12_Click;
            // 
            // Decider
            // 
            Decider.AutoSize = true;
            Decider.Location = new Point(644, 364);
            Decider.Name = "Decider";
            Decider.Size = new Size(0, 20);
            Decider.TabIndex = 21;
            // 
            // ManageUsers2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1065, 518);
            Controls.Add(Decider);
            Controls.Add(test);
            Controls.Add(userView);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(MngUserPhoneNum);
            Controls.Add(MngUserEmail);
            Controls.Add(MngUserPassword);
            Controls.Add(MngUserUsrName);
            Controls.Add(MngUserID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers2";
            Text = "ManageUsers2";
            ((System.ComponentModel.ISupportInitialize)userView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox MngUserID;
        private TextBox MngUserUsrName;
        private TextBox MngUserPassword;
        private TextBox MngUserEmail;
        private TextBox MngUserPhoneNum;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridView userView;
        private Label test;
        private Label Decider;
    }
}