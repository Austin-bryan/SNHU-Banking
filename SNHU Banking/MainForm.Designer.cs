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
            savingsControl = new AccountCategoryControl();
            cdControl = new AccountCategoryControl();
            checkingControl = new AccountCategoryControl();
            label1 = new Label();
            accountsPanel = new FlowLayoutPanel();
            listBox = new ListBox();
            panel1 = new Panel();
            pieChartTotalLabel = new Label();
            pieChart1 = new PieChart();
            balancePreviewPanel = new FlowLayoutPanel();
            label4 = new Label();
            line2 = new Line();
            line1 = new Line();
            label3 = new Label();
            label2 = new Label();
            accountsPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // savingsControl
            // 
            savingsControl.BackColor = Color.FromArgb(40, 240, 40);
            savingsControl.Category = EAccountCategory.Savings;
            savingsControl.Location = new Point(3, 128);
            savingsControl.MainForm = null;
            savingsControl.Margin = new Padding(3, 3, 3, 20);
            savingsControl.Name = "savingsControl";
            savingsControl.Size = new Size(1401, 102);
            savingsControl.TabIndex = 0;
            // 
            // cdControl
            // 
            cdControl.BackColor = Color.FromArgb(220, 40, 50);
            cdControl.Category = EAccountCategory.CDs;
            cdControl.Location = new Point(3, 253);
            cdControl.MainForm = null;
            cdControl.Margin = new Padding(3, 3, 3, 20);
            cdControl.Name = "cdControl";
            cdControl.Size = new Size(1401, 102);
            cdControl.TabIndex = 1;
            // 
            // checkingControl
            // 
            checkingControl.BackColor = Color.FromArgb(75, 110, 255);
            checkingControl.Category = EAccountCategory.Checking;
            checkingControl.Location = new Point(3, 3);
            checkingControl.MainForm = null;
            checkingControl.Margin = new Padding(3, 3, 3, 20);
            checkingControl.Name = "checkingControl";
            checkingControl.Size = new Size(1401, 102);
            checkingControl.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 3;
            label1.Text = "Bank Accounts";
            // 
            // accountsPanel
            // 
            accountsPanel.AutoScroll = true;
            accountsPanel.BackColor = Color.FromArgb(40, 40, 40);
            accountsPanel.Controls.Add(checkingControl);
            accountsPanel.Controls.Add(savingsControl);
            accountsPanel.Controls.Add(cdControl);
            accountsPanel.Controls.Add(listBox);
            accountsPanel.Location = new Point(23, 79);
            accountsPanel.Name = "accountsPanel";
            accountsPanel.Size = new Size(1417, 896);
            accountsPanel.TabIndex = 4;
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(80, 80, 80);
            listBox.BorderStyle = BorderStyle.None;
            listBox.ForeColor = Color.White;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(3, 378);
            listBox.Name = "listBox";
            listBox.Size = new Size(120, 90);
            listBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.Controls.Add(pieChartTotalLabel);
            panel1.Controls.Add(pieChart1);
            panel1.Controls.Add(balancePreviewPanel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(line2);
            panel1.Controls.Add(line1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1446, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 592);
            panel1.TabIndex = 3;
            // 
            // pieChartTotalLabel
            // 
            pieChartTotalLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            pieChartTotalLabel.ForeColor = Color.White;
            pieChartTotalLabel.Location = new Point(88, 558);
            pieChartTotalLabel.Name = "pieChartTotalLabel";
            pieChartTotalLabel.Size = new Size(349, 25);
            pieChartTotalLabel.TabIndex = 8;
            pieChartTotalLabel.Text = "$0.00";
            pieChartTotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // pieChart1
            // 
            pieChart1.Location = new Point(13, 58);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(424, 320);
            pieChart1.TabIndex = 7;
            // 
            // balancePreviewPanel
            // 
            balancePreviewPanel.Location = new Point(13, 404);
            balancePreviewPanel.Name = "balancePreviewPanel";
            balancePreviewPanel.Size = new Size(424, 143);
            balancePreviewPanel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 558);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 2;
            label4.Text = "Total";
            // 
            // line2
            // 
            line2.Location = new Point(2, 553);
            line2.Name = "line2";
            line2.Size = new Size(448, 10);
            line2.TabIndex = 5;
            // 
            // line1
            // 
            line1.Location = new Point(3, 42);
            line1.Name = "line1";
            line1.Size = new Size(447, 10);
            line1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 378);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 1;
            label3.Text = "Bank Accounts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            Controls.Add(accountsPanel);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            accountsPanel.ResumeLayout(false);
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
        private PieChart pieChart1;
        private Label pieChartTotalLabel;
        private ListBox listBox;
    }
}
