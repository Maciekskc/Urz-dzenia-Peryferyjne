namespace Bloototh
{
    partial class AppForm
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
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBoxConnected = new System.Windows.Forms.ListBox();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.buttonPair = new System.Windows.Forms.Button();
            this.buttonUnpair = new System.Windows.Forms.Button();
            this.buttonSendFile = new System.Windows.Forms.Button();
            this.labelDevices = new System.Windows.Forms.Label();
            this.labelConnection = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(396, 44);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(224, 60);
            this.buttonFind.TabIndex = 0;
            this.buttonFind.Text = "Szukaj urządzeń";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // listBoxConnected
            // 
            this.listBoxConnected.FormattingEnabled = true;
            this.listBoxConnected.ItemHeight = 20;
            this.listBoxConnected.Location = new System.Drawing.Point(12, 211);
            this.listBoxConnected.Name = "listBoxConnected";
            this.listBoxConnected.Size = new System.Drawing.Size(378, 124);
            this.listBoxConnected.TabIndex = 2;
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 20;
            this.listBoxDevices.Location = new System.Drawing.Point(12, 44);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(378, 124);
            this.listBoxDevices.TabIndex = 4;
            // 
            // buttonPair
            // 
            this.buttonPair.Location = new System.Drawing.Point(396, 108);
            this.buttonPair.Name = "buttonPair";
            this.buttonPair.Size = new System.Drawing.Size(224, 60);
            this.buttonPair.TabIndex = 5;
            this.buttonPair.Text = "Paruj urządzenie";
            this.buttonPair.UseVisualStyleBackColor = true;
            this.buttonPair.Click += new System.EventHandler(this.buttonPair_Click);
            // 
            // buttonUnpair
            // 
            this.buttonUnpair.Location = new System.Drawing.Point(396, 275);
            this.buttonUnpair.Name = "buttonUnpair";
            this.buttonUnpair.Size = new System.Drawing.Size(224, 60);
            this.buttonUnpair.TabIndex = 6;
            this.buttonUnpair.Text = "Usuń sparowane urządzenie";
            this.buttonUnpair.UseVisualStyleBackColor = true;
            this.buttonUnpair.Click += new System.EventHandler(this.buttonUnpair_Click);
            // 
            // buttonSendFile
            // 
            this.buttonSendFile.Location = new System.Drawing.Point(396, 211);
            this.buttonSendFile.Name = "buttonSendFile";
            this.buttonSendFile.Size = new System.Drawing.Size(224, 60);
            this.buttonSendFile.TabIndex = 7;
            this.buttonSendFile.Text = "Wyślij plik na urządzenie";
            this.buttonSendFile.UseVisualStyleBackColor = true;
            this.buttonSendFile.Click += new System.EventHandler(this.buttonSendFile_Click);
            // 
            // labelDevices
            // 
            this.labelDevices.AutoSize = true;
            this.labelDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDevices.Location = new System.Drawing.Point(5, 4);
            this.labelDevices.Name = "labelDevices";
            this.labelDevices.Size = new System.Drawing.Size(180, 37);
            this.labelDevices.TabIndex = 8;
            this.labelDevices.Text = "Urządzenia";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConnection.Location = new System.Drawing.Point(5, 171);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(173, 37);
            this.labelConnection.TabIndex = 9;
            this.labelConnection.Text = "Połączone";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 346);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.labelDevices);
            this.Controls.Add(this.buttonSendFile);
            this.Controls.Add(this.buttonUnpair);
            this.Controls.Add(this.buttonPair);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.listBoxConnected);
            this.Controls.Add(this.buttonFind);
            this.Name = "AppForm";
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox listBoxConnected;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button buttonPair;
        private System.Windows.Forms.Button buttonUnpair;
        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelDevices;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

