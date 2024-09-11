using System.Runtime.CompilerServices;

namespace connectionPCB
{
    partial class Form1
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
            this.buttonScanPorts = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listBoxAvailablePorts = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelFirmwareVersion = new System.Windows.Forms.Label();
            this.buttonGetFirmwareVersion = new System.Windows.Forms.Button();
            this.labelRange = new System.Windows.Forms.Label();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLightValue = new System.Windows.Forms.NumericUpDown();
            this.buttonSetLight = new System.Windows.Forms.Button();
            this.buttonTurnOff = new System.Windows.Forms.Button();
            this.labelGetLightValue = new System.Windows.Forms.Label();
            this.timerGetParameters = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScanPorts
            // 
            this.buttonScanPorts.AutoSize = true;
            this.buttonScanPorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScanPorts.Location = new System.Drawing.Point(12, 12);
            this.buttonScanPorts.Name = "buttonScanPorts";
            this.buttonScanPorts.Size = new System.Drawing.Size(95, 23);
            this.buttonScanPorts.TabIndex = 0;
            this.buttonScanPorts.Text = "Scan COM ports";
            this.buttonScanPorts.UseVisualStyleBackColor = true;
            this.buttonScanPorts.Click += new System.EventHandler(this.scanPortsButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // listBoxAvailablePorts
            // 
            this.listBoxAvailablePorts.FormattingEnabled = true;
            this.listBoxAvailablePorts.Location = new System.Drawing.Point(1, 41);
            this.listBoxAvailablePorts.Name = "listBoxAvailablePorts";
            this.listBoxAvailablePorts.Size = new System.Drawing.Size(120, 95);
            this.listBoxAvailablePorts.Sorted = true;
            this.listBoxAvailablePorts.TabIndex = 2;
            this.listBoxAvailablePorts.SelectedIndexChanged += new System.EventHandler(this.allowConnection);
            // 
            // buttonConnect
            // 
            this.buttonConnect.AutoSize = true;
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(22, 142);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelFirmwareVersion
            // 
            this.labelFirmwareVersion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFirmwareVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFirmwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirmwareVersion.Location = new System.Drawing.Point(142, 41);
            this.labelFirmwareVersion.Name = "labelFirmwareVersion";
            this.labelFirmwareVersion.Size = new System.Drawing.Size(646, 23);
            this.labelFirmwareVersion.TabIndex = 4;
            // 
            // buttonGetFirmwareVersion
            // 
            this.buttonGetFirmwareVersion.AutoSize = true;
            this.buttonGetFirmwareVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetFirmwareVersion.Enabled = false;
            this.buttonGetFirmwareVersion.Location = new System.Drawing.Point(145, 11);
            this.buttonGetFirmwareVersion.Name = "buttonGetFirmwareVersion";
            this.buttonGetFirmwareVersion.Size = new System.Drawing.Size(120, 25);
            this.buttonGetFirmwareVersion.TabIndex = 5;
            this.buttonGetFirmwareVersion.Text = "Get Firmware version";
            this.buttonGetFirmwareVersion.UseVisualStyleBackColor = true;
            this.buttonGetFirmwareVersion.Click += new System.EventHandler(this.buttonGetFirmwareVersion_Click);
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(142, 88);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(39, 13);
            this.labelRange.TabIndex = 7;
            this.labelRange.Text = "Range";
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.Enabled = false;
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxRange.Location = new System.Drawing.Point(142, 104);
            this.comboBoxRange.MaxDropDownItems = 6;
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(37, 21);
            this.comboBoxRange.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Value";
            // 
            // numericUpDownLightValue
            // 
            this.numericUpDownLightValue.Enabled = false;
            this.numericUpDownLightValue.Location = new System.Drawing.Point(185, 104);
            this.numericUpDownLightValue.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDownLightValue.Name = "numericUpDownLightValue";
            this.numericUpDownLightValue.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownLightValue.TabIndex = 9;
            // 
            // buttonSetLight
            // 
            this.buttonSetLight.Enabled = false;
            this.buttonSetLight.Location = new System.Drawing.Point(266, 101);
            this.buttonSetLight.Name = "buttonSetLight";
            this.buttonSetLight.Size = new System.Drawing.Size(75, 23);
            this.buttonSetLight.TabIndex = 10;
            this.buttonSetLight.Text = "SET LIGHT";
            this.buttonSetLight.UseVisualStyleBackColor = true;
            this.buttonSetLight.Click += new System.EventHandler(this.setLight);
            // 
            // buttonTurnOff
            // 
            this.buttonTurnOff.Enabled = false;
            this.buttonTurnOff.Location = new System.Drawing.Point(347, 101);
            this.buttonTurnOff.Name = "buttonTurnOff";
            this.buttonTurnOff.Size = new System.Drawing.Size(75, 23);
            this.buttonTurnOff.TabIndex = 11;
            this.buttonTurnOff.Text = "TURN OFF";
            this.buttonTurnOff.UseVisualStyleBackColor = true;
            // 
            // labelGetLightValue
            // 
            this.labelGetLightValue.AutoSize = true;
            this.labelGetLightValue.Location = new System.Drawing.Point(446, 107);
            this.labelGetLightValue.Name = "labelGetLightValue";
            this.labelGetLightValue.Size = new System.Drawing.Size(35, 13);
            this.labelGetLightValue.TabIndex = 12;
            this.labelGetLightValue.Text = "label2";
            // 
            // timerGetParameters
            // 
            this.timerGetParameters.Interval = 1000;
            this.timerGetParameters.Tick += new System.EventHandler(this.timerGetParameters_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGetLightValue);
            this.Controls.Add(this.buttonTurnOff);
            this.Controls.Add(this.buttonSetLight);
            this.Controls.Add(this.numericUpDownLightValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.comboBoxRange);
            this.Controls.Add(this.buttonGetFirmwareVersion);
            this.Controls.Add(this.labelFirmwareVersion);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.listBoxAvailablePorts);
            this.Controls.Add(this.buttonScanPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "SEM Conf";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLightValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonScanPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox listBoxAvailablePorts;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelFirmwareVersion;
        private System.Windows.Forms.Button buttonGetFirmwareVersion;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.ComboBox comboBoxRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLightValue;
        private System.Windows.Forms.Button buttonSetLight;
        private System.Windows.Forms.Button buttonTurnOff;
        private System.Windows.Forms.Label labelGetLightValue;
        private System.Windows.Forms.Timer timerGetParameters;
    }
}

