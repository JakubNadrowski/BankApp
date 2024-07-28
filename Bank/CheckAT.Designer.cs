namespace Bank
{
    partial class CheckAT
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
            ATView = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ATView).BeginInit();
            SuspendLayout();
            // 
            // ATView
            // 
            ATView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ATView.Location = new Point(0, 0);
            ATView.Name = "ATView";
            ATView.RowHeadersWidth = 51;
            ATView.RowTemplate.Height = 29;
            ATView.Size = new Size(801, 388);
            ATView.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(351, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Go back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CheckAT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ATView);
            Name = "CheckAT";
            Text = "CheckAT";
            ((System.ComponentModel.ISupportInitialize)ATView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ATView;
        private Button button1;
    }
}