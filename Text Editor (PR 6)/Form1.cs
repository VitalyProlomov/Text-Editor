using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Text_Editor__PR_6_.Properties;

namespace Text_Editor__PR_6_
{
    public partial class Form1 : Form
    {

        // List that contains all TabPages - needed to know which tab is active, which tab to close etc.
        static List<TabPage> allTabPages = new List<TabPage>();

        // List with all richTextBoxes - needed to know which TextBox is being used currently and store information 
        // about unactive textboxes.
        static List<RichTextBox> allRichTextBoxes = new List<RichTextBox>();

        // Contains all File names of files that has not been closed yet - needed to save info from current richTextBox 
        // to the original file. If there is no such one, it will suggest user to crewate a new file.
        static List<string> allFileNames = new List<string>();

        // Contains info whether each opened file was saved or not.
        // Each element of the list has 2 possible values:
        // 1)false - which means that file is not saved
        // 2)true - file is saved.
        static List<bool> allStatuses = new List<bool>();

        // This field has 3 values: "standard", "old", "matrix", that determies which
        // color theme is currently chosen by user. That theme is goig to be used for setting
        // color to newly created tab pages.
        static string currentColorTheme = "standard";

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adding a RichTextBox to the first tab (the one that opens with the program).
            RichTextBox box1 = new RichTextBox();
            currentRichTextBox = box1;
            currentRichTextBox.ContextMenuStrip = contextMenuStrip1;
            tabPage1.Controls.Add(box1);
            box1.Dock = DockStyle.Fill;

            // Adding objects to the lists 
            allRichTextBoxes.Add(box1);
            allTabPages.Add(tabPage1);
            allFileNames.Add("new");
            allStatuses.Add(false);
            // Hot Keys method.
            tabControl1.KeyDown += TabControl1_KeyDown;
            
          
            // Previously open files.
            if (Settings.Default.allFileNames != null)
                for (int i = 0; i < Settings.Default.allFileNames.Count; i++)
                {
                    NewMenuButton_Click(sender, e);
                    if (Settings.Default.allFileNames[i].Contains("rtf"))
                        allRichTextBoxes[i].LoadFile(Settings.Default.allFileNames[i], RichTextBoxStreamType.RichText);
                    else
                        allRichTextBoxes[i].Text = File.ReadAllText(Settings.Default.allFileNames[i]);
                    allFileNames[i] = Settings.Default.allFileNames[i];
                }
            // Color theme settings.
            if (Properties.Settings.Default.colorTheme == "old")
                OldPaperColorMenuButton_Click(sender, e);
            if (Settings.Default.colorTheme == "matrix")
                MatrixColorMenuButton_Click(sender, e);
        }


        /// <summary>
        /// Here I assigned methods to all events.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // File Buttons
            newMenuButton.Click += NewMenuButton_Click;
            openFileMenuButton.Click += OpenFileButton_Click;
            saveMenuButton.Click += SaveMenuButton_Click;
            saveAsMenuButton.Click += SaveAsMenuButton_Click;
            closeMenuButton.Click += CloseMenuButton_Click;
            openInNewWindowMenuButton.Click += OpenInNewWindowMenuButton_Click;
            saveAllMenuButton.Click += SaveAllMenuButton_Click;

            // Edit Buttons
            selectAllMenuButton.Click += SelectAllMenuButton_Click;
            pasteMenuButton.Click += PasteMenuButton_Click;
            cutMenuButton.Click += CutMenuButton_Click;
            copyMenuButton.Click += CopyMenuButton_Click;

            //Format Buttons
            boldMenuButton.Click += BoldMenuButton_Click;
            italicMenuButton.Click += ItalicMenuButton_Click;
            underlinedMenuButton.Click += UnderlinedMenuButton_Click;
            strikeThroughMenuButton.Click += StrikeThroughMenuButton_Click;

            // Context Menu Buttons (ContextMenuStrip)
            selectAllContextMenuStrip.Click += SelectAllMenuButton_Click;
            pasteContextMenuStrip.Click += PasteMenuButton_Click;
            cutContextMenuStrip.Click += CutMenuButton_Click;
            copyContextMenuStrip.Click += CopyMenuButton_Click;

            boldContextMenuStrip.Click += BoldMenuButton_Click;
            italicContextMenuStrip.Click += ItalicMenuButton_Click;
            underLinedContextMenuStrip.Click += UnderlinedMenuButton_Click;
            StrikeThroughContextMenuStrip.Click += StrikeThroughMenuButton_Click;

            // Settings Menu Buttons
            autoSave10SecondsMenuButton.Click += AutoSave10SecondsMenuButton_Click;
            autoSave45SecondsMenuButton.Click += AutoSave45SecondsMenuButton_Click;
            autoSave2MinutesMenuButton.Click += AutoSave2MinutesMenuButton_Click;
            autoSave5MinutesMenuButton.Click += AutoSave5MinutesMenuButton_Click;
            autoSave15MinutesMenuButton.Click += AutoSave15MinutesMenuButton_Click;
            autoSaveTurnOffMenuButton.Click += AutoSaveTurnOffMenuButton_Click;
            timer1.Tick += Timer1_Tick;

            standardColorMenuButton.Click += StandardColorMenuButton_Click;
            matrixColorMenuButton.Click += MatrixColorMenuButton_Click;
            oldPaperColorMenuButton.Click += OldPaperColorMenuButton_Click;
        }


        /// <summary>
        /// Hot keys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.S)
                    SaveMenuButton_Click(sender, e);
                if (e.KeyCode == Keys.O)
                    OpenInNewWindowMenuButton_Click(sender, e);
                if (e.KeyCode == Keys.N)
                    NewMenuButton_Click(sender, e);
                if (e.KeyCode == Keys.G)
                    SaveAllMenuButton_Click(sender, e);
            }

            // Закрытие формы - alt + f4.

        }

        /// <summary>
        /// Changing all current tab pages color theme and form color to "Old paper" color theme
        /// Also setting currentColorTheme to "Old paper".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OldPaperColorMenuButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allRichTextBoxes.Count; i++)
            {
                allRichTextBoxes[i].BackColor = Color.AntiqueWhite;
                allRichTextBoxes[i].ForeColor = Color.Black;
            }
            BackColor = Color.Cornsilk;
            menuStrip1.BackColor = Color.Cornsilk;

            currentColorTheme = "old";
        }

        /// <summary>
        /// Setting standard color theme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StandardColorMenuButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allRichTextBoxes.Count; i++)
            {
                allRichTextBoxes[i].BackColor = Color.White;
                allRichTextBoxes[i].ForeColor = Color.Black;
            }
            BackColor = Color.White;
            menuStrip1.BackColor = Color.Gainsboro;
            currentColorTheme = "standard";
        }

        private void MatrixColorMenuButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allRichTextBoxes.Count; i++)
            {
                allRichTextBoxes[i].BackColor = Color.Black;
                allRichTextBoxes[i].ForeColor = Color.Green;
            }
            BackColor = Color.Black;          
            menuStrip1.BackColor = Color.Black;

            currentColorTheme = "matrix";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            RichTextBox textBoxNow = currentRichTextBox;
            for (int i = 0; i < allFileNames.Count; i++)
            {
                if (allFileNames[i] != "new")
                {
                    // Changing of the currentRichTextBox is needed because method SaveMenuButton_Click
                    // works with currentRichTextBox.
                    currentRichTextBox = allRichTextBoxes[i];
                    SaveMenuButton_Click(sender, e);
                }
            }
            // Setting currentRichTextBox back to the active one
            currentRichTextBox = textBoxNow;
        }

        private void AutoSaveTurnOffMenuButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void AutoSave15MinutesMenuButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 * 60 * 15;
            timer1.Start();
        }

        private void AutoSave5MinutesMenuButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 * 60 * 5;
            timer1.Start();
        }

        private void AutoSave2MinutesMenuButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 * 60 * 2;
            timer1.Start();
        }

        private void AutoSave45SecondsMenuButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 * 45;
            timer1.Start();
        }

        private void AutoSave10SecondsMenuButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 * 10;
            timer1.Start();
        }

        private void StrikeThroughMenuButton_Click(object sender, EventArgs e)
        {
            currentRichTextBox.SelectionFont = new Font(currentRichTextBox.SelectionFont, FontStyle.Strikeout ^ currentRichTextBox.SelectionFont.Style);
        }

        private void UnderlinedMenuButton_Click(object sender, EventArgs e)
        {
            currentRichTextBox.SelectionFont = new Font(currentRichTextBox.SelectionFont, FontStyle.Underline ^ currentRichTextBox.SelectionFont.Style);
        }

        private void ItalicMenuButton_Click(object sender, EventArgs e)
        {
            currentRichTextBox.SelectionFont = new Font(currentRichTextBox.SelectionFont, FontStyle.Italic ^ currentRichTextBox.SelectionFont.Style);
        }
        private void BoldMenuButton_Click(object sender, EventArgs e)
        {
            currentRichTextBox.SelectionFont = new Font(currentRichTextBox.SelectionFont, FontStyle.Bold ^ currentRichTextBox.SelectionFont.Style);
        }

        /// <summary>
        /// Copies the chosen text from the current rich text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyMenuButton_Click(object sender, EventArgs e)
        {
            if (allTabPages.Count == 0)
            {
                MessageBox.Show("Firstly, create or open a new file.");
                return;
            }
            currentRichTextBox.Copy();
        }

        /// <summary>
        /// Cuts chosen text from the current rich text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutMenuButton_Click(object sender, EventArgs e)
        {
            if (allTabPages.Count == 0)
            {
                MessageBox.Show("Firstly, create or open a new file.");
                return;
            }
            currentRichTextBox.Cut();
        }

        /// <summary>
        /// Pastes text from the buffer to the current rich text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteMenuButton_Click(object sender, EventArgs e)
        {
            if (allTabPages.Count == 0)
            {
                MessageBox.Show("Firstly, create or open a new file.");
                return;
            }
            currentRichTextBox.Paste();
            if (currentColorTheme == "matrix")
            {
                currentRichTextBox.ForeColor = Color.Green;
            }
            if (currentColorTheme == "old")
            {
                currentRichTextBox.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Selects all text in current rich text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllMenuButton_Click(object sender, EventArgs e)
        {
            if (allTabPages.Count == 0)
            {
                MessageBox.Show("Firstly, create or open a new file.");
                return;
            }
            currentRichTextBox.SelectAll();
        }

        /// <summary>
        /// Occurs if user presses the "close" button in menu - closes the current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseMenuButton_Click(object sender, EventArgs e)
        {

            TabPage selectedTabPage = tabControl1.SelectedTab;
            tabControl1.Controls.Remove(selectedTabPage);
            int index = allTabPages.IndexOf(selectedTabPage);
            if (index != -1)
            {
                // Deletes all properties assigned to the tab file.
                allRichTextBoxes.Remove(allRichTextBoxes[index]);
                allTabPages.Remove(selectedTabPage);
                allFileNames.Remove(allFileNames[index]);
                allStatuses.Remove(allStatuses[index]);
            }
        }


        /// <summary>
        /// Saves current file into a new or existing file of user`s choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (allTabPages.Count == 0)
                {
                    MessageBox.Show("Nothing to save here");
                    return;
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    int index = allRichTextBoxes.IndexOf(currentRichTextBox);
                    string fileName = saveFileDialog1.FileName;
                    if (fileName.Contains(".rtf"))
                    {
                        currentRichTextBox.SaveFile(allFileNames[index], RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(fileName, currentRichTextBox.Text);
                    }
                    // Status is being changed to 'true', which means that all changes in the file are saved.
                    allStatuses[allRichTextBoxes.IndexOf(currentRichTextBox)] = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somethimg went wrong.." + Environment.NewLine +
                    ex.Message);
            }

        }

        /// <summary>
        /// Sves all changes in the edited file. Only works with files, that were opened.
        /// If file was created as 'New', function 'Save as' is the one that needs to be used.
        /// (That is told to user).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            // Can`t save emptiness.
            if (allRichTextBoxes.Count == 0)
            {
                MessageBox.Show("Nothing to save here");
                return;
            }
            // Index of currentRichTextBox - needed for the program to know,
            // which richTextBox must be active and which file is now being edited.
            int indexOfCurrentTab = allRichTextBoxes.IndexOf(currentRichTextBox);
            // Only files that have original file can be saved. Others, that were create with 'New' could be
            // 'Saved as' into a new file.
            if (allFileNames[indexOfCurrentTab] == "new")
            {
                MessageBox.Show("There is no original file, perhaps you want to create one using " +
                     Environment.NewLine + "function 'Save as'.");
            }
            else
            {
                try
                {
                    if (allFileNames[indexOfCurrentTab].Contains(".rtf"))
                    {

                        currentRichTextBox.SaveFile(allFileNames[indexOfCurrentTab], RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(allFileNames[indexOfCurrentTab], allRichTextBoxes[indexOfCurrentTab].Text);
                    }
                    // Status changes to 'true', whixh stands for saved.
                    allStatuses[indexOfCurrentTab] = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong - " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Creates a new tab with the new richtextbox assigned to it.
        /// Status of the new tab will be 'false', (which stays for unsaved).
        /// File name assigned to this tab will be 'new'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewMenuButton_Click(object sender, EventArgs e)
        {
            TabPage newTapPage = new TabPage();
            tabControl1.Controls.Add(newTapPage);
            RichTextBox newrichTextBox = new RichTextBox();
            newrichTextBox.Dock = DockStyle.Fill;
            // Adding textbox where to write.
            newTapPage.Controls.Add(newrichTextBox);
            allTabPages.Add(newTapPage);
            allRichTextBoxes.Add(newrichTextBox);
            allFileNames.Add("new");
            allStatuses.Add(false);
            // If the tabPAge that we just added is the only opened tab,
            // its name will be 'file 1'.
            if (allTabPages.Count == 1)
            {
                newTapPage.Text = $"file {allTabPages.Count}";
                currentRichTextBox.ContextMenuStrip = contextMenuStrip1;
            }
            // If there are other opened files, name of the tab will be chosen as 'file i',
            //  where 'i' is the number of opened files currently.
            else
            {
                try
                {
                    int amountOfSameNames = 0;
                    for (int i = 0; i < allTabPages.Count; i++)
                    {
                        if (allTabPages[i].Text.Contains($"file {allTabPages.Count}"))
                            amountOfSameNames++;
                        // If there there already is a file with the same number in its name, current 
                        // name of the file will be chosen as 'file i(a)', where 'a' is amount of 
                        // files with index i same with the current file (including current file).
                        if (amountOfSameNames != 1)
                            newTapPage.Text = $"file {allTabPages.Count}({amountOfSameNames})";
                        else
                            newTapPage.Text = $"file {allTabPages.Count}";
                    }
                    if (currentColorTheme == "matrix")
                    {
                        newrichTextBox.BackColor = Color.Black;
                        newrichTextBox.ForeColor = Color.Green;
                        BackColor = Color.Black;
                        menuStrip1.BackColor = Color.Black;
                    }
                    else if (currentColorTheme == "old")
                    {
                        newrichTextBox.BackColor = Color.AntiqueWhite;
                        newrichTextBox.ForeColor = Color.Black;
                        BackColor = Color.Cornsilk;
                        menuStrip1.BackColor = Color.Cornsilk;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong - " + Environment.NewLine +
                        ex.Message);
                }
            }
        }


        /// <summary>
        /// Opens file that user choose in file dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            // If file opened successfully
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = openFileDialog1.FileName;
                    // If there are no opened tabs currently, a new tab is created and made active.
                    if (allTabPages.Count == 0)
                    {
                        NewMenuButton_Click(sender, e);
                    }
                    // If there is at least one opened tab, file will be opened in active tab, and its 
                    // content will be copied to the current active RichTextBox.
                    else
                    {
                        allFileNames[allRichTextBoxes.IndexOf(currentRichTextBox)] = fileName;
                        allStatuses.Add(true);
                    }
                    currentRichTextBox.Clear();
                    // Different files need different approaches on how to open those files in rich text box.
                    if (fileName.Contains(".txt"))
                    {
                        currentRichTextBox.Text = File.ReadAllText(fileName);
                    }
                    else if (fileName.Contains(".rtf"))
                    {
                        currentRichTextBox.LoadFile(fileName, RichTextBoxStreamType.RichText);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong, could not open the file: " +
                       Environment.NewLine + ex.Message);
                }
            }
        }


        private void SaveAllMenuButton_Click(object sender, EventArgs e)
        {
            RichTextBox realCurrentRichTextBox = currentRichTextBox;
            for (int i = 0; i < allRichTextBoxes.Count; i++)
            {
                if (allFileNames[i] != "new")
                {
                    currentRichTextBox = allRichTextBoxes[i];
                    SaveMenuButton_Click(sender, e);
                }
            }
            // Returning the value of currentRichTextBox.
            currentRichTextBox = realCurrentRichTextBox;
        }

        private void OpenInNewWindowMenuButton_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            newForm.OpenFileButton_Click(sender, e);
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf|Cs files(*.cs)|*.cs";
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf|Cs files(*.cs)|*.cs";
        }

        /// <summary>
        /// If user selects TabControl (makes it active), the program needs to know
        /// which tab Page is active in order to make the conforming richTextBox active and 
        /// assign this RichTextBox with the contextMenuStrip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            int index = allTabPages.IndexOf(tabControl1.SelectedTab);
            if (index != -1)
            {
                currentRichTextBox = allRichTextBoxes[index];
                currentRichTextBox.ContextMenuStrip = contextMenuStrip1;
            }

        }

        /// <summary>
        /// Program suggests to save unsaved files to user during closing of the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < allFileNames.Count; i++)
            {
                // Only files that has been opened are checked (they must have original file); if they were created
                // with option 'New', they will not be checked for unsaved changes.
                if (allFileNames[i] != "new")
                {
                    // if (status == true), it means that file has unsaved changes.
                    if (allStatuses[i] == false)
                    {
                        DialogResult result = MessageBox.Show($"Changes in {allTabPages[i].Text} were not saved." + Environment.NewLine +
                            "Would you like to save those changes before you leave?", "", MessageBoxButtons.YesNoCancel);
                        // User wants to stop program closing.
                        if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                        // User wants to save changes.
                        else if (result == DialogResult.Yes)
                        {
                            allTabPages[i].Select();
                            SaveMenuButton_Click(sender, e);
                        }
                    }
                }
            }
            // Saving info about files and settings.
            try
            {
                Settings.Default.allFileNames = new System.Collections.Specialized.StringCollection();
                System.Collections.Specialized.StringCollection allNotNewFiles = new System.Collections.Specialized.StringCollection();
                for (int i = 0; i < allFileNames.Count; i++)
                {
                    if (allFileNames[i] != "new")
                        allNotNewFiles.Add(allFileNames[i]);
                }
                Settings.Default["allFileNames"] = allNotNewFiles;
                Settings.Default["colorTheme"] = currentColorTheme;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save settings" + ex.Message);
            }
        }
    }
}

