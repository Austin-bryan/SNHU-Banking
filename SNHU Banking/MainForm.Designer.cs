namespace SNHU_Banking
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bankAccountsLabel = new Label();
            accountsPanel = new FlowLayoutPanel();
            checkingControl = new AccountCategoryControl();
            savingsControl = new AccountCategoryControl();
            cdControl = new AccountCategoryControl();
            transferPanel = new Panel();
            submitTransferPanel = new Panel();
            submitTransferButton = new Button();
            transferTB = new TextBox();
            amountLabel = new Label();
            errorLabel = new Label();
            toAccountBox = new LayeredComboBox();
            fromAccountBox = new LayeredComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pieChartPanel = new Panel();
            pieChart = new PieChart();
            pieChartTotalLabel = new Label();
            balancePreviewPanel = new FlowLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            accountsPanel.SuspendLayout();
            transferPanel.SuspendLayout();
            submitTransferPanel.SuspendLayout();
            pieChartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bankAccountsLabel
            // 
            bankAccountsLabel.AutoSize = true;
            bankAccountsLabel.Font = new Font("Segoe UI", 15F);
            bankAccountsLabel.ForeColor = SystemColors.ButtonFace;
            bankAccountsLabel.Location = new Point(3, 0);
            bankAccountsLabel.Name = "bankAccountsLabel";
            bankAccountsLabel.Size = new Size(139, 28);
            bankAccountsLabel.TabIndex = 3;
            bankAccountsLabel.Text = "Bank Accounts";
            // 
            // accountsPanel
            // 
            accountsPanel.AutoScroll = true;
            accountsPanel.BackColor = Color.FromArgb(30, 30, 30);
            accountsPanel.Controls.Add(bankAccountsLabel);
            accountsPanel.Controls.Add(checkingControl);
            accountsPanel.Controls.Add(savingsControl);
            accountsPanel.Controls.Add(cdControl);
            accountsPanel.Location = new Point(12, 11);
            accountsPanel.Margin = new Padding(3, 2, 3, 2);
            accountsPanel.Name = "accountsPanel";
            accountsPanel.Size = new Size(1417, 896);
            accountsPanel.TabIndex = 4;
            // 
            // checkingControl
            // 
            checkingControl.BackColor = Color.FromArgb(75, 110, 255);
            checkingControl.Category = EAccountCategory.Checking;
            checkingControl.Location = new Point(3, 31);
            checkingControl.Margin = new Padding(3, 3, 3, 10);
            checkingControl.Name = "checkingControl";
            checkingControl.Size = new Size(1399, 108);
            checkingControl.TabIndex = 0;
            // 
            // savingsControl
            // 
            savingsControl.BackColor = Color.FromArgb(40, 240, 40);
            savingsControl.Category = EAccountCategory.Savings;
            savingsControl.Location = new Point(3, 152);
            savingsControl.Margin = new Padding(3, 3, 3, 10);
            savingsControl.Name = "savingsControl";
            savingsControl.Size = new Size(1399, 108);
            savingsControl.TabIndex = 1;
            // 
            // cdControl
            // 
            cdControl.BackColor = Color.FromArgb(220, 40, 50);
            cdControl.Category = EAccountCategory.CDs;
            cdControl.Location = new Point(3, 273);
            cdControl.Margin = new Padding(3, 3, 3, 10);
            cdControl.Name = "cdControl";
            cdControl.Size = new Size(1399, 108);
            cdControl.TabIndex = 2;
            // 
            // transferPanel
            // 
            transferPanel.BackColor = Color.FromArgb(50, 50, 50);
            transferPanel.Controls.Add(submitTransferPanel);
            transferPanel.Controls.Add(errorLabel);
            transferPanel.Controls.Add(toAccountBox);
            transferPanel.Controls.Add(fromAccountBox);
            transferPanel.Controls.Add(label6);
            transferPanel.Controls.Add(label7);
            transferPanel.Controls.Add(label8);
            transferPanel.Location = new Point(1435, 589);
            transferPanel.Margin = new Padding(3, 2, 3, 2);
            transferPanel.Name = "transferPanel";
            transferPanel.Size = new Size(450, 349);
            transferPanel.TabIndex = 4;
            // 
            // submitTransferPanel
            // 
            submitTransferPanel.Controls.Add(submitTransferButton);
            submitTransferPanel.Controls.Add(transferTB);
            submitTransferPanel.Controls.Add(amountLabel);
            submitTransferPanel.Location = new Point(13, 224);
            submitTransferPanel.Name = "submitTransferPanel";
            submitTransferPanel.Size = new Size(415, 117);
            submitTransferPanel.TabIndex = 12;
            submitTransferPanel.Visible = false;
            // 
            // submitTransferButton
            // 
            submitTransferButton.BackColor = Color.FromArgb(30, 140, 45);
            submitTransferButton.FlatAppearance.BorderSize = 0;
            submitTransferButton.FlatStyle = FlatStyle.Flat;
            submitTransferButton.ForeColor = Color.White;
            submitTransferButton.Location = new Point(0, 65);
            submitTransferButton.Name = "submitTransferButton";
            submitTransferButton.Size = new Size(204, 40);
            submitTransferButton.TabIndex = 15;
            submitTransferButton.Text = "Submit Transfer";
            submitTransferButton.UseVisualStyleBackColor = false;
            submitTransferButton.Click += submitTransferButton_Click;
            // 
            // transferTB
            // 
            transferTB.BackColor = Color.FromArgb(40, 40, 40);
            transferTB.BorderStyle = BorderStyle.None;
            transferTB.Font = new Font("Segoe UI", 15F);
            transferTB.ForeColor = Color.White;
            transferTB.Location = new Point(1, 30);
            transferTB.Margin = new Padding(3, 3, 3, 5);
            transferTB.Name = "transferTB";
            transferTB.Size = new Size(414, 27);
            transferTB.TabIndex = 14;
            transferTB.KeyDown += transferTB_KeyDown;
            transferTB.KeyPress += transferTB_KeyPress;
            transferTB.Leave += transferTB_Leave;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 11F);
            amountLabel.ForeColor = Color.White;
            amountLabel.Location = new Point(0, 2);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(62, 20);
            amountLabel.TabIndex = 13;
            amountLabel.Text = "Amount";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.Red;
            errorLabel.FlatStyle = FlatStyle.System;
            errorLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            errorLabel.ForeColor = Color.White;
            errorLabel.Location = new Point(16, 224);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(351, 20);
            errorLabel.TabIndex = 11;
            errorLabel.Text = "To Account cannot be the same as From Account";
            errorLabel.Visible = false;
            // 
            // toAccountBox
            // 
            toAccountBox.DefaultItem = "      Select an Account";
            toAccountBox.Location = new Point(13, 163);
            toAccountBox.Margin = new Padding(3, 4, 3, 4);
            toAccountBox.Name = "toAccountBox";
            toAccountBox.Size = new Size(417, 53);
            toAccountBox.TabIndex = 10;
            // 
            // fromAccountBox
            // 
            fromAccountBox.DefaultItem = "      Select an Account";
            fromAccountBox.Location = new Point(13, 78);
            fromAccountBox.Margin = new Padding(3, 4, 3, 4);
            fromAccountBox.Name = "fromAccountBox";
            fromAccountBox.Size = new Size(417, 53);
            fromAccountBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 140);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 8;
            label6.Text = "To Account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 55);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 1;
            label7.Text = "From Account";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 14);
            label8.Name = "label8";
            label8.Size = new Size(202, 25);
            label8.TabIndex = 0;
            label8.Text = "Make One Time Transfer";
            // 
            // pieChartPanel
            // 
            pieChartPanel.BackColor = Color.FromArgb(50, 50, 50);
            pieChartPanel.Controls.Add(pieChart);
            pieChartPanel.Controls.Add(pieChartTotalLabel);
            pieChartPanel.Controls.Add(balancePreviewPanel);
            pieChartPanel.Controls.Add(label4);
            pieChartPanel.Controls.Add(label3);
            pieChartPanel.Controls.Add(label2);
            pieChartPanel.Location = new Point(1435, 42);
            pieChartPanel.Margin = new Padding(3, 2, 3, 8);
            pieChartPanel.Name = "pieChartPanel";
            pieChartPanel.Size = new Size(450, 526);
            pieChartPanel.TabIndex = 3;
            // 
            // pieChart
            // 
            pieChart.Location = new Point(88, 43);
            pieChart.Margin = new Padding(3, 4, 3, 4);
            pieChart.Name = "pieChart";
            pieChart.Size = new Size(280, 280);
            pieChart.TabIndex = 9;
            // 
            // pieChartTotalLabel
            // 
            pieChartTotalLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            pieChartTotalLabel.ForeColor = Color.White;
            pieChartTotalLabel.Location = new Point(88, 493);
            pieChartTotalLabel.Name = "pieChartTotalLabel";
            pieChartTotalLabel.Size = new Size(349, 25);
            pieChartTotalLabel.TabIndex = 8;
            pieChartTotalLabel.Text = "$0.00";
            pieChartTotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // balancePreviewPanel
            // 
            balancePreviewPanel.Location = new Point(13, 347);
            balancePreviewPanel.Name = "balancePreviewPanel";
            balancePreviewPanel.Size = new Size(424, 143);
            balancePreviewPanel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 493);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 2;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 321);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 1;
            label3.Text = "Bank Accounts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 14);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 0;
            label2.Text = "Accounts Overview";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1924, 929);
            Controls.Add(pieChartPanel);
            Controls.Add(accountsPanel);
            Controls.Add(transferPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            accountsPanel.ResumeLayout(false);
            accountsPanel.PerformLayout();
            transferPanel.ResumeLayout(false);
            transferPanel.PerformLayout();
            submitTransferPanel.ResumeLayout(false);
            submitTransferPanel.PerformLayout();
            pieChartPanel.ResumeLayout(false);
            pieChartPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label bankAccountsLabel;
        private FlowLayoutPanel accountsPanel;
        private Panel pieChartPanel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Line line1;
        private Line line2;
        private FlowLayoutPanel balancePreviewPanel;
        private PieChart pieChart;
        private Label pieChartTotalLabel;
        private Panel transferPanel;
        private Line line4;
        private Label label7;
        private Label label8;
        private LayeredComboBox fromAccountBox;
        private LayeredComboBox toAccountBox;
        private Label label6;
        private AccountCategoryControl checkingControl;
        private AccountCategoryControl savingsControl;
        private AccountCategoryControl cdControl;
        private Label errorLabel;
        private Panel submitTransferPanel;
        private Button submitTransferButton;
        private TextBox transferTB;
        private Label amountLabel;
    }
}
