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
            panel2 = new Panel();
            layeredComboBox1 = new LayeredComboBox();
            label5 = new Label();
            line4 = new Line();
            label7 = new Label();
            listBox = new ListBox();
            label8 = new Label();
            panel1 = new Panel();
            pieChartTotalLabel = new Label();
            pieChart1 = new PieChart();
            balancePreviewPanel = new FlowLayoutPanel();
            label4 = new Label();
            line2 = new Line();
            line1 = new Line();
            label3 = new Label();
            label2 = new Label();
            layeredComboBox2 = new LayeredComboBox();
            label6 = new Label();
            accountsPanel.SuspendLayout();
            panel2.SuspendLayout();
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
            accountsPanel.Controls.Add(panel2);
            accountsPanel.Location = new Point(23, 79);
            accountsPanel.Name = "accountsPanel";
            accountsPanel.Size = new Size(1417, 896);
            accountsPanel.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 60, 60);
            panel2.Controls.Add(layeredComboBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(layeredComboBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(line4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(listBox);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(3, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 253);
            panel2.TabIndex = 4;
            // 
            // layeredComboBox1
            // 
            layeredComboBox1.Location = new Point(13, 78);
            layeredComboBox1.Name = "layeredComboBox1";
            layeredComboBox1.Size = new Size(418, 174);
            layeredComboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 175);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 5;
            label5.Text = "To Account";
            // 
            // line4
            // 
            line4.Location = new Point(3, 42);
            line4.Name = "line4";
            line4.Size = new Size(447, 10);
            line4.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 55);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 1;
            label7.Text = "From Account";
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(80, 80, 80);
            listBox.BorderStyle = BorderStyle.None;
            listBox.ForeColor = Color.White;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(13, 79);
            listBox.Name = "listBox";
            listBox.Size = new Size(418, 120);
            listBox.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
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
            // layeredComboBox2
            // 
            layeredComboBox2.Location = new Point(13, 180);
            layeredComboBox2.Name = "layeredComboBox2";
            layeredComboBox2.Size = new Size(418, 174);
            layeredComboBox2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 157);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 8;
            label6.Text = "To Account";
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Line line4;
        private Label label7;
        private Label label8;
        private Label label5;
        private LayeredComboBox layeredComboBox1;
        private LayeredComboBox layeredComboBox2;
        private Label label6;
    }
}
