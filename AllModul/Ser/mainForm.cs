using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace cryptOS
{
    public partial class mainForm : Form
    {
        UTF8Encoding encoding;
        
        RSA rsa;
        string openedFile;
        public mainForm()
        {
           
            rsa = new RSA();
            encoding = new UTF8Encoding();
            
            InitializeComponent();
            
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string hash = "";
            Tuple<string, string, string> fileInfo = Helper.openFile();
            if (fileInfo.Item1 != "" || fileInfo.Item2 != "" || fileInfo.Item3 != "")
            {
                //hash = Helper.createHashFromFile(fileInfo.Item3);
            }
            openedFile = fileInfo.Item3;
            txtFile.Text = fileInfo.Item3;
          
            //txtText.Text = fileInfo.Item1;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string text = Helper.readFromFile(openedFile);
            byte[] byteText = Helper.readBytes(openedFile);
            byte[] encryptedText;
            RSA.generateRSAKeys();
            try
                {
                    RSA.rsaCrypto.FromXmlString(Helper.readFromFile(Helper.appPath + "\\javni_kljuc.txt"));
                    encryptedText = rsa.encrypt(byteText, RSA.rsaCrypto.ExportParameters(false), false);
                    Helper.writeToFile(openedFile, Convert.ToBase64String(encryptedText));
                    //txtText.Text = Convert.ToBase64String(encryptedText);
                    
                }
                catch
                {
                    MessageBox.Show("Invalid text format!");
                }
            
           
        }

        

     

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = Helper.readFromFile(openedFile);
            byte[] encryptedByteText = Helper.readBytes(openedFile);
            byte[] decryptedText;
           //string decryptedString;
           
                try
                {
                    RSA.rsaCrypto.FromXmlString(Helper.readFromFile(Helper.appPath + "\\privatni_kljuc.txt"));
                    decryptedText = rsa.decrypt(Convert.FromBase64String(encryptedText), RSA.rsaCrypto.ExportParameters(true), false);
                    Helper.writeToFile(openedFile, encoding.GetString(decryptedText));
                    //txtText.Text = Encoding.UTF8.GetString(decryptedText);
                }
                catch
                {
                    MessageBox.Show("Invalid base64 length, or wrong file.");
                }

            
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            const string V = @"D:\Bakalavrat\Modul\AllModul\bin\Debug\Mytest.txt";
            string path = V;
            string serti0, serti1, serti2, serti3;

            serti0 = textBoxPib.Text;
            serti1 = textBoxNaselPynkt.Text;
            serti2 = textBoxObl.Text;
            serti3 = textBoxEmail.Text;
            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(path))
            {

                byte[] info = new UTF8Encoding(true).GetBytes(serti0);

                fs.Write(info, 0, info.Length);


            }

            // Open the stream and read it back.
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(serti0);
                sw.WriteLine(serti1);
            }

            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(serti2);
                sw.Write(serti3);


                MessageBox.Show("Сертифікат записано");
            }
            Dec();
            txtFile.Text = path;
            const string V1 = @"D:\Bakalavrat\Modul\AllModul\bin\gesh\Secret.txt";
            string path1 = V1;
            string serti01, serti02, serti03, serti04;

            serti01 = textBoxPib.Text;
            serti02 = textBoxNaselPynkt.Text;
            serti03 = textBoxObl.Text;
            serti04 = textBoxEmail.Text;
            // Create the file, or overwrite if the file exists.
            using (FileStream fs1 = File.Create(path1))
            {

                byte[] info = new UTF8Encoding(true).GetBytes(serti0);

                fs1.Write(info, 0, info.Length);


            }

            // Open the stream and read it back.
            using (StreamWriter sw = new StreamWriter(path1, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(serti01);
                sw.WriteLine(serti02);
            }

            using (StreamWriter sw = new StreamWriter(path1, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(serti03);
                sw.Write(serti04);
                MessageBox.Show("Сертифікат записано");
            }
        }
        private  void Dec()
        {
            string openedFile = @"D:\Bakalavrat\Modul\AllModul\bin\gesh\Secret.txt";
            string text = Helper.readFromFile(openedFile);
            byte[] byteText = Helper.readBytes(openedFile);
            byte[] encryptedText;
            RSA.generateRSAKeys();
            try
            {
                RSA.rsaCrypto.FromXmlString(Helper.readFromFile(Helper.appPath + "\\javni_kljuc.txt"));
                encryptedText = rsa.encrypt(byteText, RSA.rsaCrypto.ExportParameters(false), false);
                Helper.writeToFile(openedFile, Convert.ToBase64String(encryptedText));
                //txtText.Text = Convert.ToBase64String(encryptedText);

            }
            catch
            {
                MessageBox.Show("Invalid text format!");
            }
        }

    }
}
