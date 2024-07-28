namespace Bank
{
    partial class CreateAccount
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
            AccNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            AccName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // AccNum
            // 
            AccNum.Location = new Point(326, 141);
            AccNum.Name = "AccNum";
            AccNum.Size = new Size(125, 27);
            AccNum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 93);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Account Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 118);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 2;
            label2.Text = "(Max 9 numbers)";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(338, 253);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AccName
            // 
            AccName.Location = new Point(326, 204);
            AccName.Name = "AccName";
            AccName.Size = new Size(125, 27);
            AccName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 181);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Account Name";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(AccName);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AccNum);
            Name = "CreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AccNum;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox AccName;
        private Label label3;
    }
}