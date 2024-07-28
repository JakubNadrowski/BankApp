namespace Bank
{
    partial class Form2
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
            NewPassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // NewPassword
            // 
            NewPassword.Location = new Point(335, 199);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(125, 27);
            NewPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 164);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Type in new Password";
            // 
            // button1
            // 
            button1.Location = new Point(349, 249);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "ChangePass";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(NewPassword);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewPassword;
        private Label label1;
        private Button button1;
    }
}