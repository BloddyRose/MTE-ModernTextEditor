namespace ModernTextEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fontButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Seperator = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionBT = new System.Windows.Forms.ToolStripMenuItem();
            this.TextInput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuButton,
            this.editButton,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuButton
            // 
            this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewButton,
            this.OpenFileButton,
            this.SaveButton,
            this.exitButton});
            this.fileMenuButton.Name = "fileMenuButton";
            this.fileMenuButton.Size = new System.Drawing.Size(37, 20);
            this.fileMenuButton.Text = "File";
            // 
            // fileNewButton
            // 
            this.fileNewButton.Name = "fileNewButton";
            this.fileNewButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNewButton.Size = new System.Drawing.Size(162, 22);
            this.fileNewButton.Text = "New File";
            this.fileNewButton.Click += new System.EventHandler(this.fileNewButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileButton.Size = new System.Drawing.Size(162, 22);
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveButton.Size = new System.Drawing.Size(162, 22);
            this.SaveButton.Text = "Save File";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitButton.Size = new System.Drawing.Size(162, 22);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editButton
            // 
            this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontButton});
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(39, 20);
            this.editButton.Text = "Edit";
            // 
            // fontButton
            // 
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(98, 22);
            this.fontButton.Text = "Font";
            this.fontButton.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton,
            this.Seperator,
            this.VersionBT});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(180, 22);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Seperator
            // 
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(180, 22);
            this.Seperator.Text = "-----------------";
            this.Seperator.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // VersionBT
            // 
            this.VersionBT.Name = "VersionBT";
            this.VersionBT.Size = new System.Drawing.Size(180, 22);
            this.VersionBT.Text = "Version 1.0";
            this.VersionBT.Click += new System.EventHandler(this.VersionBT_Click);
            // 
            // TextInput
            // 
            this.TextInput.AcceptsTab = true;
            this.TextInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextInput.BackColor = System.Drawing.Color.Turquoise;
            this.TextInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextInput.EnableAutoDragDrop = true;
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextInput.Location = new System.Drawing.Point(12, 27);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(754, 366);
            this.TextInput.TabIndex = 1;
            this.TextInput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 401);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MTE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem fileNewButton;
        private System.Windows.Forms.ToolStripMenuItem OpenFileButton;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem Seperator;
        private System.Windows.Forms.ToolStripMenuItem VersionBT;
        private System.Windows.Forms.RichTextBox TextInput;
        private System.Windows.Forms.ToolStripMenuItem editButton;
        private System.Windows.Forms.ToolStripMenuItem fontButton;
    }
}

