namespace Bank
{
    partial class AddBalance
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
            button1 = new Button();
            amount = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Account";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(284, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 64);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(304, 232);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 2;
            button1.Text = "Add balance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // amount
            // 
            amount.Location = new Point(284, 189);
            amount.Name = "amount";
            amount.Size = new Size(125, 27);
            amount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 166);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 4;
            label2.Text = "Amount to add";
            // 
            // AddBalance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(amount);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "AddBalance";
            Text = "AddBalance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private TextBox amount;
        private Label label2;
    }
}