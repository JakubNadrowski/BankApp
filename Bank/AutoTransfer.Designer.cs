namespace Bank
{
    partial class AutoTransfer
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            recipientNum = new TextBox();
            Amount = new TextBox();
            button1 = new Button();
            AoT = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 87);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Frequency";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Monthly", "Weekly", "Daily" });
            listBox1.Location = new Point(84, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 64);
            listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(263, 110);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 87);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 4;
            label2.Text = "Sender Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 87);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Recipient";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 87);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Amount";
            // 
            // recipientNum
            // 
            recipientNum.Location = new Point(439, 110);
            recipientNum.Name = "recipientNum";
            recipientNum.Size = new Size(125, 27);
            recipientNum.TabIndex = 7;
            // 
            // Amount
            // 
            Amount.Location = new Point(581, 110);
            Amount.Name = "Amount";
            Amount.Size = new Size(125, 27);
            Amount.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(320, 303);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 9;
            button1.Text = "Create AutoTransfer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AoT
            // 
            AoT.Location = new Point(439, 187);
            AoT.Name = "AoT";
            AoT.Size = new Size(125, 27);
            AoT.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 164);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 11;
            label5.Text = "Amount Of Transfers";
            // 
            // AutoTransfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(AoT);
            Controls.Add(button1);
            Controls.Add(Amount);
            Controls.Add(recipientNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "AutoTransfer";
            Text = "AutoTransfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox recipientNum;
        private TextBox Amount;
        private Button button1;
        private TextBox AoT;
        private Label label5;
    }
}