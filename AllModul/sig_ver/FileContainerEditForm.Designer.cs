namespace FileContainerUI
{
    partial class FileContainerEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileContainerEditForm));
            this.fileContainerListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonopen = new System.Windows.Forms.Button();
            this.cancelButton = new FileContainerUI.Buttons.FlatButton();
            this.extractSelected = new FileContainerUI.Buttons.FlatButton();
            this.extractAllButton = new FileContainerUI.Buttons.FlatButton();
            this.addFilesButton = new FileContainerUI.Buttons.FlatButton();
            this.saveButton = new FileContainerUI.Buttons.FlatButton();
            this.SuspendLayout();
            // 
            // fileContainerListView
            // 
            this.fileContainerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.fileContainerListView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileContainerListView.HideSelection = false;
            this.fileContainerListView.Location = new System.Drawing.Point(19, 57);
            this.fileContainerListView.Margin = new System.Windows.Forms.Padding(4);
            this.fileContainerListView.Name = "fileContainerListView";
            this.fileContainerListView.Size = new System.Drawing.Size(873, 242);
            this.fileContainerListView.TabIndex = 0;
            this.fileContainerListView.UseCompatibleStateImageBehavior = false;
            this.fileContainerListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 491;
            // 
            // buttonopen
            // 
            this.buttonopen.Location = new System.Drawing.Point(19, 13);
            this.buttonopen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonopen.Name = "buttonopen";
            this.buttonopen.Size = new System.Drawing.Size(100, 28);
            this.buttonopen.TabIndex = 14;
            this.buttonopen.Text = "File";
            this.buttonopen.UseVisualStyleBackColor = true;
            this.buttonopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cancelButton.Location = new System.Drawing.Point(576, 327);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 43);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Вихід";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // extractSelected
            // 
            this.extractSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractSelected.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.extractSelected.Location = new System.Drawing.Point(19, 327);
            this.extractSelected.Margin = new System.Windows.Forms.Padding(4);
            this.extractSelected.Name = "extractSelected";
            this.extractSelected.Size = new System.Drawing.Size(157, 43);
            this.extractSelected.TabIndex = 5;
            this.extractSelected.Text = "Extract Selected";
            this.extractSelected.UseVisualStyleBackColor = true;
            this.extractSelected.Visible = false;
            this.extractSelected.Click += new System.EventHandler(this.extractSelected_Click);
            // 
            // extractAllButton
            // 
            this.extractAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractAllButton.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.extractAllButton.Location = new System.Drawing.Point(184, 327);
            this.extractAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.extractAllButton.Name = "extractAllButton";
            this.extractAllButton.Size = new System.Drawing.Size(107, 43);
            this.extractAllButton.TabIndex = 4;
            this.extractAllButton.Text = "Extract All";
            this.extractAllButton.UseVisualStyleBackColor = true;
            this.extractAllButton.Visible = false;
            this.extractAllButton.Click += new System.EventHandler(this.extractAllButton_Click);
            // 
            // addFilesButton
            // 
            this.addFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFilesButton.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.addFilesButton.Location = new System.Drawing.Point(330, 319);
            this.addFilesButton.Margin = new System.Windows.Forms.Padding(4);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(107, 58);
            this.addFilesButton.TabIndex = 2;
            this.addFilesButton.Text = "Вибір файлу";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.saveButton.Location = new System.Drawing.Point(461, 327);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 43);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Підпис";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FileContainerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 390);
            this.Controls.Add(this.buttonopen);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.extractSelected);
            this.Controls.Add(this.extractAllButton);
            this.Controls.Add(this.addFilesButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fileContainerListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileContainerEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Container Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView fileContainerListView;
        private Buttons.FlatButton saveButton;
        private Buttons.FlatButton addFilesButton;
        private Buttons.FlatButton extractAllButton;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private Buttons.FlatButton extractSelected;
        private Buttons.FlatButton cancelButton;
        private System.Windows.Forms.Button buttonopen;
    }
}