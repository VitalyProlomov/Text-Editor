namespace Text_Editor__PR_6_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openInNewWindowMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.italicMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.boldMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.underlinedMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeThroughMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSavingMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSave10SecondsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSave45SecondsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSave2MinutesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSave5MinutesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSave15MinutesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSaveTurnOffMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.standardColorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixColorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.oldPaperColorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.currentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cutContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.formatContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.boldContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.italicContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.underLinedContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.StrikeThroughContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuButton,
            this.editMenuButton,
            this.formatMenuButton,
            this.settingsMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(687, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuButton
            // 
            this.FileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuButton,
            this.openFileMenuButton,
            this.saveMenuButton,
            this.saveAsMenuButton,
            this.closeMenuButton,
            this.openInNewWindowMenuButton,
            this.saveAllMenuButton});
            this.FileMenuButton.Name = "FileMenuButton";
            this.FileMenuButton.Size = new System.Drawing.Size(46, 24);
            this.FileMenuButton.Text = "File";
            // 
            // newMenuButton
            // 
            this.newMenuButton.Name = "newMenuButton";
            this.newMenuButton.ShortcutKeyDisplayString = "Ctrl +n";
            this.newMenuButton.Size = new System.Drawing.Size(240, 26);
            this.newMenuButton.Text = "New";
            // 
            // openFileMenuButton
            // 
            this.openFileMenuButton.Name = "openFileMenuButton";
            this.openFileMenuButton.Size = new System.Drawing.Size(240, 26);
            this.openFileMenuButton.Text = "Open File";
            // 
            // saveMenuButton
            // 
            this.saveMenuButton.Name = "saveMenuButton";
            this.saveMenuButton.ShortcutKeyDisplayString = "Ctrl + s";
            this.saveMenuButton.Size = new System.Drawing.Size(240, 26);
            this.saveMenuButton.Text = "Save";
            // 
            // saveAsMenuButton
            // 
            this.saveAsMenuButton.Name = "saveAsMenuButton";
            this.saveAsMenuButton.Size = new System.Drawing.Size(240, 26);
            this.saveAsMenuButton.Text = "Save As";
            // 
            // closeMenuButton
            // 
            this.closeMenuButton.Name = "closeMenuButton";
            this.closeMenuButton.Size = new System.Drawing.Size(240, 26);
            this.closeMenuButton.Text = "Close";
            // 
            // openInNewWindowMenuButton
            // 
            this.openInNewWindowMenuButton.Name = "openInNewWindowMenuButton";
            this.openInNewWindowMenuButton.ShortcutKeyDisplayString = "Ctrl + o";
            this.openInNewWindowMenuButton.Size = new System.Drawing.Size(240, 26);
            this.openInNewWindowMenuButton.Text = "New Window";
            // 
            // saveAllMenuButton
            // 
            this.saveAllMenuButton.Name = "saveAllMenuButton";
            this.saveAllMenuButton.ShortcutKeyDisplayString = "Ctrl + g";
            this.saveAllMenuButton.Size = new System.Drawing.Size(240, 26);
            this.saveAllMenuButton.Text = "Save all";
            // 
            // editMenuButton
            // 
            this.editMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllMenuButton,
            this.cutMenuButton,
            this.copyMenuButton,
            this.pasteMenuButton});
            this.editMenuButton.Name = "editMenuButton";
            this.editMenuButton.Size = new System.Drawing.Size(49, 24);
            this.editMenuButton.Text = "Edit";
            // 
            // selectAllMenuButton
            // 
            this.selectAllMenuButton.Name = "selectAllMenuButton";
            this.selectAllMenuButton.Size = new System.Drawing.Size(154, 26);
            this.selectAllMenuButton.Text = "Select All";
            // 
            // cutMenuButton
            // 
            this.cutMenuButton.Name = "cutMenuButton";
            this.cutMenuButton.Size = new System.Drawing.Size(154, 26);
            this.cutMenuButton.Text = "Cut";
            // 
            // copyMenuButton
            // 
            this.copyMenuButton.Name = "copyMenuButton";
            this.copyMenuButton.Size = new System.Drawing.Size(154, 26);
            this.copyMenuButton.Text = "Copy";
            // 
            // pasteMenuButton
            // 
            this.pasteMenuButton.Name = "pasteMenuButton";
            this.pasteMenuButton.Size = new System.Drawing.Size(154, 26);
            this.pasteMenuButton.Text = "Paste";
            // 
            // formatMenuButton
            // 
            this.formatMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italicMenuButton,
            this.boldMenuButton,
            this.underlinedMenuButton,
            this.strikeThroughMenuButton});
            this.formatMenuButton.Name = "formatMenuButton";
            this.formatMenuButton.Size = new System.Drawing.Size(70, 24);
            this.formatMenuButton.Text = "Format";
            // 
            // italicMenuButton
            // 
            this.italicMenuButton.Name = "italicMenuButton";
            this.italicMenuButton.Size = new System.Drawing.Size(184, 26);
            this.italicMenuButton.Text = "Italic";
            // 
            // boldMenuButton
            // 
            this.boldMenuButton.Name = "boldMenuButton";
            this.boldMenuButton.Size = new System.Drawing.Size(184, 26);
            this.boldMenuButton.Text = "Bold";
            // 
            // underlinedMenuButton
            // 
            this.underlinedMenuButton.Name = "underlinedMenuButton";
            this.underlinedMenuButton.Size = new System.Drawing.Size(184, 26);
            this.underlinedMenuButton.Text = "Underlined";
            // 
            // strikeThroughMenuButton
            // 
            this.strikeThroughMenuButton.Name = "strikeThroughMenuButton";
            this.strikeThroughMenuButton.Size = new System.Drawing.Size(184, 26);
            this.strikeThroughMenuButton.Text = "StrikeThrough";
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSavingMenuButton,
            this.colorMenuButton});
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.Size = new System.Drawing.Size(76, 24);
            this.settingsMenuButton.Text = "Settings";
            // 
            // autoSavingMenuButton
            // 
            this.autoSavingMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSave10SecondsMenuButton,
            this.autoSave45SecondsMenuButton,
            this.autoSave2MinutesMenuButton,
            this.autoSave5MinutesMenuButton,
            this.autoSave15MinutesMenuButton,
            this.autoSaveTurnOffMenuButton});
            this.autoSavingMenuButton.Name = "autoSavingMenuButton";
            this.autoSavingMenuButton.Size = new System.Drawing.Size(174, 26);
            this.autoSavingMenuButton.Text = "Auto Saving";
            // 
            // autoSave10SecondsMenuButton
            // 
            this.autoSave10SecondsMenuButton.Name = "autoSave10SecondsMenuButton";
            this.autoSave10SecondsMenuButton.Size = new System.Drawing.Size(230, 26);
            this.autoSave10SecondsMenuButton.Text = "10 Seconds";
            // 
            // autoSave45SecondsMenuButton
            // 
            this.autoSave45SecondsMenuButton.Name = "autoSave45SecondsMenuButton";
            this.autoSave45SecondsMenuButton.Size = new System.Drawing.Size(230, 26);
            this.autoSave45SecondsMenuButton.Text = "45 seconds";
            // 
            // autoSave2MinutesMenuButton
            // 
            this.autoSave2MinutesMenuButton.Name = "autoSave2MinutesMenuButton";
            this.autoSave2MinutesMenuButton.Size = new System.Drawing.Size(230, 26);
            this.autoSave2MinutesMenuButton.Text = "2 Minutes";
            // 
            // autoSave5MinutesMenuButton
            // 
            this.autoSave5MinutesMenuButton.Name = "autoSave5MinutesMenuButton";
            this.autoSave5MinutesMenuButton.Size = new System.Drawing.Size(230, 26);
            this.autoSave5MinutesMenuButton.Text = "5 Minutes";
            // 
            // autoSave15MinutesMenuButton
            // 
            this.autoSave15MinutesMenuButton.Name = "autoSave15MinutesMenuButton";
            this.autoSave15MinutesMenuButton.Size = new System.Drawing.Size(230, 26);
            this.autoSave15MinutesMenuButton.Text = "15 Minutes";
            // 
            // autoSaveTurnOffMenuButton
            // 
            this.autoSaveTurnOffMenuButton.Name = "autoSaveTurnOffMenuButton";
            this.autoSaveTurnOffMenuButton.Size = new System.Drawing.Size(230, 26);
            this.autoSaveTurnOffMenuButton.Text = "Turn Off Auto Saving";
            // 
            // colorMenuButton
            // 
            this.colorMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardColorMenuButton,
            this.matrixColorMenuButton,
            this.oldPaperColorMenuButton});
            this.colorMenuButton.Name = "colorMenuButton";
            this.colorMenuButton.Size = new System.Drawing.Size(174, 26);
            this.colorMenuButton.Text = "Color theme";
            // 
            // standardColorMenuButton
            // 
            this.standardColorMenuButton.Name = "standardColorMenuButton";
            this.standardColorMenuButton.Size = new System.Drawing.Size(243, 26);
            this.standardColorMenuButton.Text = "Standard theme";
            // 
            // matrixColorMenuButton
            // 
            this.matrixColorMenuButton.Name = "matrixColorMenuButton";
            this.matrixColorMenuButton.Size = new System.Drawing.Size(243, 26);
            this.matrixColorMenuButton.Text = "Matrix theme";
            // 
            // oldPaperColorMenuButton
            // 
            this.oldPaperColorMenuButton.Name = "oldPaperColorMenuButton";
            this.oldPaperColorMenuButton.Size = new System.Drawing.Size(243, 26);
            this.oldPaperColorMenuButton.Text = "Old paper color theme";
            // 
            // currentRichTextBox
            // 
            this.currentRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentRichTextBox.Location = new System.Drawing.Point(0, 28);
            this.currentRichTextBox.Name = "currentRichTextBox";
            this.currentRichTextBox.Size = new System.Drawing.Size(687, 496);
            this.currentRichTextBox.TabIndex = 1;
            this.currentRichTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllContextMenuStrip,
            this.cutContextMenuStrip,
            this.toolStripSeparator2,
            this.copyContextMenuStrip,
            this.pasteContextMenuStrip,
            this.toolStripSeparator1,
            this.formatContextMenuStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 136);
            // 
            // selectAllContextMenuStrip
            // 
            this.selectAllContextMenuStrip.Name = "selectAllContextMenuStrip";
            this.selectAllContextMenuStrip.Size = new System.Drawing.Size(140, 24);
            this.selectAllContextMenuStrip.Text = "Select All";
            // 
            // cutContextMenuStrip
            // 
            this.cutContextMenuStrip.Name = "cutContextMenuStrip";
            this.cutContextMenuStrip.Size = new System.Drawing.Size(140, 24);
            this.cutContextMenuStrip.Text = "Cut";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // copyContextMenuStrip
            // 
            this.copyContextMenuStrip.Name = "copyContextMenuStrip";
            this.copyContextMenuStrip.Size = new System.Drawing.Size(140, 24);
            this.copyContextMenuStrip.Text = "Copy";
            // 
            // pasteContextMenuStrip
            // 
            this.pasteContextMenuStrip.Name = "pasteContextMenuStrip";
            this.pasteContextMenuStrip.Size = new System.Drawing.Size(140, 24);
            this.pasteContextMenuStrip.Text = "Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // formatContextMenuStrip
            // 
            this.formatContextMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldContextMenuStrip,
            this.italicContextMenuStrip,
            this.underLinedContextMenuStrip,
            this.StrikeThroughContextMenuStrip});
            this.formatContextMenuStrip.Name = "formatContextMenuStrip";
            this.formatContextMenuStrip.Size = new System.Drawing.Size(140, 24);
            this.formatContextMenuStrip.Text = "Format";
            // 
            // boldContextMenuStrip
            // 
            this.boldContextMenuStrip.Name = "boldContextMenuStrip";
            this.boldContextMenuStrip.Size = new System.Drawing.Size(188, 26);
            this.boldContextMenuStrip.Text = "Bold";
            // 
            // italicContextMenuStrip
            // 
            this.italicContextMenuStrip.Name = "italicContextMenuStrip";
            this.italicContextMenuStrip.Size = new System.Drawing.Size(188, 26);
            this.italicContextMenuStrip.Text = "Italic";
            // 
            // underLinedContextMenuStrip
            // 
            this.underLinedContextMenuStrip.Name = "underLinedContextMenuStrip";
            this.underLinedContextMenuStrip.Size = new System.Drawing.Size(188, 26);
            this.underLinedContextMenuStrip.Text = "Underlined";
            // 
            // StrikeThroughContextMenuStrip
            // 
            this.StrikeThroughContextMenuStrip.Name = "StrikeThroughContextMenuStrip";
            this.StrikeThroughContextMenuStrip.Size = new System.Drawing.Size(188, 26);
            this.StrikeThroughContextMenuStrip.Text = "Strike Through";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 496);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(679, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "file 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(687, 524);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.currentRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem editMenuButton;
        private System.Windows.Forms.ToolStripMenuItem formatMenuButton;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem saveMenuButton;
        private System.Windows.Forms.ToolStripMenuItem newMenuButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuButton;
        private System.Windows.Forms.RichTextBox currentRichTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem formatContextMenuStrip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem closeMenuButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuButton;
        private System.Windows.Forms.ToolStripMenuItem cutMenuButton;
        private System.Windows.Forms.ToolStripMenuItem copyMenuButton;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuButton;
        private System.Windows.Forms.ToolStripMenuItem italicMenuButton;
        private System.Windows.Forms.ToolStripMenuItem boldMenuButton;
        private System.Windows.Forms.ToolStripMenuItem underlinedMenuButton;
        private System.Windows.Forms.ToolStripMenuItem strikeThroughMenuButton;
        private System.Windows.Forms.ToolStripMenuItem boldContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem italicContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem underLinedContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StrikeThroughContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem autoSavingMenuButton;
        private System.Windows.Forms.ToolStripMenuItem colorMenuButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem autoSave10SecondsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem autoSave45SecondsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem autoSave2MinutesMenuButton;
        private System.Windows.Forms.ToolStripMenuItem autoSave5MinutesMenuButton;
        private System.Windows.Forms.ToolStripMenuItem autoSave15MinutesMenuButton;
        private System.Windows.Forms.ToolStripMenuItem autoSaveTurnOffMenuButton;
        private System.Windows.Forms.ToolStripMenuItem standardColorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem matrixColorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem oldPaperColorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem openInNewWindowMenuButton;
        private System.Windows.Forms.ToolStripMenuItem saveAllMenuButton;
    }
}

