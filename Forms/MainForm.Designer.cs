﻿
namespace Vight_Note
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBox = new System.Windows.Forms.TextBox();
            this.FunctionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ImproveOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.ReduceOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AlwaysTop = new System.Windows.Forms.ToolStripMenuItem();
            this.LockTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ScrollBar = new System.Windows.Forms.ToolStripMenuItem();
            this.HideBorder = new System.Windows.Forms.ToolStripMenuItem();
            this.LiteMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.WhatIsLiteMode = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.PrivacyPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.TextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Count = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Run = new System.Windows.Forms.ToolStripMenuItem();
            this.Translate = new System.Windows.Forms.ToolStripMenuItem();
            this.FunctionMenu.SuspendLayout();
            this.TextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AllowDrop = true;
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.ContextMenuStrip = this.FunctionMenu;
            resources.ApplyResources(this.TextBox, "TextBox");
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.HideSelection = false;
            this.TextBox.Name = "TextBox";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.TextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            // 
            // FunctionMenu
            // 
            this.FunctionMenu.BackColor = System.Drawing.Color.White;
            this.FunctionMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            resources.ApplyResources(this.FunctionMenu, "FunctionMenu");
            this.FunctionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Close,
            this.Separator1,
            this.Save,
            this.Export,
            this.Import,
            this.Separator2,
            this.Search,
            this.Separator3,
            this.ImproveOpacity,
            this.ReduceOpacity,
            this.Separator4,
            this.AlwaysTop,
            this.LockTextBox,
            this.DarkMode,
            this.ScrollBar,
            this.HideBorder,
            this.LiteMode,
            this.toolStripSeparator4,
            this.Settings,
            this.Help});
            this.FunctionMenu.Name = "TextMenu";
            this.FunctionMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.FunctionMenu.ShowCheckMargin = true;
            this.FunctionMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FunctionMenu_Opening);
            this.FunctionMenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FunctionMenu_PreviewKeyDown);
            // 
            // Create
            // 
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Image = global::Vight_Note.Properties.Resources.Create;
            this.Create.Name = "Create";
            resources.ApplyResources(this.Create, "Create");
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Close
            // 
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Image = global::Vight_Note.Properties.Resources.Close;
            this.Close.Name = "Close";
            resources.ApplyResources(this.Close, "Close");
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Name = "Separator1";
            resources.ApplyResources(this.Separator1, "Separator1");
            // 
            // Save
            // 
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Image = global::Vight_Note.Properties.Resources.Save;
            this.Save.Name = "Save";
            resources.ApplyResources(this.Save, "Save");
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Export
            // 
            this.Export.ForeColor = System.Drawing.Color.Black;
            this.Export.Image = global::Vight_Note.Properties.Resources.Export;
            this.Export.Name = "Export";
            resources.ApplyResources(this.Export, "Export");
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.ForeColor = System.Drawing.Color.Black;
            this.Import.Image = global::Vight_Note.Properties.Resources.Import;
            this.Import.Name = "Import";
            resources.ApplyResources(this.Import, "Import");
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Name = "Separator2";
            resources.ApplyResources(this.Separator2, "Separator2");
            // 
            // Search
            // 
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Image = global::Vight_Note.Properties.Resources.Search;
            this.Search.Name = "Search";
            resources.ApplyResources(this.Search, "Search");
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            resources.ApplyResources(this.Separator3, "Separator3");
            // 
            // ImproveOpacity
            // 
            this.ImproveOpacity.ForeColor = System.Drawing.Color.Black;
            this.ImproveOpacity.Image = global::Vight_Note.Properties.Resources.Improve;
            this.ImproveOpacity.Name = "ImproveOpacity";
            resources.ApplyResources(this.ImproveOpacity, "ImproveOpacity");
            this.ImproveOpacity.Click += new System.EventHandler(this.ImproveOpacity_Click);
            // 
            // ReduceOpacity
            // 
            this.ReduceOpacity.ForeColor = System.Drawing.Color.Black;
            this.ReduceOpacity.Image = global::Vight_Note.Properties.Resources.Reduce;
            this.ReduceOpacity.Name = "ReduceOpacity";
            resources.ApplyResources(this.ReduceOpacity, "ReduceOpacity");
            this.ReduceOpacity.Click += new System.EventHandler(this.ReduceOpacity_Click);
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Name = "Separator4";
            resources.ApplyResources(this.Separator4, "Separator4");
            // 
            // AlwaysTop
            // 
            this.AlwaysTop.ForeColor = System.Drawing.Color.Black;
            this.AlwaysTop.Image = global::Vight_Note.Properties.Resources.Top;
            this.AlwaysTop.Name = "AlwaysTop";
            resources.ApplyResources(this.AlwaysTop, "AlwaysTop");
            this.AlwaysTop.Click += new System.EventHandler(this.AlwaysTop_Click);
            // 
            // LockTextBox
            // 
            this.LockTextBox.ForeColor = System.Drawing.Color.Black;
            this.LockTextBox.Image = global::Vight_Note.Properties.Resources.Unlock;
            this.LockTextBox.Name = "LockTextBox";
            resources.ApplyResources(this.LockTextBox, "LockTextBox");
            this.LockTextBox.Click += new System.EventHandler(this.LockTextBox_Click);
            // 
            // DarkMode
            // 
            this.DarkMode.ForeColor = System.Drawing.Color.Black;
            this.DarkMode.Image = global::Vight_Note.Properties.Resources.Dark;
            this.DarkMode.Name = "DarkMode";
            resources.ApplyResources(this.DarkMode, "DarkMode");
            this.DarkMode.Click += new System.EventHandler(this.DarkMode_Click);
            // 
            // ScrollBar
            // 
            this.ScrollBar.ForeColor = System.Drawing.Color.Black;
            this.ScrollBar.Image = global::Vight_Note.Properties.Resources.Scroll;
            this.ScrollBar.Name = "ScrollBar";
            resources.ApplyResources(this.ScrollBar, "ScrollBar");
            this.ScrollBar.Click += new System.EventHandler(this.ScrollBar_Click);
            // 
            // HideBorder
            // 
            this.HideBorder.ForeColor = System.Drawing.Color.Black;
            this.HideBorder.Image = global::Vight_Note.Properties.Resources.Border;
            this.HideBorder.Name = "HideBorder";
            resources.ApplyResources(this.HideBorder, "HideBorder");
            this.HideBorder.Click += new System.EventHandler(this.OpenBorder_Click);
            // 
            // LiteMode
            // 
            this.LiteMode.ForeColor = System.Drawing.Color.Black;
            this.LiteMode.Image = global::Vight_Note.Properties.Resources.Lite;
            this.LiteMode.Name = "LiteMode";
            resources.ApplyResources(this.LiteMode, "LiteMode");
            this.LiteMode.Click += new System.EventHandler(this.LiteMode_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // Settings
            // 
            this.Settings.ForeColor = System.Drawing.Color.Black;
            this.Settings.Image = global::Vight_Note.Properties.Resources.Settings;
            this.Settings.Name = "Settings";
            resources.ApplyResources(this.Settings, "Settings");
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhatIsLiteMode,
            this.Update,
            this.PrivacyPolicy,
            this.About});
            this.Help.ForeColor = System.Drawing.Color.Black;
            this.Help.Image = global::Vight_Note.Properties.Resources.Help;
            this.Help.Name = "Help";
            resources.ApplyResources(this.Help, "Help");
            // 
            // WhatIsLiteMode
            // 
            this.WhatIsLiteMode.ForeColor = System.Drawing.Color.Black;
            this.WhatIsLiteMode.Image = global::Vight_Note.Properties.Resources.What;
            this.WhatIsLiteMode.Name = "WhatIsLiteMode";
            resources.ApplyResources(this.WhatIsLiteMode, "WhatIsLiteMode");
            this.WhatIsLiteMode.Click += new System.EventHandler(this.WhatIsLiteMode_Click);
            // 
            // Update
            // 
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Image = global::Vight_Note.Properties.Resources.Update;
            this.Update.Name = "Update";
            resources.ApplyResources(this.Update, "Update");
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // PrivacyPolicy
            // 
            this.PrivacyPolicy.ForeColor = System.Drawing.Color.Black;
            this.PrivacyPolicy.Image = global::Vight_Note.Properties.Resources.Privacy;
            this.PrivacyPolicy.Name = "PrivacyPolicy";
            resources.ApplyResources(this.PrivacyPolicy, "PrivacyPolicy");
            this.PrivacyPolicy.Click += new System.EventHandler(this.PrivacyPolicy_Click);
            // 
            // About
            // 
            this.About.ForeColor = System.Drawing.Color.Black;
            this.About.Image = global::Vight_Note.Properties.Resources.About;
            this.About.Name = "About";
            resources.ApplyResources(this.About, "About");
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // TextMenu
            // 
            this.TextMenu.BackColor = System.Drawing.Color.White;
            this.TextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            resources.ApplyResources(this.TextMenu, "TextMenu");
            this.TextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Count,
            this.toolStripSeparator5,
            this.Run,
            this.Translate});
            this.TextMenu.Name = "TextMenu";
            this.TextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TextMenu.ShowCheckMargin = true;
            // 
            // Count
            // 
            this.Count.ForeColor = System.Drawing.Color.Black;
            this.Count.Image = global::Vight_Note.Properties.Resources.Count;
            this.Count.Name = "Count";
            resources.ApplyResources(this.Count, "Count");
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // Run
            // 
            this.Run.ForeColor = System.Drawing.Color.Black;
            this.Run.Image = global::Vight_Note.Properties.Resources.Run;
            this.Run.Name = "Run";
            resources.ApplyResources(this.Run, "Run");
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Translate
            // 
            this.Translate.ForeColor = System.Drawing.Color.Black;
            this.Translate.Image = global::Vight_Note.Properties.Resources.Translate;
            this.Translate.Name = "Translate";
            resources.ApplyResources(this.Translate, "Translate");
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.FunctionMenu.ResumeLayout(false);
            this.TextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip FunctionMenu;
        private new System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem HideBorder;
        private System.Windows.Forms.ToolStripMenuItem AlwaysTop;
        private System.Windows.Forms.ToolStripMenuItem ImproveOpacity;
        private System.Windows.Forms.ToolStripMenuItem ReduceOpacity;
        private System.Windows.Forms.ToolStripMenuItem DarkMode;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Import;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem LiteMode;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private new System.Windows.Forms.ToolStripMenuItem Update;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem LockTextBox;
        private System.Windows.Forms.ToolStripMenuItem WhatIsLiteMode;
        private System.Windows.Forms.ToolStripMenuItem ScrollBar;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem PrivacyPolicy;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ContextMenuStrip TextMenu;
        private System.Windows.Forms.ToolStripMenuItem Count;
        private System.Windows.Forms.ToolStripMenuItem Run;
        private System.Windows.Forms.ToolStripMenuItem Translate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        internal System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem Settings;
    }
}

