namespace SNHU_Banking
{
    partial class TransactionControl
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
            transactionBalanceLabel = new Label();
            descriptionLabel = new Label();
            dateLabel = new Label();
            pictureBox1 = new PictureBox();
            amountLabel = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // transactionBalanceLabel
            // 
            transactionBalanceLabel.BackColor = Color.FromArgb(40, 40, 40);
            transactionBalanceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            transactionBalanceLabel.ForeColor = Color.White;
            transactionBalanceLabel.Location = new Point(660, 11);
            transactionBalanceLabel.Name = "transactionBalanceLabel";
            transactionBalanceLabel.Size = new Size(116, 15);
            transactionBalanceLabel.TabIndex = 17;
            transactionBalanceLabel.Text = "$720.00";
            transactionBalanceLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.FromArgb(40, 40, 40);
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Location = new Point(129, 11);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(174, 15);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description of the Transaction";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.FromArgb(40, 40, 40);
            dateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateLabel.ForeColor = Color.White;
            dateLabel.Location = new Point(10, 11);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(73, 15);
            dateLabel.TabIndex = 14;
            dateLabel.Text = "Mar 3, 2024";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(60, 60, 60);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(787, 36);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // amountLabel
            // 
            amountLabel.BackColor = Color.FromArgb(40, 40, 40);
            amountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            amountLabel.ForeColor = Color.FromArgb(40, 200, 40);
            amountLabel.Location = new Point(518, 11);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(136, 15);
            amountLabel.TabIndex = 18;
            amountLabel.Text = "+72.0";
            amountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(783, 32);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // TransactionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(amountLabel);
            Controls.Add(transactionBalanceLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(dateLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "TransactionControl";
            Size = new Size(787, 36);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label transactionBalanceLabel;
        private Label descriptionLabel;
        private Label dateLabel;
        private PictureBox pictureBox1;
        private Label amountLabel;
        private PictureBox pictureBox2;
    }
}
