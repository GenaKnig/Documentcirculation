namespace TcpSendFiles
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param message="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIPserver = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Clear_Listbox1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Location = new System.Drawing.Point(8, 45);
            this.buttonStartServer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(129, 28);
            this.buttonStartServer.TabIndex = 0;
            this.buttonStartServer.Text = "Запуск серверу";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 124);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 132);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(145, 45);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(120, 28);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Підключення";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(516, 175);
            this.buttonSendData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(183, 28);
            this.buttonSendData.TabIndex = 4;
            this.buttonSendData.Text = "Відправити документ";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Получение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Отправка";
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(339, 175);
            this.buttonAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(169, 28);
            this.buttonAddFile.TabIndex = 4;
            this.buttonAddFile.Text = "Добавити документ";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "IP адрес сервера";
            // 
            // textBoxIPserver
            // 
            this.textBoxIPserver.Location = new System.Drawing.Point(531, 48);
            this.textBoxIPserver.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPserver.Name = "textBoxIPserver";
            this.textBoxIPserver.Size = new System.Drawing.Size(132, 22);
            this.textBoxIPserver.TabIndex = 8;
            this.textBoxIPserver.Text = "127.0.0.1";
            this.textBoxIPserver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFileName
            // 
            this.labelFileName.Location = new System.Drawing.Point(8, 17);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(352, 20);
            this.labelFileName.TabIndex = 10;
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFileName);
            this.groupBox1.Location = new System.Drawing.Point(339, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(360, 39);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Стоп Сервер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_Clear_Listbox1
            // 
            this.button_Clear_Listbox1.Location = new System.Drawing.Point(304, 98);
            this.button_Clear_Listbox1.Name = "button_Clear_Listbox1";
            this.button_Clear_Listbox1.Size = new System.Drawing.Size(25, 23);
            this.button_Clear_Listbox1.TabIndex = 12;
            this.button_Clear_Listbox1.UseVisualStyleBackColor = true;
            this.button_Clear_Listbox1.Click += new System.EventHandler(this.button_Clear_Listbox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerToolStripMenuItem,
            this.PidToolStripMenuItem,
            this.VerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SerToolStripMenuItem
            // 
            this.SerToolStripMenuItem.Name = "SerToolStripMenuItem";
            this.SerToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.SerToolStripMenuItem.Text = "Сертифікат";
            this.SerToolStripMenuItem.Click += new System.EventHandler(this.SerToolStripMenuItem_Click);
            // 
            // PidToolStripMenuItem
            // 
            this.PidToolStripMenuItem.Name = "PidToolStripMenuItem";
            this.PidToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.PidToolStripMenuItem.Text = "Підпис";
            this.PidToolStripMenuItem.Click += new System.EventHandler(this.PidToolStripMenuItem_Click);
            // 
            // VerToolStripMenuItem
            // 
            this.VerToolStripMenuItem.Name = "VerToolStripMenuItem";
            this.VerToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.VerToolStripMenuItem.Text = "Перевірка підпису";
            this.VerToolStripMenuItem.Click += new System.EventHandler(this.VerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 372);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_Clear_Listbox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIPserver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonStartServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Документообіг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIPserver;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Clear_Listbox1;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerToolStripMenuItem;
    }
}

