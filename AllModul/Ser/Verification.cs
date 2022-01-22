using BlakeSharp;
using BlakeSharpDemo;
using cryptOS;
using FileContainer;
using FileContainerUI;
using FileContainerUI.Waiter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TcpSendFiles
{
    public partial class Verification : Form
    {
        private  List<ContainerEntry> _files = new List<ContainerEntry>();
        public   string _containerName;
        private IContainerManager _containerManager = new ContainerManager();
        //RSA rsa;
        public Verification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                FileContainerEditForm1(openFileDialog.FileName); 
                txtFile.Text = openFileDialog.FileName;
                ExtractAction(_files);
            }
        }

        public   void FileContainerEditForm1(string containerName)
        {


            _containerName = containerName;

            try
            {
                _files = _containerManager.GetListOfFilesFromContainer(_containerName);


                //_files.ForEach(f =>
                //{
                //    this.fileContainerListView.Items.Add(new ListViewItem(f.Name));
                //});
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Cannot read {0}", _containerName));
                //_loadSucceed = false;
            }
        }
        private void ExtractAction(List<ContainerEntry> files)
        {
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string path = @"D:\Bakalavrat\Modul\AllModul\bin\Debug";
           
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            

            List<ContainerEntry> selectedFiles = new List<ContainerEntry>();

                new WaiterForm()
                {
                    Text = "Extracting your files from the container..."

                }.Show(() => _containerManager.ExtractFromContainer(_containerName, path, files));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"D:\Bakalavrat\Modul\AllModul\bin\Test";
            string fileName = "Secret.txt";
            string fullPath;

            string openedFile1 = @"D:\Bakalavrat\Modul\AllModul\bin\Test\MyTest2.txt";
            string[] allfiles = Directory.GetFiles(path, "*.pdf");
            string filename = allfiles[0];
            FileStream fsIn = new FileStream(filename, FileMode.Open,
                       FileAccess.Read, FileShare.Read);
            Blake512 blake512 = new Blake512();
            byte[] pbHash = blake512.ComputeHash(fsIn);
            fsIn.Close();
            byte[] info = new UTF8Encoding(true).GetBytes(MemUtil.ByteArrayToHexString(pbHash));
            byte[] byteText = Helper.readBytes(openedFile1);
            if (info == byteText)
            {
                MessageBox.Show("Документ було змінено");
            }
            else
            {
                fullPath = Path.GetFullPath(fileName);
                string text = System.IO.File.ReadAllText(fullPath, System.Text.Encoding.GetEncoding(1251));
            txtText.Text = text; 
            }
           


            //byte[] byteText = Helper.readBytes(openedFile);
            //byte[] decryptedText;
            //System.IO.File.AppendAllText(@"D:/Bakalavrat/Modul/AllModul/bin/Test/Secret.txt", txtText.Text);



            //            //string decryptedString;
            ////privatni_kljuc.txt javni_kljuc.txt
            //            try
            //            {
            //                string text = "";
            //                StreamReader sr = new StreamReader("D:/Bakalavrat/Modul/AllModul/bin/Test/privatni_kljuc.txt");
            //                text = sr.ReadToEnd();
            //                sr.Close();

            //                //RSA.rsaCrypto.FromXmlString(text);
            //                decryptedText = rsa.decrypt(Convert.FromBase64String(encryptedText), RSA.rsaCrypto.ExportParameters(true), false);
            //                //Helper.writeToFile(openedFile, encoding.GetString(decryptedText));
            //                txtText.Text = Encoding.Unicode.GetString(decryptedText);
            //            }
            //            catch
            //            {
            //                MessageBox.Show("Invalid base64 length, or wrong file.");
            //            }
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Dec_Click(object sender, EventArgs e)
        {
            string file;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                textBox1.Text = openFileDialog1.FileName;
                string password = "Kanabis9690909090";

                byte[] bytesToBeDecrypted = File.ReadAllBytes(file);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

                string fileEncrypted = file.Remove(file.Length - 9);
                File.WriteAllBytes(fileEncrypted, bytesDecrypted);
                MessageBox.Show("Файл розшифровано");
            }
            else
            {
                MessageBox.Show("No file Choosen!");
            }
        }
        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
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

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }
    }
}

