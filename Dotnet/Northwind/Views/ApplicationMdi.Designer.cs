using ENV;
using Firefly.Box;
using System;
namespace Northwind.Views
{
    partial class ApplicationMdi
    {
        System.ComponentModel.IContainer components;
        System.Windows.Forms.StatusStrip StatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel userStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel versionStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel activityStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel expandStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel expandTextBoxStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel insertOverrideStatusLabel;
        ApplicationMdiMenu mainMenu;
        System.Windows.Forms.ToolStrip mainMenuToolStrip;
        protected override void Dispose(bool disposing)
        {
            if (disposing&&(components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this._optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.activityStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.expandStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.expandTextBoxStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.insertOverrideStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new Northwind.Views.ApplicationMdiMenu();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.test = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.StatusStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip.ContextMenuStrip = this._optionsContextMenuStrip;
            this.StatusStrip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel,
            this.userStatusLabel,
            this.versionStatusLabel,
            this.activityStatusLabel,
            this.expandStatusLabel,
            this.expandTextBoxStatusLabel,
            this.insertOverrideStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 418);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(600, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            // 
            // _optionsContextMenuStrip
            // 
            this._optionsContextMenuStrip.Name = "_optionsContextMenuStrip";
            this._optionsContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.AutoSize = false;
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(251, 17);
            this.mainStatusLabel.Spring = true;
            this.mainStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.AutoSize = false;
            this.userStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.userStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(120, 17);
            this.userStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionStatusLabel
            // 
            this.versionStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.versionStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.versionStatusLabel.Name = "versionStatusLabel";
            this.versionStatusLabel.Size = new System.Drawing.Size(4, 17);
            this.versionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityStatusLabel
            // 
            this.activityStatusLabel.AutoSize = false;
            this.activityStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.activityStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.activityStatusLabel.Name = "activityStatusLabel";
            this.activityStatusLabel.Size = new System.Drawing.Size(60, 17);
            this.activityStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expandStatusLabel
            // 
            this.expandStatusLabel.AutoSize = false;
            this.expandStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.expandStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.expandStatusLabel.Name = "expandStatusLabel";
            this.expandStatusLabel.Size = new System.Drawing.Size(60, 17);
            this.expandStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandStatusLabel.Click += new System.EventHandler(this.expandStatusLabel_Click);
            // 
            // expandTextBoxStatusLabel
            // 
            this.expandTextBoxStatusLabel.AutoSize = false;
            this.expandTextBoxStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.expandTextBoxStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.expandTextBoxStatusLabel.Name = "expandTextBoxStatusLabel";
            this.expandTextBoxStatusLabel.Size = new System.Drawing.Size(60, 17);
            this.expandTextBoxStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandTextBoxStatusLabel.Click += new System.EventHandler(this.expandTextBoxStatusLabel_Click);
            // 
            // insertOverrideStatusLabel
            // 
            this.insertOverrideStatusLabel.AutoSize = false;
            this.insertOverrideStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.insertOverrideStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.insertOverrideStatusLabel.Name = "insertOverrideStatusLabel";
            this.insertOverrideStatusLabel.Size = new System.Drawing.Size(30, 17);
            this.insertOverrideStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.test});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.mainMenu.Size = new System.Drawing.Size(600, 19);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 4);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 4);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 4);
            // 
            // test
            // 
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(39, 19);
            this.test.Text = "Test";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // mainMenuToolStrip
            // 
            this.mainMenuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainMenuToolStrip.Location = new System.Drawing.Point(0, 19);
            this.mainMenuToolStrip.Name = "mainMenuToolStrip";
            this.mainMenuToolStrip.Size = new System.Drawing.Size(600, 25);
            this.mainMenuToolStrip.TabIndex = 2;
            // 
            // ApplicationMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.mainMenuToolStrip);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ApplicationMdi";
            this.Text = "Northwind";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem test;
    }
}
