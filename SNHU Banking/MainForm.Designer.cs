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
            label1 = new Label();
            accountsPanel = new FlowLayoutPanel();
            accountCategoryControl1 = new AccountCategoryControl();
            accountCategoryControl2 = new AccountCategoryControl();
            accountCategoryControl3 = new AccountCategoryControl();
            transferPanel = new Panel();
            submitTransferPanel = new Panel();
            button1 = new Button();
            transferTB = new TextBox();
            amountLabel = new Label();
            errorLabel = new Label();
            toAccountBox = new LayeredComboBox();
            fromAccountBox = new LayeredComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            pieChart = new PieChart();
            pieChartTotalLabel = new Label();
            balancePreviewPanel = new FlowLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            accountsPanel.SuspendLayout();
            transferPanel.SuspendLayout();
            submitTransferPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(26, 2);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 3;
            label1.Text = "Bank Accounts";
            // 
            // accountsPanel
            // 
            accountsPanel.AutoScroll = true;
            accountsPanel.BackColor = Color.FromArgb(40, 40, 40);
            accountsPanel.Controls.Add(accountCategoryControl1);
            accountsPanel.Controls.Add(accountCategoryControl2);
            accountsPanel.Controls.Add(accountCategoryControl3);
            accountsPanel.Controls.Add(transferPanel);
            accountsPanel.Location = new Point(23, 39);
            accountsPanel.Name = "accountsPanel";
            accountsPanel.Size = new Size(1417, 896);
            accountsPanel.TabIndex = 4;
            // 
            // accountCategoryControl1
            // 
            accountCategoryControl1.BackColor = Color.FromArgb(75, 110, 255);
            accountCategoryControl1.Category = EAccountCategory.Checking;
            accountCategoryControl1.Location = new Point(3, 3);
            accountCategoryControl1.MainForm = null;
            accountCategoryControl1.Margin = new Padding(3, 3, 3, 10);
            accountCategoryControl1.Name = "accountCategoryControl1";
            accountCategoryControl1.Size = new Size(1399, 108);
            accountCategoryControl1.TabIndex = 0;
            // 
            // accountCategoryControl2
            // 
            accountCategoryControl2.BackColor = Color.FromArgb(40, 240, 40);
            accountCategoryControl2.Category = EAccountCategory.Savings;
            accountCategoryControl2.Location = new Point(3, 124);
            accountCategoryControl2.MainForm = null;
            accountCategoryControl2.Margin = new Padding(3, 3, 3, 10);
            accountCategoryControl2.Name = "accountCategoryControl2";
            accountCategoryControl2.Size = new Size(1399, 108);
            accountCategoryControl2.TabIndex = 1;
            // 
            // accountCategoryControl3
            // 
            accountCategoryControl3.BackColor = Color.FromArgb(220, 40, 50);
            accountCategoryControl3.Category = EAccountCategory.CDs;
            accountCategoryControl3.Location = new Point(3, 245);
            accountCategoryControl3.MainForm = null;
            accountCategoryControl3.Margin = new Padding(3, 3, 3, 10);
            accountCategoryControl3.Name = "accountCategoryControl3";
            accountCategoryControl3.Size = new Size(1399, 108);
            accountCategoryControl3.TabIndex = 2;
            // 
            // transferPanel
            // 
            transferPanel.BackColor = Color.FromArgb(60, 60, 60);
            transferPanel.Controls.Add(submitTransferPanel);
            transferPanel.Controls.Add(errorLabel);
            transferPanel.Controls.Add(toAccountBox);
            transferPanel.Controls.Add(fromAccountBox);
            transferPanel.Controls.Add(label6);
            transferPanel.Controls.Add(label7);
            transferPanel.Controls.Add(label8);
            transferPanel.Location = new Point(3, 366);
            transferPanel.Name = "transferPanel";
            transferPanel.Size = new Size(450, 229);
            transferPanel.TabIndex = 4;
            // 
            // submitTransferPanel
            // 
            submitTransferPanel.Controls.Add(button1);
            submitTransferPanel.Controls.Add(transferTB);
            submitTransferPanel.Controls.Add(amountLabel);
            submitTransferPanel.Location = new Point(15, 224);
            submitTransferPanel.Name = "submitTransferPanel";
            submitTransferPanel.Size = new Size(415, 117);
            submitTransferPanel.TabIndex = 12;
            submitTransferPanel.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 140, 45);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 65);
            button1.Name = "button1";
            button1.Size = new Size(204, 40);
            button1.TabIndex = 15;
            button1.Text = "Submit Transfer";
            button1.UseVisualStyleBackColor = false;
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
            errorLabel.Size = new Size(324, 20);
            errorLabel.TabIndex = 11;
            errorLabel.Text = "  Cannot transfer betweent the same account";
            errorLabel.Visible = false;
            // 
            // toAccountBox
            // 
            toAccountBox.DefaultItem = "      Select an Account";
            toAccountBox.Location = new Point(13, 163);
            toAccountBox.Name = "toAccountBox";
            toAccountBox.Size = new Size(417, 53);
            toAccountBox.TabIndex = 10;
            // 
            // fromAccountBox
            // 
            fromAccountBox.DefaultItem = "      Select an Account";
            fromAccountBox.Location = new Point(13, 78);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.Controls.Add(pieChart);
            panel1.Controls.Add(pieChartTotalLabel);
            panel1.Controls.Add(balancePreviewPanel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1446, 39);
            panel1.Margin = new Padding(3, 3, 3, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 527);
            panel1.TabIndex = 3;
            // 
            // pieChart
            // 
            pieChart.Location = new Point(88, 42);
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
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1643, 1061);
            Controls.Add(panel1);
            Controls.Add(accountsPanel);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            accountsPanel.ResumeLayout(false);
            transferPanel.ResumeLayout(false);
            transferPanel.PerformLayout();
            submitTransferPanel.ResumeLayout(false);
            submitTransferPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AccountCategoryControl savingsControl;
        private AccountCategoryControl cdControl;
        private AccountCategoryControl checkingControl;
        private Label label1;
        private FlowLayoutPanel accountsPanel;
        private Panel panel1;
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
        private AccountCategoryControl accountCategoryControl1;
        private AccountCategoryControl accountCategoryControl2;
        private AccountCategoryControl accountCategoryControl3;
        private Label errorLabel;
        private Panel submitTransferPanel;
        private Button button1;
        private TextBox transferTB;
        private Label amountLabel;
    }
}
