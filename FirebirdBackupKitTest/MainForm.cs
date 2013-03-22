using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using FirebirdBackupKit;

namespace FirebirdBackupKitTest
{
    public partial class MainForm : Form
    {

        string fdbFilter = "FDB files|*.fdb";
        string fbkFilter = "FBK files|*.fbk";

        public MainForm()
        {
            InitializeComponent();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var backupKit = new BackupKit(usernameBox.Text, passwordBox.Text);

                backupKit.Backup(backupSrcBox.Text, backupDestBox.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void restoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var backupKit = new BackupKit(usernameBox.Text, passwordBox.Text);

                backupKit.Restore(restoreSrcBox.Text, restoreDestBox.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void copyBtn_Click(object sender, EventArgs e)
        {


            try
            {

                var backupKit = new BackupKit(usernameBox.Text, passwordBox.Text);

                backupKit.Copy(copySrcBox.Text, copyDestBox.Text);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void backupSrcBtn_Click(object sender, EventArgs e)
        {

            openFileDiag.Filter = fdbFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Backup source";
            openFileDiag.CheckFileExists = true;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                backupSrcBox.Text = openFileDiag.FileName;

        }

        private void backupDestBtn_Click(object sender, EventArgs e)
        {
           
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Backup destination";
            openFileDiag.CheckFileExists = false;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                backupDestBox.Text = openFileDiag.FileName;
        }

        private void restoreSrcBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Restore database source";
            openFileDiag.CheckFileExists = true;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreSrcBox.Text = openFileDiag.FileName;
        }

        private void restoreDestBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Restore database destination";
            openFileDiag.CheckFileExists = false;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreDestBox.Text = openFileDiag.FileName;
        }

        private void copySrcBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fdbFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Copy database source";
            openFileDiag.CheckFileExists = true;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                copySrcBox.Text = openFileDiag.FileName;
        }

        private void copyDestBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Copy database destination";
            openFileDiag.CheckFileExists = false;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                copyDestBox.Text = openFileDiag.FileName;
        }









    }
}
