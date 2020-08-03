using System;
using System.IO;
using System.Windows.Forms;

namespace ModernTextEditor
{
    public partial class Form1 : Form
    {
        private string path = "";
        public Form1()
        {

            InitializeComponent();

        }

        private readonly OpenFileDialog dialog = new OpenFileDialog();
        private readonly SaveFileDialog saveFileDialog = new SaveFileDialog();
        private readonly FontDialog fontDlg = new FontDialog();


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void exitPrompt()
        {
            DialogResult = MessageBox.Show("Do you want to save current file?",
                "MTE",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }


        private void fileNewButton_Click(object sender, EventArgs e)
        {
            if (TextInput.Text != "")
            {
                exitPrompt();

                if (DialogResult == DialogResult.Yes)
                {
                    saveasButton_Click(sender, e);
                    TextInput.Text = "";
                    path = "";
                }
                else if (DialogResult == DialogResult.No)
                {
                    TextInput.Text = "";
                    path = "";
                }
            }
        }
        #region Exit
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region OpenFile
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            dialog.Title = "Select a file";
            dialog.DefaultExt = ".txt";

            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    string filename = dialog.FileName;

                    string text = System.IO.File.ReadAllText(filename);

                    // Display the file contents by using a foreach loop.
                    TextInput.Text = text;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error at opening file " + ex, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region SaveFile

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string filename = dialog.FileName;
            string saveFile = dialog.SafeFileName;

            string text = TextInput.Text;

            File.WriteAllText(filename, text);

        }
        #endregion
        #region FontDialog

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fontDlg.ShowColor = true;
                fontDlg.ShowHelp = false;
                fontDlg.ShowApply = true;
                fontDlg.ShowEffects = true;
                fontDlg.ShowColor = false;
                fontDlg.ShowHelp = true;
                fontDlg.FontMustExist = true;
                fontDlg.ShowApply = false;
                if (fontDlg.ShowDialog() != DialogResult.Cancel)
                {

                    TextInput.Font = fontDlg.Font;

                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Error " + er, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region About

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form2 w = new Form2();
            w.Show();

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void VersionBT_Click(object sender, EventArgs e)
        {

        }

        private void saveasButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(path = saveFileDialog.FileName, TextInput.Text);
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WordWrapButton.Checked == true)
            {
                TextInput.WordWrap = false;
                TextInput.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Both;
                WordWrapButton.Checked = false;
            }
            else
            {
                TextInput.WordWrap = true;
                TextInput.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Vertical;
                WordWrapButton.Checked = true;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.Copy();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.SelectedText = "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextInput.SelectAll();
        }
    }

}