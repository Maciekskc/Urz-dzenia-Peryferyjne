namespace Analizator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.textBoxVoltage = new System.Windows.Forms.TextBox();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.textBoxCosinus = new System.Windows.Forms.TextBox();
            this.labelCosinus = new System.Windows.Forms.Label();
            this.textBoxActivePower = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Location = new System.Drawing.Point(185, 45);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(87, 20);
            this.labelVoltage.TabIndex = 0;
            this.labelVoltage.Text = "Voltage [V]";
            // 
            // textBoxVoltage
            // 
            this.textBoxVoltage.Location = new System.Drawing.Point(48, 68);
            this.textBoxVoltage.Name = "textBoxVoltage";
            this.textBoxVoltage.Size = new System.Drawing.Size(397, 26);
            this.textBoxVoltage.TabIndex = 1;
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Location = new System.Drawing.Point(48, 149);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(397, 26);
            this.textBoxCurrent.TabIndex = 3;
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(185, 126);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(85, 20);
            this.labelCurrent.TabIndex = 2;
            this.labelCurrent.Text = "Current [A]";
            // 
            // textBoxCosinus
            // 
            this.textBoxCosinus.Location = new System.Drawing.Point(48, 228);
            this.textBoxCosinus.Name = "textBoxCosinus";
            this.textBoxCosinus.Size = new System.Drawing.Size(397, 26);
            this.textBoxCosinus.TabIndex = 5;
            // 
            // labelCosinus
            // 
            this.labelCosinus.AutoSize = true;
            this.labelCosinus.Location = new System.Drawing.Point(185, 205);
            this.labelCosinus.Name = "labelCosinus";
            this.labelCosinus.Size = new System.Drawing.Size(84, 20);
            this.labelCosinus.TabIndex = 4;
            this.labelCosinus.Text = "Cosinus(fi)";
            // 
            // textBoxActivePower
            // 
            this.textBoxActivePower.Location = new System.Drawing.Point(48, 304);
            this.textBoxActivePower.Name = "textBoxActivePower";
            this.textBoxActivePower.Size = new System.Drawing.Size(397, 26);
            this.textBoxActivePower.TabIndex = 7;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(169, 281);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(127, 20);
            this.labelPower.TabIndex = 6;
            this.labelPower.Text = "Active Power [W]";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(48, 372);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(397, 26);
            this.textBoxFrequency.TabIndex = 9;
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(169, 349);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(108, 20);
            this.labelFrequency.TabIndex = 8;
            this.labelFrequency.Text = "Frequency Hz";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 432);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.textBoxActivePower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.textBoxCosinus);
            this.Controls.Add(this.labelCosinus);
            this.Controls.Add(this.textBoxCurrent);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.textBoxVoltage);
            this.Controls.Add(this.labelVoltage);
            this.Name = "MainForm";
            this.Text = "Analizator Parametrów Sieci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.TextBox textBoxVoltage;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.TextBox textBoxCosinus;
        private System.Windows.Forms.Label labelCosinus;
        private System.Windows.Forms.TextBox textBoxActivePower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.Label labelFrequency;
    }
}

