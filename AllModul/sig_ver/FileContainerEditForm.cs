using BlakeSharp;
using BlakeSharpDemo;
using FileContainer;
using FileContainerUI.Waiter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FileContainerUI
{
    public partial class  FileContainerEditForm : Form
    {
        private bool _loadSucceed = true; //Flag to determine if container loaded successfuly
        private bool _isModifyingMode = false; //Flag to determine if user wants to modify(True) or create(False) new container
        private IContainerManager _containerManager = new ContainerManager();
        public List<ContainerEntry> _files = new List<ContainerEntry>();
        private string _containerName;
         public int i1 = 1;
        public FileContainerEditForm()
        {
            InitializeComponent();
        }

        public FileContainerEditForm(string containerName)
        {
            InitializeComponent();
            this._isModifyingMode = true;
            this.extractSelected.Visible = true;
            this.extractAllButton.Visible = true;
            _containerName = containerName;

            try
            {
                _files = _containerManager.GetListOfFilesFromContainer(_containerName);


                _files.ForEach(f =>
                {
                    this.fileContainerListView.Items.Add(new ListViewItem(f.Name));
                });
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Cannot read {0}", _containerName));
                _loadSucceed = false;
            }
        }
        public void ShowDialog()
        {
            if (_loadSucceed)
                base.ShowDialog();
            else
                this.Dispose();
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            string sec = "D:\\Bakalavrat\\Modul\\AllModul\\bin\\gesh\\Secret.txt";
            int startOffset1 = 0;
            if (_files.Count > 0)
            {

                startOffset1 = _files[_files.Count - 1].EndOffset;
            }
            if (sec == _containerName)
            {
                MessageBox.Show(string.Format("Cannot add {0} file, because it's file currently used for writing.\nPlease, choose another", _containerName));
            }
            else
            {
                ContainerEntry containerEntry = new ContainerEntry()
                {
                    Name = sec.Remove(0, sec.LastIndexOf('\\') + 1),
                    Path = sec,
                    Offset = startOffset1
                };

                if (!_files.Contains(containerEntry))
                {
                    startOffset1 += (int)new FileInfo(sec).Length;
                    containerEntry.EndOffset = startOffset1;

                    _files.Add(containerEntry);

                    fileContainerListView.Items.Add(new ListViewItem(containerEntry.Name));
                }

            }


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;
                string  gesh  = "MyTest2.txt"; 
                
                if (i1 == 1) { string strFilePath = fileNames[0];
                string path = strFilePath;

                try
                {


                    FileStream fsIn = new FileStream(strFilePath, FileMode.Open,
                        FileAccess.Read, FileShare.Read);
                    Blake512 blake512 = new Blake512();
                    byte[] pbHash = blake512.ComputeHash(fsIn);
                    fsIn.Close();
                    const string V = @"D:\Bakalavrat\Modul\FileContainer-master\FileContainerUI\bin\gesh\MyTest2.txt";
                    string path2 = V;
                    using (FileStream fs = File.Create(path2))
                    {

                        byte[] info = new UTF8Encoding(true).GetBytes(MemUtil.ByteArrayToHexString(pbHash));

                        fs.Write(info, 0, info.Length);


                    }

                    // Open the stream and read it back.
                    using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(MemUtil.ByteArrayToHexString(pbHash));
                            i1--;
                    }


                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }}

                 

                int startOffset = 0;

                if (_files.Count > 0)
                {
                    startOffset = _files[_files.Count - 1].EndOffset;
                }

                int initialFilesCount = _files.Count;
                
                foreach (string fileName in fileNames)
                {
                    if (fileName == _containerName)
                    {
                        MessageBox.Show(string.Format("Cannot add {0} file, because it's file currently used for writing.\nPlease, choose another", _containerName));
                    }
                    else
                    {
                        ContainerEntry containerEntry = new ContainerEntry()
                        {
                            Name = fileName.Remove(0, fileName.LastIndexOf('\\') + 1),
                            Path = fileName,
                            Offset = startOffset
                        };

                        if (!_files.Contains(containerEntry))
                        {
                            startOffset += (int)new FileInfo(fileName).Length;
                            containerEntry.EndOffset = startOffset;

                            _files.Add(containerEntry);
                           
                            fileContainerListView.Items.Add(new ListViewItem(containerEntry.Name));
                        }
                    }
                }
                 
                  

                if (_files.Count > initialFilesCount)
                {
                    this.saveButton.Enabled = true;

                    if (_isModifyingMode)
                    {
                        ExtractButtonsAreEnabled(false);
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string gesh = "D:\\Bakalavrat\\Modul\\AllModul\\bin\\gesh\\MyTest2.txt";
            //string sec = "D:\\Bakalavrat\\Modul\\AllModul\\bin\\gesh\\Secret.txt";
            if (!_isModifyingMode)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "container files (*.cntr)|*.cntr";
                saveFileDialog.FilterIndex = 0;
                const string V = @"D:\Bakalavrat\Modul\FileContainer-master\FileContainerUI\bin\gesh\MyTest2.txt";
                string path2 = V;
                int startOffset = 0;
                //int startOffset1 = 0;
                if (_files.Count > 0)
                {
                    startOffset = _files[_files.Count - 1].EndOffset;
                }
                //if (_files.Count > 0)
                //{
                   
                //    startOffset1 = _files[_files.Count-1].EndOffset;
                //}
                //if (sec == _containerName)
                //{
                //    MessageBox.Show(string.Format("Cannot add {0} file, because it's file currently used for writing.\nPlease, choose another", _containerName));
                //}
                //else
                //{
                //    ContainerEntry containerEntry = new ContainerEntry()
                //    {
                //        Name = sec.Remove(0, sec.LastIndexOf('\\') + 1),
                //        Path = sec,
                //        Offset = startOffset1
                //    };

                //    if (!_files.Contains(containerEntry))
                //    {
                //        startOffset += (int)new FileInfo(sec).Length;
                //        //containerEntry.EndOffset = startOffset1;

                //        _files.Add(containerEntry);

                //        fileContainerListView.Items.Add(new ListViewItem(containerEntry.Name));
                //    }

                //}
                if (gesh == _containerName)
                {
                    MessageBox.Show(string.Format("Cannot add {0} file, because it's file currently used for writing.\nPlease, choose another", _containerName));
                }
                else
                {
                    ContainerEntry containerEntry = new ContainerEntry()
                    {
                        Name = gesh.Remove(0, gesh.LastIndexOf('\\') + 1),
                        Path = gesh,
                        Offset = startOffset
                    };

                    if (!_files.Contains(containerEntry))
                    {
                        startOffset += (int)new FileInfo(gesh).Length;
                        containerEntry.EndOffset = startOffset;

                        _files.Add(containerEntry);

                        fileContainerListView.Items.Add(new ListViewItem(containerEntry.Name));
                    }

                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bool success = true;
                    WaiterForm waiter = new WaiterForm();
                    waiter.Show(() =>
                        {
                            string fileName = saveFileDialog.FileName;
                            
                            if (!_isModifyingMode)
                            {
                                //_files.ForEach(f =>
                                //{
                                //    this.fileContainerListView.Items.Add(new ListViewItem(f.Name));
                                //});
                                
                                success = _containerManager.CreateContainer(fileName, _files);
                            }
                            
                        });
                    if (success)
                        this.Dispose();
                    else
                        MessageBox.Show("Cannot write file to itself.\nPlease, choose another destination.");
                }
            }
            else
            {
                 WaiterForm waiter = new WaiterForm();
                 waiter.Show(() =>
                     {
                         _containerManager.AddToContainer(_containerName, _files);
                     });

                 ExtractButtonsAreEnabled(true);
            }

            saveButton.Enabled = false;
        }

        private void extractAllButton_Click(object sender, EventArgs e)
        {
            //ExtractAction(_files);
        }

        private void extractSelected_Click(object sender, EventArgs e)
        {

            if(fileContainerListView.SelectedItems.Count > 0)
            {
                List<ContainerEntry> selectedFiles = new List<ContainerEntry>();
                foreach (ListViewItem item in fileContainerListView.SelectedItems)
                {
                    selectedFiles.Add(_files.Find(f => f.Name == item.Text));
                }
                //ExtractAction(selectedFiles);
            }
        }

        //public void ExtractAction(List<ContainerEntry> files)
        //{
        //    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        //    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        List<ContainerEntry> selectedFiles = new List<ContainerEntry>();

        //        new WaiterForm()
        //            {
        //                Text = "Extracting your files from the container..."
        //            }.Show(() => _containerManager.ExtractFromContainer(_containerName, folderBrowserDialog.SelectedPath, files));
        //    }
        //}

        private void ExtractButtonsAreEnabled(bool expression)
        {
            this.extractSelected.Enabled = expression;
            this.extractAllButton.Enabled = expression;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            new FileContainerEditForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Filter = "container files (*.cntr)|*.cntr" };
            string password1 = "Kanabis9690909090";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] bytesToBeEncrypted = File.ReadAllBytes(openFileDialog.FileName);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password1);

                // Hash the password with SHA256
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

                byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

                string fileEncrypted = openFileDialog.FileName + "encrypted";

                File.WriteAllBytes(fileEncrypted, bytesEncrypted);
                MessageBox.Show("Файл успішно зашифровано!\n Файл збережено в папці <"
                    + fileEncrypted + ">");
            }
        }
        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
    }
}
