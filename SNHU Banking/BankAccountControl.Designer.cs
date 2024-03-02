namespace SNHU_Banking;

partial class BankAccountControl
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
        tableLayoutPanel1 = new TableLayoutPanel();
        interestLabel = new Label();
        ytdLabel = new Label();
        balanceLabel = new Label();
        nameLabel = new Label();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = Color.FromArgb(50, 50, 50);
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.14372F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9266338F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9648228F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9648228F));
        tableLayoutPanel1.Controls.Add(interestLabel, 3, 0);
        tableLayoutPanel1.Controls.Add(ytdLabel, 2, 0);
        tableLayoutPanel1.Controls.Add(balanceLabel, 1, 0);
        tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(1344, 14);
        tableLayoutPanel1.TabIndex = 7;
        // 
        // interestLabel
        // 
        interestLabel.AutoSize = true;
        interestLabel.BackColor = Color.FromArgb(50, 50, 50);
        interestLabel.Font = new Font("Segoe UI", 9F);
        interestLabel.ForeColor = SystemColors.ButtonFace;
        interestLabel.Location = new Point(1051, 0);
        interestLabel.Name = "interestLabel";
        interestLabel.Size = new Size(38, 14);
        interestLabel.TabIndex = 5;
        interestLabel.Text = "0.72%";
        // 
        // ytdLabel
        // 
        ytdLabel.AutoSize = true;
        ytdLabel.BackColor = Color.FromArgb(50, 50, 50);
        ytdLabel.Font = new Font("Segoe UI", 9F);
        ytdLabel.ForeColor = SystemColors.ButtonFace;
        ytdLabel.Location = new Point(756, 0);
        ytdLabel.Name = "ytdLabel";
        ytdLabel.Size = new Size(28, 14);
        ytdLabel.TabIndex = 4;
        ytdLabel.Text = "$7.2";
        ytdLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // balanceLabel
        // 
        balanceLabel.AutoSize = true;
        balanceLabel.BackColor = Color.FromArgb(50, 50, 50);
        balanceLabel.Font = new Font("Segoe UI", 9F);
        balanceLabel.ForeColor = SystemColors.ButtonFace;
        balanceLabel.Location = new Point(475, 0);
        balanceLabel.Name = "balanceLabel";
        balanceLabel.Size = new Size(31, 14);
        balanceLabel.TabIndex = 3;
        balanceLabel.Text = "$720";
        balanceLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.BackColor = Color.FromArgb(50, 50, 50);
        nameLabel.Cursor = Cursors.Hand;
        nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        nameLabel.ForeColor = SystemColors.MenuHighlight;
        nameLabel.Location = new Point(3, 0);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(91, 14);
        nameLabel.TabIndex = 2;
        nameLabel.Text = "Online Banking";
        nameLabel.TextAlign = ContentAlignment.TopCenter;
        nameLabel.Click += nameLabel_Click;
        // 
        // BankAccountControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSkyBlue;
        Controls.Add(tableLayoutPanel1);
        Name = "BankAccountControl";
        Size = new Size(1335, 14);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TableLayoutPanel tableLayoutPanel1;
    private Label interestLabel;
    private Label ytdLabel;
    private Label balanceLabel;
    private Label nameLabel;
}
