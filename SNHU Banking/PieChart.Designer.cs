namespace SNHU_Banking;

partial class PieChart
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
        noAccountsLabel = new Label();
        SuspendLayout();
        // 
        // noAccountsLabel
        // 
        noAccountsLabel.AutoSize = true;
        noAccountsLabel.Font = new Font("Segoe UI", 15F);
        noAccountsLabel.ForeColor = Color.White;
        noAccountsLabel.Location = new Point(49, 124);
        noAccountsLabel.Name = "noAccountsLabel";
        noAccountsLabel.Size = new Size(197, 28);
        noAccountsLabel.TabIndex = 0;
        noAccountsLabel.Text = "No Accounts Created";
        // 
        // PieChart
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(noAccountsLabel);
        Name = "PieChart";
        Size = new Size(427, 394);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label noAccountsLabel;
}
