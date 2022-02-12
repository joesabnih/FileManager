using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fed = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fed.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fed.SelectedPath);
                    txtPath.Text = fed.SelectedPath;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtPath.Text = e.Url.LocalPath;
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string location = txtPath.Text;
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please browse to select a element to delete");
            }
            if (txtFolderName.Text == "")
            {
                MessageBox.Show("Please enter the Folder name");
            }
            else
            {
                string path = Path.Combine(location, txtFolderName.Text);
                if (!File.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Successfully Created");
                }
                else
                {
                    MessageBox.Show("Folder already Exist");
                }

            }
        }

        private void btnCreateTxt_Click(object sender, EventArgs e)
        {
            string location = txtPath.Text;
            string file = Path.Combine(location, txtFileName.Text);
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please browse to select Where file has been located");
            }
            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please enter the File name");
            }
            else
            {
                if (!File.Exists(file))
                {
                    var myFile = File.Create(file);
                    MessageBox.Show("Successfully Created" + txtFileName.Text);
                    myFile.Close();
                }
                else
                {
                    MessageBox.Show("Alredy Exist");
                }
            }
        }

        private void btnDelFolder_Click(object sender, EventArgs e)
        {

            if (txtPath.Text == "")
            {
                MessageBox.Show("Please browse yo select a element to delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sure", "No", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string location = txtPath.Text;

                    DeleteDir(location);

                    MessageBox.Show("Successfully Deleted");
                }
                else if (dialogResult == DialogResult.No)
                {
                    webBrowser.Focus();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please browse to select a element to delete");
            }
            if (txtFolderName.Text == "")
            {
                MessageBox.Show("Please enter the File name");
            }
            else
            {
                string location = txtPath.Text;
                string newName = txtFolderName.Text;
                FileSystem.RenameDirectory(location, newName);
                MessageBox.Show("File re-named Successfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fld = new OpenFileDialog();
            fld.Title = "Browse Text Files";
            fld.DefaultExt = "txt";

            if (fld.ShowDialog() == DialogResult.OK)
            {
                string txt = File.ReadAllText(fld.FileName);
                richtxt.Text = txt;
                txtPathFile.Text = fld.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPathFile.Text == "")
            {
                MessageBox.Show("please select file");
            }
            else
            {
                if (File.Exists(txtPathFile.Text))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(richtxt.Text);
                    MemoryStream ms = new MemoryStream(buffer);
                    FileStream file = new FileStream(txtPathFile.Text, FileMode.Create, FileAccess.Write);
                    ms.WriteTo(file);
                    file.Close();
                    ms.Close();
                    MessageBox.Show("Text Save Successfully ");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPathFile.Text == "")
            {
                MessageBox.Show("please select file");
            }
            else
            {
                File.Delete(txtPathFile.Text);
                richtxt.Text = "";
                MessageBox.Show("File Eliminated");
            }
        }

        private void btnFromMove_Click(object sender, EventArgs e)
        {
            GetFilePathFrom();
        }

        private void btnToMove_Click(object sender, EventArgs e)
        {
            string sourceDirec = txtPathFolder.Text;
            if (sourceDirec == "")
            {
                MessageBox.Show("Please selet the folder to Move");
            }
            else
            {
                using (FolderBrowserDialog fed = new FolderBrowserDialog() { Description = "Select your path" })
                {
                    if (fed.ShowDialog() == DialogResult.OK)
                    {
                        if (Directory.Exists(sourceDirec))
                        {
                            string file = Path.Combine(fed.SelectedPath, Path.GetFileName(sourceDirec));

                            if (!Directory.Exists(file))
                            {
                                Directory.Move(sourceDirec, file);
                                webBrowser.Url = new Uri(fed.SelectedPath);
                                MessageBox.Show("Directory moved");
                            }
                        }
                    }
                }
            }
        }

        private void btnFromCopy_Click(object sender, EventArgs e)
        {
            GetFilePathFrom();
        }

        private void btnTOCopy_Click(object sender, EventArgs e)
        {
            string sourceDirec = txtPathFolder.Text;
            if (sourceDirec == "")
            {
                MessageBox.Show("Please selet the folder to Copy");
            }
            else
            {
                using (FolderBrowserDialog fed = new FolderBrowserDialog() { Description = "Select your path" })
                {
                    if (fed.ShowDialog() == DialogResult.OK)
                    {
                        FileSystem.CopyDirectory(sourceDirec, fed.SelectedPath);
                        MessageBox.Show("Directory moved");

                    }
                }
            }
        }

        private void btnFromMoveText_Click(object sender, EventArgs e)
        {
            FileFromCopy();
        }

        private void btnToMoveText_Click(object sender, EventArgs e)
        {
            string sourceDirec = txtpathFileM.Text;
            if (sourceDirec == "")
            {
                MessageBox.Show("Please selet the folder to Move");
            }
            else
            {
                MoveTo(sourceDirec);
                MessageBox.Show("File moved");

            }
        }

        private void btnFromCopyText_Click(object sender, EventArgs e)
        {
            FileFromCopy();
        }

        private void btnToCopyText_Click(object sender, EventArgs e)
        {
            string sourceDirec = txtpathFileM.Text;
            if (sourceDirec == "")
            {
                MessageBox.Show("Please selet the folder to Move");
            }
            else
            {
                using (FolderBrowserDialog fed = new FolderBrowserDialog() { Description = "Select your path" })
                {
                    if (fed.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sourceDirec))
                        {
                            string file = Path.Combine(fed.SelectedPath, Path.GetFileName(sourceDirec));

                            if (!File.Exists(file))
                            {
                                File.Copy(sourceDirec, file);
                                webBrowser.Url = new Uri(fed.SelectedPath);
                                MessageBox.Show("File moved");

                            }
                        }
                    }
                }
            }
        }
        public void GetFilePathFrom()
        {
            using (FolderBrowserDialog fed = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fed.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fed.SelectedPath);
                    txtPathFolder.Text = fed.SelectedPath;
                }
            }
        }
        public void MoveTo(string sourceDirec)
        {
            using (FolderBrowserDialog fed = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fed.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sourceDirec))
                    {
                        string file = Path.Combine(fed.SelectedPath, Path.GetFileName(sourceDirec));

                        if (!File.Exists(file))
                        {
                            File.Move(sourceDirec, file);
                            webBrowser.Url = new Uri(fed.SelectedPath);
                        }
                    }
                }
            }
        }
        public void FileFromCopy()
        {
            OpenFileDialog fld = new OpenFileDialog();
            fld.Title = "Browse Text Files";
            fld.DefaultExt = "txt";

            if (fld.ShowDialog() == DialogResult.OK)
            {
                string txt = File.ReadAllText(fld.FileName);
                txtpathFileM.Text = fld.FileName;
            }
        }
        public static void DeleteDir(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dire in dirs)
            {
                DeleteDir(dire);
            }
            Directory.Delete(dir);

        }
    }
}
