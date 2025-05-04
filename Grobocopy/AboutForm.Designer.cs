namespace Grobocopy
{
    partial class AboutForm
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
            lblDescription = new Label();
            lnkGithub = new LinkLabel();
            picCoffee = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picCoffee).BeginInit();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(33, 9);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(196, 45);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Grobocopy v0.7\r\nA simple GUI for Robocopy\r\nCopyright (c) 2025 Dan MacCormac";
            // 
            // lnkGithub
            // 
            lnkGithub.AutoSize = true;
            lnkGithub.Location = new Point(86, 68);
            lnkGithub.Name = "lnkGithub";
            lnkGithub.Size = new Size(90, 15);
            lnkGithub.TabIndex = 1;
            lnkGithub.TabStop = true;
            lnkGithub.Text = "View on GitHub";
            lnkGithub.LinkClicked += lnkGithub_Click;
            // 
            // picCoffee
            // 
            picCoffee.Cursor = Cursors.Hand;
            picCoffee.Image = Properties.Resources.buymeacoffee;
            picCoffee.Location = new Point(31, 97);
            picCoffee.Name = "picCoffee";
            picCoffee.Size = new Size(200, 56);
            picCoffee.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoffee.TabIndex = 6;
            picCoffee.TabStop = false;
            picCoffee.Click += picCoffee_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(104, 184);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 219);
            Controls.Add(picCoffee);
            Controls.Add(btnClose);
            Controls.Add(lnkGithub);
            Controls.Add(lblDescription);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AboutForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)picCoffee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private LinkLabel lnkGithub;
        private PictureBox picCoffee;
        private Button btnClose;
    }
}