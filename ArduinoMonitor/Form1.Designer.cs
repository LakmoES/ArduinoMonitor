namespace ArduinoMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonSetComPort = new System.Windows.Forms.Button();
            this.groupBoxCOMPort = new System.Windows.Forms.GroupBox();
            this.numericUpDownCOMBitRate = new System.Windows.Forms.NumericUpDown();
            this.checkBoxComPortAutoDetection = new System.Windows.Forms.CheckBox();
            this.textBoxComPort = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelAutoStart = new System.Windows.Forms.Label();
            this.labelAutoStartCount = new System.Windows.Forms.Label();
            this.timerAutoStart = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownMessageInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDataSettings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxGPUTemp = new System.Windows.Forms.CheckBox();
            this.checkBoxCPUTemp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBoxPing = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxCOMPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCOMBitRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessageInterval)).BeginInit();
            this.groupBoxDataSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Interval = 500;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonSetComPort
            // 
            this.buttonSetComPort.Enabled = false;
            this.buttonSetComPort.Location = new System.Drawing.Point(64, 19);
            this.buttonSetComPort.Name = "buttonSetComPort";
            this.buttonSetComPort.Size = new System.Drawing.Size(75, 23);
            this.buttonSetComPort.TabIndex = 0;
            this.buttonSetComPort.Text = "Установить";
            this.buttonSetComPort.UseVisualStyleBackColor = true;
            this.buttonSetComPort.Click += new System.EventHandler(this.buttonSetComPort_Click);
            // 
            // groupBoxCOMPort
            // 
            this.groupBoxCOMPort.Controls.Add(this.numericUpDownCOMBitRate);
            this.groupBoxCOMPort.Controls.Add(this.checkBoxComPortAutoDetection);
            this.groupBoxCOMPort.Controls.Add(this.textBoxComPort);
            this.groupBoxCOMPort.Controls.Add(this.buttonSetComPort);
            this.groupBoxCOMPort.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCOMPort.Name = "groupBoxCOMPort";
            this.groupBoxCOMPort.Size = new System.Drawing.Size(204, 79);
            this.groupBoxCOMPort.TabIndex = 1;
            this.groupBoxCOMPort.TabStop = false;
            this.groupBoxCOMPort.Text = "COM порт";
            // 
            // numericUpDownCOMBitRate
            // 
            this.numericUpDownCOMBitRate.Location = new System.Drawing.Point(129, 53);
            this.numericUpDownCOMBitRate.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.numericUpDownCOMBitRate.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownCOMBitRate.Name = "numericUpDownCOMBitRate";
            this.numericUpDownCOMBitRate.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownCOMBitRate.TabIndex = 6;
            this.numericUpDownCOMBitRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // checkBoxComPortAutoDetection
            // 
            this.checkBoxComPortAutoDetection.AutoSize = true;
            this.checkBoxComPortAutoDetection.Checked = true;
            this.checkBoxComPortAutoDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxComPortAutoDetection.Location = new System.Drawing.Point(6, 51);
            this.checkBoxComPortAutoDetection.Name = "checkBoxComPortAutoDetection";
            this.checkBoxComPortAutoDetection.Size = new System.Drawing.Size(104, 17);
            this.checkBoxComPortAutoDetection.TabIndex = 2;
            this.checkBoxComPortAutoDetection.Text = "Автоматически";
            this.checkBoxComPortAutoDetection.UseVisualStyleBackColor = true;
            this.checkBoxComPortAutoDetection.CheckedChanged += new System.EventHandler(this.checkBoxComPortAutoDetection_CheckedChanged);
            // 
            // textBoxComPort
            // 
            this.textBoxComPort.Location = new System.Drawing.Point(6, 22);
            this.textBoxComPort.Name = "textBoxComPort";
            this.textBoxComPort.ReadOnly = true;
            this.textBoxComPort.Size = new System.Drawing.Size(52, 20);
            this.textBoxComPort.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(25, 253);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(119, 253);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelAutoStart
            // 
            this.labelAutoStart.AutoSize = true;
            this.labelAutoStart.Location = new System.Drawing.Point(138, 301);
            this.labelAutoStart.Name = "labelAutoStart";
            this.labelAutoStart.Size = new System.Drawing.Size(71, 13);
            this.labelAutoStart.TabIndex = 4;
            this.labelAutoStart.Text = "Старт через:";
            // 
            // labelAutoStartCount
            // 
            this.labelAutoStartCount.AutoSize = true;
            this.labelAutoStartCount.Location = new System.Drawing.Point(215, 301);
            this.labelAutoStartCount.Name = "labelAutoStartCount";
            this.labelAutoStartCount.Size = new System.Drawing.Size(13, 13);
            this.labelAutoStartCount.TabIndex = 5;
            this.labelAutoStartCount.Text = "0";
            // 
            // timerAutoStart
            // 
            this.timerAutoStart.Enabled = true;
            this.timerAutoStart.Interval = 1000;
            this.timerAutoStart.Tick += new System.EventHandler(this.timerAutoStart_Tick);
            // 
            // numericUpDownMessageInterval
            // 
            this.numericUpDownMessageInterval.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownMessageInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownMessageInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMessageInterval.Name = "numericUpDownMessageInterval";
            this.numericUpDownMessageInterval.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownMessageInterval.TabIndex = 6;
            this.numericUpDownMessageInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBoxDataSettings
            // 
            this.groupBoxDataSettings.Controls.Add(this.groupBox2);
            this.groupBoxDataSettings.Controls.Add(this.groupBox1);
            this.groupBoxDataSettings.Controls.Add(this.label1);
            this.groupBoxDataSettings.Controls.Add(this.numericUpDownMessageInterval);
            this.groupBoxDataSettings.Location = new System.Drawing.Point(12, 97);
            this.groupBoxDataSettings.Name = "groupBoxDataSettings";
            this.groupBoxDataSettings.Size = new System.Drawing.Size(200, 150);
            this.groupBoxDataSettings.TabIndex = 7;
            this.groupBoxDataSettings.TabStop = false;
            this.groupBoxDataSettings.Text = "Отправка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxGPUTemp);
            this.groupBox1.Controls.Add(this.checkBoxCPUTemp);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(73, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temp";
            // 
            // checkBoxGPUTemp
            // 
            this.checkBoxGPUTemp.AutoSize = true;
            this.checkBoxGPUTemp.Checked = true;
            this.checkBoxGPUTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGPUTemp.Location = new System.Drawing.Point(6, 42);
            this.checkBoxGPUTemp.Name = "checkBoxGPUTemp";
            this.checkBoxGPUTemp.Size = new System.Drawing.Size(49, 17);
            this.checkBoxGPUTemp.TabIndex = 9;
            this.checkBoxGPUTemp.Text = "GPU";
            this.checkBoxGPUTemp.UseVisualStyleBackColor = true;
            // 
            // checkBoxCPUTemp
            // 
            this.checkBoxCPUTemp.AutoSize = true;
            this.checkBoxCPUTemp.Checked = true;
            this.checkBoxCPUTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCPUTemp.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCPUTemp.Name = "checkBoxCPUTemp";
            this.checkBoxCPUTemp.Size = new System.Drawing.Size(48, 17);
            this.checkBoxCPUTemp.TabIndex = 8;
            this.checkBoxCPUTemp.Text = "CPU";
            this.checkBoxCPUTemp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Интервал (мс)";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "Arduino монитор";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Arduino monitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // checkBoxPing
            // 
            this.checkBoxPing.AutoSize = true;
            this.checkBoxPing.Checked = true;
            this.checkBoxPing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPing.Location = new System.Drawing.Point(6, 19);
            this.checkBoxPing.Name = "checkBoxPing";
            this.checkBoxPing.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPing.TabIndex = 10;
            this.checkBoxPing.Text = "Ping";
            this.checkBoxPing.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPing);
            this.groupBox2.Location = new System.Drawing.Point(85, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(73, 68);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 323);
            this.Controls.Add(this.groupBoxDataSettings);
            this.Controls.Add(this.labelAutoStartCount);
            this.Controls.Add(this.labelAutoStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxCOMPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arduino монитор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBoxCOMPort.ResumeLayout(false);
            this.groupBoxCOMPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCOMBitRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessageInterval)).EndInit();
            this.groupBoxDataSettings.ResumeLayout(false);
            this.groupBoxDataSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonSetComPort;
        private System.Windows.Forms.GroupBox groupBoxCOMPort;
        private System.Windows.Forms.CheckBox checkBoxComPortAutoDetection;
        private System.Windows.Forms.TextBox textBoxComPort;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelAutoStart;
        private System.Windows.Forms.Label labelAutoStartCount;
        private System.Windows.Forms.Timer timerAutoStart;
        private System.Windows.Forms.NumericUpDown numericUpDownCOMBitRate;
        private System.Windows.Forms.NumericUpDown numericUpDownMessageInterval;
        private System.Windows.Forms.GroupBox groupBoxDataSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxGPUTemp;
        private System.Windows.Forms.CheckBox checkBoxCPUTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPing;
    }
}

