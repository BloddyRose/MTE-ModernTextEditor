using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ModernTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly OpenFileDialog dialog = new OpenFileDialog();
        private readonly FontDialog fontDlg = new FontDialog();

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }



        private void fileNewButton_Click(object sender, EventArgs e)
        {
            /*
            dialog.RestoreDirectory = true;

            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Create new file";
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string filename = dialog.FileName;

                try
                {
                    if (File.Exists(filename))
                    {
                        File.Delete(filename);
                    }

                    var file = File.Create(filename);
                    TextInput.Text = file.ToString();
                }
                catch (Exception erorr)
                {
                    // Code message
                    MessageBox.Show("Erorr at making " + erorr, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
             }
             */
                
            

       
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

            try
            {
                string filename = dialog.FileName;
                string saveFile = dialog.SafeFileName;

                string text = TextInput.Text;

                File.WriteAllText(filename, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr at saving file " + ex, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            MessageBox.Show("This is an modern notepad maded in C# by me for a little project the use of it is simple like old notepad!!", "About MTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Process.Start("");
        }
    }

}