namespace SNHU_Banking
{
    partial class LayeredComboBox
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
            mainButton = new Button();
            sideBar = new PictureBox();
            listBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)sideBar).BeginInit();
            SuspendLayout();
            // 
            // mainButton
            // 
            mainButton.BackColor = Color.FromArgb(70, 70, 70);
            mainButton.FlatAppearance.BorderColor = Color.Black;
            mainButton.FlatStyle = FlatStyle.Flat;
            mainButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            mainButton.ForeColor = Color.White;
            mainButton.Location = new Point(0, 0);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(417, 50);
            mainButton.TabIndex = 0;
            mainButton.Text = "     Select an Account";
            mainButton.TextAlign = ContentAlignment.MiddleLeft;
            mainButton.UseVisualStyleBackColor = false;
            mainButton.Click += mainButton_Click;
            mainButton.Paint += mainButton_Paint;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(50, 50, 50);
            sideBar.Enabled = false;
            sideBar.Location = new Point(5, 5);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(7, 40);
            sideBar.TabIndex = 1;
            sideBar.TabStop = false;
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(70, 70, 70);
            listBox.BorderStyle = BorderStyle.None;
            listBox.ForeColor = Color.White;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(2, 53);
            listBox.Name = "listBox";
            listBox.Size = new Size(347, 105);
            listBox.TabIndex = 2;
            listBox.Visible = false;
            listBox.MouseDown += listBox_MouseDown;
            listBox.MouseMove += listBox_MouseMove;
            // 
            // LayeredComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox);
            Controls.Add(sideBar);
            Controls.Add(mainButton);
            Name = "LayeredComboBox";
            Size = new Size(417, 136);
            Leave += LayeredComboBox_Leave;
            ((System.ComponentModel.ISupportInitialize)sideBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mainButton;
        private PictureBox sideBar;
        private ListBox listBox;
    }
}
