namespace SNHU_Banking
{
    partial class AccountPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            yieldLabel = new Label();
            ytdLabel = new Label();
            balanceLabel = new Label();
            yieldUILabel = new Label();
            ytdUILabel = new Label();
            balanceUILabel = new Label();
            nameLabel = new Label();
            transactionLabel = new Label();
            pictureBox1 = new PictureBox();
            dateLabel = new Label();
            descriptionLabel = new Label();
            amountLabel = new Label();
            transactionBalanceLabel = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(200, 40, 40);
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 73);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(yieldLabel);
            panel2.Controls.Add(ytdLabel);
            panel2.Controls.Add(balanceLabel);
            panel2.Controls.Add(yieldUILabel);
            panel2.Controls.Add(ytdUILabel);
            panel2.Controls.Add(balanceUILabel);
            panel2.Controls.Add(nameLabel);
            panel2.Location = new Point(20, 11);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 70);
            panel2.TabIndex = 1;
            // 
            // yieldLabel
            // 
            yieldLabel.Font = new Font("Segoe UI", 10F);
            yieldLabel.ForeColor = Color.White;
            yieldLabel.Location = new Point(647, 35);
            yieldLabel.Name = "yieldLabel";
            yieldLabel.Size = new Size(109, 19);
            yieldLabel.TabIndex = 6;
            yieldLabel.Text = "72.2%";
            yieldLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ytdLabel
            // 
            ytdLabel.Font = new Font("Segoe UI", 10F);
            ytdLabel.ForeColor = Color.White;
            ytdLabel.Location = new Point(452, 35);
            ytdLabel.Name = "ytdLabel";
            ytdLabel.Size = new Size(109, 19);
            ytdLabel.TabIndex = 5;
            ytdLabel.Text = "$720";
            ytdLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // balanceLabel
            // 
            balanceLabel.Font = new Font("Segoe UI", 10F);
            balanceLabel.ForeColor = Color.White;
            balanceLabel.Location = new Point(309, 35);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(109, 19);
            balanceLabel.TabIndex = 4;
            balanceLabel.Text = "$720";
            balanceLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // yieldUILabel
            // 
            yieldUILabel.AutoSize = true;
            yieldUILabel.Font = new Font("Segoe UI", 10F);
            yieldUILabel.ForeColor = Color.White;
            yieldUILabel.Location = new Point(622, 16);
            yieldUILabel.Name = "yieldUILabel";
            yieldUILabel.Size = new Size(134, 19);
            yieldUILabel.TabIndex = 3;
            yieldUILabel.Text = "Annual Percent Yield";
            // 
            // ytdUILabel
            // 
            ytdUILabel.AutoSize = true;
            ytdUILabel.Font = new Font("Segoe UI", 10F);
            ytdUILabel.ForeColor = Color.White;
            ytdUILabel.Location = new Point(476, 16);
            ytdUILabel.Name = "ytdUILabel";
            ytdUILabel.Size = new Size(85, 19);
            ytdUILabel.TabIndex = 2;
            ytdUILabel.Text = "Interest YTD";
            // 
            // balanceUILabel
            // 
            balanceUILabel.AutoSize = true;
            balanceUILabel.Font = new Font("Segoe UI", 10F);
            balanceUILabel.ForeColor = Color.White;
            balanceUILabel.Location = new Point(309, 16);
            balanceUILabel.Name = "balanceUILabel";
            balanceUILabel.Size = new Size(109, 19);
            balanceUILabel.TabIndex = 1;
            balanceUILabel.Text = "Account Balance";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 20F);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(13, 2);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(191, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Account Name";
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Font = new Font("Segoe UI", 15F);
            transactionLabel.ForeColor = Color.White;
            transactionLabel.Location = new Point(10, 127);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new Size(178, 28);
            transactionLabel.TabIndex = 7;
            transactionLabel.Text = "Transaction History";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(60, 60, 60);
            pictureBox1.Location = new Point(10, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(787, 36);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.FromArgb(60, 60, 60);
            dateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateLabel.ForeColor = Color.White;
            dateLabel.Location = new Point(20, 169);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(34, 15);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.FromArgb(60, 60, 60);
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Location = new Point(139, 169);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(71, 15);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.BackColor = Color.FromArgb(60, 60, 60);
            amountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            amountLabel.ForeColor = Color.White;
            amountLabel.Location = new Point(642, 169);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(52, 15);
            amountLabel.TabIndex = 11;
            amountLabel.Text = "Amount";
            // 
            // transactionBalanceLabel
            // 
            transactionBalanceLabel.AutoSize = true;
            transactionBalanceLabel.BackColor = Color.FromArgb(60, 60, 60);
            transactionBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            transactionBalanceLabel.ForeColor = Color.White;
            transactionBalanceLabel.Location = new Point(726, 169);
            transactionBalanceLabel.Name = "transactionBalanceLabel";
            transactionBalanceLabel.Size = new Size(50, 15);
            transactionBalanceLabel.TabIndex = 12;
            transactionBalanceLabel.Text = "Balance";
            // 
            // AccountPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(transactionBalanceLabel);
            Controls.Add(amountLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(dateLabel);
            Controls.Add(pictureBox1);
            Controls.Add(transactionLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AccountPage";
            Size = new Size(809, 800);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label nameLabel;
        private Label yieldLabel;
        private Label ytdLabel;
        private Label balanceLabel;
        private Label yieldUILabel;
        private Label ytdUILabel;
        private Label balanceUILabel;
        private Label transactionLabel;
        private PictureBox pictureBox1;
        private Label dateLabel;
        private Label descriptionLabel;
        private Label amountLabel;
        private Label transactionBalanceLabel;
    }
}
