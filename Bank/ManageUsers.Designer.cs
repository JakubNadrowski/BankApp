namespace Bank
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            AccountView = new DataGridView();
            button3 = new Button();
            TransferView = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransferView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 111);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(999, 9);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(362, 24);
            label1.Name = "label1";
            label1.Size = new Size(306, 49);
            label1.TabIndex = 0;
            label1.Text = "ManageAccounts";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 469);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 1;
            button1.Text = "ChangePassword";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1019, 499);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(125, 469);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 3;
            button2.Text = "DeleteUser";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AccountView
            // 
            AccountView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountView.Location = new Point(12, 142);
            AccountView.Name = "AccountView";
            AccountView.RowHeadersWidth = 51;
            AccountView.RowTemplate.Height = 29;
            AccountView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccountView.Size = new Size(424, 248);
            AccountView.TabIndex = 4;
            AccountView.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button3
            // 
            button3.Location = new Point(254, 469);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 5;
            button3.Text = "Create Account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TransferView
            // 
            TransferView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransferView.Location = new Point(442, 142);
            TransferView.Name = "TransferView";
            TransferView.RowHeadersWidth = 51;
            TransferView.RowTemplate.Height = 29;
            TransferView.Size = new Size(559, 248);
            TransferView.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(381, 469);
            button4.Name = "button4";
            button4.Size = new Size(122, 29);
            button4.TabIndex = 7;
            button4.Text = "Make a transfer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(509, 469);
            button5.Name = "button5";
            button5.Size = new Size(105, 29);
            button5.TabIndex = 8;
            button5.Text = "Add balance";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(620, 469);
            button6.Name = "button6";
            button6.Size = new Size(169, 29);
            button6.TabIndex = 9;
            button6.Text = "Make an Auto Transfer";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(795, 469);
            button7.Name = "button7";
            button7.Size = new Size(158, 29);
            button7.TabIndex = 10;
            button7.Text = "Add a profile picture";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(620, 434);
            button8.Name = "button8";
            button8.Size = new Size(169, 29);
            button8.TabIndex = 11;
            button8.Text = "Check Auto Transfers";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 510);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(TransferView);
            Controls.Add(button3);
            Controls.Add(AccountView);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountView).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransferView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private DataGridView AccountView;
        private Button button3;
        private DataGridView TransferView;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private Button button8;
    }
}