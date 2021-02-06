namespace WinFront
{
    partial class BrowserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserWindow));
            this.titleBar = new System.Windows.Forms.Panel();
            this.WindowMinButton = new System.Windows.Forms.Button();
            this.WindowMinMaxButton = new System.Windows.Forms.Button();
            this.WindowCloseButton = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackgroundImage = global::WinFront.Properties.Resources.stripebarlongboi;
            this.titleBar.Controls.Add(this.WindowMinButton);
            this.titleBar.Controls.Add(this.WindowMinMaxButton);
            this.titleBar.Controls.Add(this.WindowCloseButton);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1205, 29);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // WindowMinButton
            // 
            this.WindowMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowMinButton.BackColor = System.Drawing.Color.Black;
            this.WindowMinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WindowMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowMinButton.ForeColor = System.Drawing.Color.Black;
            this.WindowMinButton.Image = global::WinFront.Properties.Resources.min;
            this.WindowMinButton.Location = new System.Drawing.Point(1063, 0);
            this.WindowMinButton.Name = "WindowMinButton";
            this.WindowMinButton.Size = new System.Drawing.Size(49, 29);
            this.WindowMinButton.TabIndex = 2;
            this.WindowMinButton.UseVisualStyleBackColor = false;
            this.WindowMinButton.Click += new System.EventHandler(this.WindowMinButton_Click);
            this.WindowMinButton.MouseEnter += new System.EventHandler(this.WindowMinButton_MouseEnter);
            this.WindowMinButton.MouseLeave += new System.EventHandler(this.WindowMinButton_MouseLeave);
            // 
            // WindowMinMaxButton
            // 
            this.WindowMinMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowMinMaxButton.BackColor = System.Drawing.Color.Black;
            this.WindowMinMaxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WindowMinMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowMinMaxButton.ForeColor = System.Drawing.Color.Black;
            this.WindowMinMaxButton.Image = global::WinFront.Properties.Resources.max;
            this.WindowMinMaxButton.Location = new System.Drawing.Point(1109, 0);
            this.WindowMinMaxButton.Name = "WindowMinMaxButton";
            this.WindowMinMaxButton.Size = new System.Drawing.Size(49, 29);
            this.WindowMinMaxButton.TabIndex = 1;
            this.WindowMinMaxButton.UseVisualStyleBackColor = false;
            this.WindowMinMaxButton.Click += new System.EventHandler(this.WindowMinMaxButton_Click);
            this.WindowMinMaxButton.MouseEnter += new System.EventHandler(this.WindowMinMaxButton_MouseEnter);
            this.WindowMinMaxButton.MouseLeave += new System.EventHandler(this.WindowMinMaxButton_MouseLeave);
            // 
            // WindowCloseButton
            // 
            this.WindowCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowCloseButton.BackColor = System.Drawing.Color.Black;
            this.WindowCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WindowCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowCloseButton.ForeColor = System.Drawing.Color.Black;
            this.WindowCloseButton.Image = global::WinFront.Properties.Resources.x;
            this.WindowCloseButton.Location = new System.Drawing.Point(1155, 0);
            this.WindowCloseButton.Name = "WindowCloseButton";
            this.WindowCloseButton.Size = new System.Drawing.Size(49, 29);
            this.WindowCloseButton.TabIndex = 0;
            this.WindowCloseButton.UseVisualStyleBackColor = false;
            this.WindowCloseButton.Click += new System.EventHandler(this.WindowCloseButton_Click);
            this.WindowCloseButton.MouseEnter += new System.EventHandler(this.WindowCloseButton_MouseEnter);
            this.WindowCloseButton.MouseLeave += new System.EventHandler(this.WindowCloseButton_MouseLeave);
            // 
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1205, 716);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadow Browser";
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button WindowCloseButton;
        private System.Windows.Forms.Button WindowMinMaxButton;
        private System.Windows.Forms.Button WindowMinButton;
    }
}

