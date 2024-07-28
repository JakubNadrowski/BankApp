namespace Bank
{
    partial class TransferMoney
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
            components = new System.ComponentModel.Container();
            recipientNum = new TextBox();
            Amounter = new TextBox();
            SenderLabel = new Label();
            RecipientLabel = new Label();
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            accountBindingSource = new BindingSource(components);
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            SuspendLayout();
            // 
            // recipientNum
            // 
            recipientNum.Location = new Point(318, 113);
            recipientNum.Name = "recipientNum";
            recipientNum.Size = new Size(125, 27);
            recipientNum.TabIndex = 1;
            // 
            // Amounter
            // 
            Amounter.Location = new Point(473, 113);
            Amounter.Name = "Amounter";
            Amounter.Size = new Size(125, 27);
            Amounter.TabIndex = 2;
            // 
            // SenderLabel
            // 
            SenderLabel.AutoSize = true;
            SenderLabel.Location = new Point(115, 90);
            SenderLabel.Name = "SenderLabel";
            SenderLabel.Size = new Size(96, 20);
            SenderLabel.TabIndex = 3;
            SenderLabel.Text = "Your Account";
            // 
            // RecipientLabel
            // 
            RecipientLabel.AutoSize = true;
            RecipientLabel.Location = new Point(318, 90);
            RecipientLabel.Name = "RecipientLabel";
            RecipientLabel.Size = new Size(71, 20);
            RecipientLabel.TabIndex = 4;
            RecipientLabel.Text = "Recipient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 90);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Money amount";
            // 
            // button1
            // 
            button1.Location = new Point(318, 280);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 6;
            button1.Text = "Transfer money";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(115, 113);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 44);
            listBox1.TabIndex = 7;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(Account);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(115, 198);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "AutoTransfer";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TransferMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(RecipientLabel);
            Controls.Add(SenderLabel);
            Controls.Add(Amounter);
            Controls.Add(recipientNum);
            Name = "TransferMoney";
            Text = "TransferMoney";
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox recipientNum;
        private TextBox Amounter;
        private Label SenderLabel;
        private Label RecipientLabel;
        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private BindingSource accountBindingSource;
        private CheckBox checkBox1;
    }
}