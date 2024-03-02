namespace SNHU_Banking
{
    partial class BalancePreview
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
            colorSplash = new PictureBox();
            accountLabel = new Label();
            balanceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)colorSplash).BeginInit();
            SuspendLayout();
            // 
            // colorSplash
            // 
            colorSplash.BackColor = SystemColors.ActiveCaption;
            colorSplash.Location = new Point(0, 0);
            colorSplash.Name = "colorSplash";
            colorSplash.Size = new Size(12, 38);
            colorSplash.TabIndex = 0;
            colorSplash.TabStop = false;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.ForeColor = Color.White;
            accountLabel.Location = new Point(18, 11);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(39, 15);
            accountLabel.TabIndex = 1;
            accountLabel.Text = "Name";
            // 
            // balanceLabel
            // 
            balanceLabel.BackColor = Color.FromArgb(50, 50, 50);
            balanceLabel.ForeColor = Color.White;
            balanceLabel.Location = new Point(277, 11);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(135, 15);
            balanceLabel.TabIndex = 2;
            balanceLabel.Text = "$720";
            balanceLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // BalancePreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(balanceLabel);
            Controls.Add(accountLabel);
            Controls.Add(colorSplash);
            Name = "BalancePreview";
            Size = new Size(415, 38);
            ((System.ComponentModel.ISupportInitialize)colorSplash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox colorSplash;
        private Label accountLabel;
        private Label balanceLabel;
    }
}
