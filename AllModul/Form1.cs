using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.NetworkInformation;
using System.Threading;
using System.Drawing;
using FileContainerUI;
using cryptOS;

///////////////////////////////////////////////////////////////////////////////
//
//  www.interestprograms.ru /программы, игры и их исходные коды/
//  Протокол TCP. Часть 2. Отправки файлов и сообщений по сети. 
//
///////////////////////////////////////////////////////////////////////////////

namespace TcpSendFiles
{
    public partial class Form1 : Form
    {
        TcpModule _tcpmodule = new TcpModule();
   
        public string GlobalHost;
        public string GlobalIP;


        public Form1()
        {
            InitializeComponent();

            _tcpmodule.Receive += new TcpModule.ReceiveEventHandler(_tcpmodule_Receive);
            _tcpmodule.Disconnected += new TcpModule.DisconnectedEventHandler(_tcpmodule_Disconnected);
            _tcpmodule.Connected += new TcpModule.ConnectedEventHandler(_tcpmodule_Connected);
            _tcpmodule.Accept += new TcpModule.AcceptEventHandler(_tcpmodule_Accept);
            string Host = System.Net.Dns.GetHostName();
            string IP = System.Net.Dns.GetHostByName(Host).AddressList[0].ToString();

            GlobalHost = Host;
            GlobalIP = IP;
            _tcpmodule.Parent = this;


            listBox1.HorizontalScrollbar = true;
        }
        
        void _tcpmodule_Accept(object sender)
        {
            ShowReceiveMessage("Клієнт " + GlobalHost + " " + GlobalIP);
        }

        void _tcpmodule_Connected(object sender, string result)
        {
            

            ShowReceiveMessage(result);
        }

        void _tcpmodule_Disconnected(object sender, string result)
        {
            ShowReceiveMessage(result);
        }

        void _tcpmodule_Receive(object sender, ReceiveEventArgs e)
        {

            if (e.sendInfo.message != null)
            {
                ShowReceiveMessage("Повідомлення: " + e.sendInfo.message);
            }

            if (e.sendInfo.filesize > 0)
            {
                ShowReceiveMessage("Файл: " + e.sendInfo.filename);
             

            }

        }

        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            _tcpmodule.StartServer();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            _tcpmodule.ConnectClient(textBoxIPserver.Text);
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(_tcpmodule.SendData);
            t.Start();
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _tcpmodule.SendFileName = dlg.FileName;
                labelFileName.Text = dlg.SafeFileName;
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _tcpmodule.CloseSocket();
        }

        // Код доступа к свойствам объектов главной формы  из других потоков

        delegate void UpdateReceiveDisplayDelegate(string message);
        public void ShowReceiveMessage(string message)
        {
            if (listBox1.InvokeRequired == true)
            {
                UpdateReceiveDisplayDelegate rdd = new UpdateReceiveDisplayDelegate(ShowReceiveMessage);

                // Данный метод вызывается в дочернем потоке,
                // ищет основной поток и выполняет делегат указанный в качестве параметра 
                // в главном потоке, безопасно обновляя интерфейс формы.
                Invoke(rdd, new object[] { message }); 
            }
            else
            {
                // Если не требуется вызывать метод Invoke, обратимся напрямую к элементу формы.
                listBox1.Items.Add( (listBox1.Items.Count + 1).ToString() +  ". " + message); 
            }
        }

        delegate void BackColorFormDelegate(Color color);
        public void ChangeBackColor(Color color)
        {
            if (this.InvokeRequired == true)
            {
                BackColorFormDelegate bcf = new BackColorFormDelegate(ChangeBackColor);

                // Данный метод вызывается в дочернем потоке,
                // ищет основной поток и выполняет делегат указанный в качестве параметра 
                // в главном потоке, безопасно обновляя интерфейс формы.
                Invoke(bcf, new object[] { color });
            }
            else
            {
                this.BackColor = color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _tcpmodule.StopServer();
            _tcpmodule.DisconnectClient();

        }

        private void button_Clear_Listbox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_Clear_TestboxSend_Click(object sender, EventArgs e)
        {
            //textBoxSend.Clear();
        }

        private void SerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mainForm newForm = new mainForm();
            //newForm.ShowDialog();
            new mainForm().ShowDialog();
        }

        private void PidToolStripMenuItem_Click(object sender, EventArgs e)
        { 

          new FileContainerEditForm().ShowDialog();
        }

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Verification().ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
