namespace ITMO.CS.WinApp.LabWork8.Task5.WinLanguage
{
    partial class WinLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLanguage));
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandtwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            resources.ApplyResources(this.menuStripMainMenu, "menuStripMainMenu");
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            // 
            // menuToolStripMenuItem
            // 
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandoneToolStripMenuItem,
            this.commandtwoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // commandoneToolStripMenuItem
            // 
            resources.ApplyResources(this.commandoneToolStripMenuItem, "commandoneToolStripMenuItem");
            this.commandoneToolStripMenuItem.Name = "commandoneToolStripMenuItem";
            // 
            // commandtwoToolStripMenuItem
            // 
            resources.ApplyResources(this.commandtwoToolStripMenuItem, "commandtwoToolStripMenuItem");
            this.commandtwoToolStripMenuItem.Name = "commandtwoToolStripMenuItem";
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // WinLanguage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.menuStripMainMenu);
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "WinLanguage";
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandtwoToolStripMenuItem;
        private System.Windows.Forms.Button buttonClose;
    }
}

