namespace TixTaxToe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTool = new System.Windows.Forms.ToolStripMenuItem();
            this.gridSizeTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTool});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // fileTool
            // 
            this.fileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTool,
            this.gridSizeTool});
            this.fileTool.Name = "fileTool";
            resources.ApplyResources(this.fileTool, "fileTool");
            // 
            // clearTool
            // 
            this.clearTool.Name = "clearTool";
            resources.ApplyResources(this.clearTool, "clearTool");
            this.clearTool.Click += new System.EventHandler(this.clearTool_Click);
            // 
            // gridSizeTool
            // 
            this.gridSizeTool.Name = "gridSizeTool";
            resources.ApplyResources(this.gridSizeTool, "gridSizeTool");
            this.gridSizeTool.Click += new System.EventHandler(this.gridSizeTool_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileTool;
        private System.Windows.Forms.ToolStripMenuItem clearTool;
        private System.Windows.Forms.ToolStripMenuItem gridSizeTool;
    }
}

