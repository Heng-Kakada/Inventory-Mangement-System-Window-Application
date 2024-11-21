namespace InventoryManagementSystem
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabform = new TabControl();
            menubar = new MenuStrip();
            homeMenuItemBar = new ToolStripMenuItem();
            inventoryMenuItemBar = new ToolStripMenuItem();
            categoryMenuItem = new ToolStripMenuItem();
            productMenuItem = new ToolStripMenuItem();
            inventoryMenuItem = new ToolStripMenuItem();
            importExportMenuItemBar = new ToolStripMenuItem();
            importMenuItem = new ToolStripMenuItem();
            exportMenuItem = new ToolStripMenuItem();
            exportLogMenuItem = new ToolStripMenuItem();
            exportHistoryMenuItem = new ToolStripMenuItem();
            profilesMenuItemBar = new ToolStripMenuItem();
            userMenuItem = new ToolStripMenuItem();
            staffMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            settingMenuItemBar = new ToolStripMenuItem();
            helpMenuItem = new ToolStripMenuItem();
            aboutUsMenuItem = new ToolStripMenuItem();
            menubar.SuspendLayout();
            SuspendLayout();
            // 
            // tabform
            // 
            tabform.Dock = DockStyle.Fill;
            tabform.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabform.Location = new Point(0, 53);
            tabform.Margin = new Padding(0);
            tabform.Name = "tabform";
            tabform.Padding = new Point(20, 4);
            tabform.SelectedIndex = 0;
            tabform.Size = new Size(1178, 796);
            tabform.TabIndex = 0;
            // 
            // menubar
            // 
            menubar.BackColor = SystemColors.ActiveCaption;
            menubar.Font = new Font("Segoe UI", 10F);
            menubar.ImageScalingSize = new Size(20, 20);
            menubar.Items.AddRange(new ToolStripItem[] { homeMenuItemBar, inventoryMenuItemBar, importExportMenuItemBar, profilesMenuItemBar, toolStripMenuItem1, settingMenuItemBar });
            menubar.Location = new Point(0, 0);
            menubar.Name = "menubar";
            menubar.Padding = new Padding(5, 5, 0, 5);
            menubar.Size = new Size(1178, 53);
            menubar.TabIndex = 1;
            menubar.Text = "menu";
            // 
            // homeMenuItemBar
            // 
            homeMenuItemBar.Name = "homeMenuItemBar";
            homeMenuItemBar.Padding = new Padding(5, 8, 5, 8);
            homeMenuItemBar.Size = new Size(70, 43);
            homeMenuItemBar.Text = "Home";
            // 
            // inventoryMenuItemBar
            // 
            inventoryMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { categoryMenuItem, productMenuItem, inventoryMenuItem });
            inventoryMenuItemBar.Name = "inventoryMenuItemBar";
            inventoryMenuItemBar.Size = new Size(96, 43);
            inventoryMenuItemBar.Text = "Inventory";
            // 
            // categoryMenuItem
            // 
            categoryMenuItem.Name = "categoryMenuItem";
            categoryMenuItem.Size = new Size(166, 28);
            categoryMenuItem.Text = "Category";
            // 
            // productMenuItem
            // 
            productMenuItem.Name = "productMenuItem";
            productMenuItem.Size = new Size(166, 28);
            productMenuItem.Text = "Product";
            // 
            // inventoryMenuItem
            // 
            inventoryMenuItem.Name = "inventoryMenuItem";
            inventoryMenuItem.Size = new Size(166, 28);
            inventoryMenuItem.Text = "Inventory";
            // 
            // importExportMenuItemBar
            // 
            importExportMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { importMenuItem, exportMenuItem });
            importExportMenuItemBar.Name = "importExportMenuItemBar";
            importExportMenuItemBar.Size = new Size(142, 43);
            importExportMenuItemBar.Text = "Import / Export";
            // 
            // importMenuItem
            // 
            importMenuItem.Name = "importMenuItem";
            importMenuItem.Size = new Size(146, 28);
            importMenuItem.Text = "Import";
            // 
            // exportMenuItem
            // 
            exportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportLogMenuItem, exportHistoryMenuItem });
            exportMenuItem.Name = "exportMenuItem";
            exportMenuItem.Size = new Size(146, 28);
            exportMenuItem.Text = "Export";
            // 
            // exportLogMenuItem
            // 
            exportLogMenuItem.Name = "exportLogMenuItem";
            exportLogMenuItem.Size = new Size(201, 28);
            exportLogMenuItem.Text = "Export Log";
            // 
            // exportHistoryMenuItem
            // 
            exportHistoryMenuItem.Name = "exportHistoryMenuItem";
            exportHistoryMenuItem.Size = new Size(201, 28);
            exportHistoryMenuItem.Text = "Export History";
            // 
            // profilesMenuItemBar
            // 
            profilesMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { userMenuItem, staffMenuItem });
            profilesMenuItemBar.Name = "profilesMenuItemBar";
            profilesMenuItemBar.Size = new Size(79, 43);
            profilesMenuItemBar.Text = "Profiles";
            // 
            // userMenuItem
            // 
            userMenuItem.Name = "userMenuItem";
            userMenuItem.Size = new Size(128, 28);
            userMenuItem.Text = "User";
            // 
            // staffMenuItem
            // 
            staffMenuItem.Name = "staffMenuItem";
            staffMenuItem.Size = new Size(128, 28);
            staffMenuItem.Text = "Staff";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 43);
            // 
            // settingMenuItemBar
            // 
            settingMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { helpMenuItem, aboutUsMenuItem });
            settingMenuItemBar.Name = "settingMenuItemBar";
            settingMenuItemBar.Size = new Size(78, 43);
            settingMenuItemBar.Text = "Setting";
            // 
            // helpMenuItem
            // 
            helpMenuItem.Name = "helpMenuItem";
            helpMenuItem.Size = new Size(165, 28);
            helpMenuItem.Text = "Help";
            // 
            // aboutUsMenuItem
            // 
            aboutUsMenuItem.Name = "aboutUsMenuItem";
            aboutUsMenuItem.Size = new Size(165, 28);
            aboutUsMenuItem.Text = "About Us";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 849);
            Controls.Add(tabform);
            Controls.Add(menubar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menubar.ResumeLayout(false);
            menubar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabform;
        private MenuStrip menubar;
        private ToolStripMenuItem homeMenuItemBar;
        private ToolStripMenuItem inventoryMenuItemBar;
        private ToolStripMenuItem productMenuItem;
        private ToolStripMenuItem categoryMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem settingMenuItemBar;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem aboutUsMenuItem;
        private ToolStripMenuItem importExportMenuItemBar;
        private ToolStripMenuItem importMenuItem;
        private ToolStripMenuItem exportMenuItem;
        private ToolStripMenuItem exportLogMenuItem;
        private ToolStripMenuItem inventoryMenuItem;
        private ToolStripMenuItem profilesMenuItemBar;
        private ToolStripMenuItem userMenuItem;
        private ToolStripMenuItem staffMenuItem;
        private ToolStripMenuItem exportHistoryMenuItem;
    }
}