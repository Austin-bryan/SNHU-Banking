namespace SNHU_Banking
{
    partial class NewAccountForm
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
            mainLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            balanceTextBox = new TextBox();
            startBalanceLabel = new Label();
            accountLabel = new Label();
            submitButton = new Button();
            backgroundPanel = new PictureBox();
            sideBackground = new PictureBox();
            accountTypeBox = new LayeredComboBox();
            ((System.ComponentModel.ISupportInitialize)backgroundPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sideBackground).BeginInit();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.BackColor = Color.FromArgb(30, 30, 30);
            mainLabel.Font = new Font("Segoe UI", 14F);
            mainLabel.ForeColor = SystemColors.ButtonFace;
            mainLabel.Location = new Point(12, 9);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(224, 25);
            mainLabel.TabIndex = 4;
            mainLabel.Text = "Create Checking Account";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.FromArgb(40, 40, 100);
            nameLabel.Font = new Font("Segoe UI", 9F);
            nameLabel.ForeColor = SystemColors.ButtonFace;
            nameLabel.Location = new Point(68, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 15);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "* Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(50, 50, 50);
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(126, 90);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 23);
            nameTextBox.TabIndex = 4;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            // 
            // balanceTextBox
            // 
            balanceTextBox.BackColor = Color.FromArgb(50, 50, 50);
            balanceTextBox.BorderStyle = BorderStyle.FixedSingle;
            balanceTextBox.ForeColor = Color.White;
            balanceTextBox.Location = new Point(126, 122);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(182, 23);
            balanceTextBox.TabIndex = 1;
            balanceTextBox.Text = "0.00";
            balanceTextBox.KeyDown += balanceTextBox_KeyDown;
            balanceTextBox.KeyPress += balanceTextBox_KeyPress;
            balanceTextBox.Leave += balanceTextBox_Leave;
            // 
            // startBalanceLabel
            // 
            startBalanceLabel.AutoSize = true;
            startBalanceLabel.BackColor = Color.FromArgb(40, 40, 100);
            startBalanceLabel.Font = new Font("Segoe UI", 9F);
            startBalanceLabel.ForeColor = SystemColors.ButtonFace;
            startBalanceLabel.Location = new Point(15, 124);
            startBalanceLabel.Name = "startBalanceLabel";
            startBalanceLabel.Size = new Size(104, 15);
            startBalanceLabel.TabIndex = 8;
            startBalanceLabel.Text = "Starting Balance: $";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.BackColor = Color.FromArgb(40, 40, 100);
            accountLabel.Font = new Font("Segoe UI", 9F);
            accountLabel.ForeColor = SystemColors.ButtonFace;
            accountLabel.Location = new Point(36, 60);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(82, 15);
            accountLabel.TabIndex = 9;
            accountLabel.Text = "Account Type:";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(60, 60, 60);
            submitButton.Enabled = false;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.ForeColor = Color.Black;
            submitButton.Location = new Point(346, 284);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(106, 37);
            submitButton.TabIndex = 2;
            submitButton.Text = "Open Account";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.FromArgb(20, 20, 20);
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(4039, 44);
            backgroundPanel.TabIndex = 11;
            backgroundPanel.TabStop = false;
            // 
            // sideBackground
            // 
            sideBackground.BackColor = Color.FromArgb(40, 40, 100);
            sideBackground.Location = new Point(0, 0);
            sideBackground.Name = "sideBackground";
            sideBackground.Size = new Size(120, 2000);
            sideBackground.TabIndex = 12;
            sideBackground.TabStop = false;
            // 
            // accountTypeBox
            // 
            accountTypeBox.DefaultItem = "      Pick an Item";
            accountTypeBox.Location = new Point(126, 50);
            accountTypeBox.Name = "accountTypeBox";
            accountTypeBox.Size = new Size(182, 34);
            accountTypeBox.TabIndex = 13;
            // 
            // NewAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(464, 333);
            Controls.Add(accountTypeBox);
            Controls.Add(submitButton);
            Controls.Add(accountLabel);
            Controls.Add(startBalanceLabel);
            Controls.Add(balanceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(mainLabel);
            Controls.Add(backgroundPanel);
            Controls.Add(sideBackground);
            Name = "NewAccountForm";
            ((System.ComponentModel.ISupportInitialize)backgroundPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)sideBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mainLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox balanceTextBox;
        private Label startBalanceLabel;
        private Label accountLabel;
        private Button submitButton;
        private PictureBox backgroundPanel;
        private PictureBox sideBackground;
        private LayeredComboBox accountTypeBox;
    }
}