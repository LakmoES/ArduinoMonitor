using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ArduinoMonitor
{
    public partial class Form1 : Form
    {
        private int startDelay;
        private SerialPort COMport;
        TempProcessor tempProcessor;
        PingProcessor pingProcessor;
        public Form1()
        {
            InitializeComponent();

            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);

            startDelay = 2;

            labelAutoStartCount.Text = (startDelay + 1).ToString();

            tempProcessor = new TempProcessor();
            pingProcessor = new PingProcessor("google.com");
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            try
            {
                tempProcessor.Update();
                
                string messageStr = "";
                if (checkBoxCPUTemp.Checked)
                    messageStr += "CPU: {0}'";
                if (checkBoxGPUTemp.Checked)
                {
                    if (messageStr.Length > 1) //отступ в случае, если там уже что-то было
                        messageStr += " ";
                    messageStr += "GPU: {1}'";
                }
                if (checkBoxPing.Checked)
                {
                    pingProcessor.Update();
                    if (messageStr.Length > 1) //перенос строки в случае, если там уже что-то было
                        messageStr += "|";
                    messageStr += "P: {2} ms";
                    messageStr += " ~ {3} ms";
                }
                messageStr += "&";

                COMport.Write(String.Format(messageStr, tempProcessor.CPU, tempProcessor.GPU, pingProcessor.Ping, pingProcessor.PingAvg));
            }
            catch (Exception ex)
            {
                Stop();
                MessageBox.Show("Произошла ошибка во время отправки данных.\r\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxComPortAutoDetection_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComPort.ReadOnly = checkBoxComPortAutoDetection.Checked;
            buttonSetComPort.Enabled = !checkBoxComPortAutoDetection.Checked;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            if (timerAutoStart.Enabled)
            {
                BreakAutoStartTimer();
            }

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            this.groupBoxCOMPort.Enabled = true;
            this.groupBoxDataSettings.Enabled = true;

            timerMain.Stop();
        }

        private void timerAutoStart_Tick(object sender, EventArgs e)
        {
            if (startDelay >= 0)
            {
                this.labelAutoStartCount.Text = startDelay.ToString();
                --startDelay;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                BreakAutoStartTimer();
                Start();
            }
        }
        private void BreakAutoStartTimer()
        {
            timerAutoStart.Stop();
            labelAutoStartCount.Text = "-";
            labelAutoStart.Visible = false;
            labelAutoStartCount.Visible = false;
        }

        private void Start()
        {
            if (checkBoxComPortAutoDetection.Checked)
                AutoDetectCOMPort();

            try
            {
                if (COMport == null)
                    throw new NullReferenceException("Порт не указан.");
                if (!this.COMport.IsOpen)
                    this.COMport.Open();

                this.timerMain.Interval = Convert.ToInt32(this.numericUpDownMessageInterval.Value);
                this.timerMain.Start();

                this.buttonStart.Enabled = false;
                this.buttonStop.Enabled = true;
                this.groupBoxCOMPort.Enabled = false;

                this.groupBoxDataSettings.Enabled = false;
            }
            catch(Exception ex) { MessageBox.Show("Не удалось запустить главный цикл!\r\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCOMPort();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void buttonSetComPort_Click(object sender, EventArgs e)
        {
            try
            {
                this.COMport = new SerialPort(this.textBoxComPort.Text, Convert.ToInt32(this.numericUpDownCOMBitRate.Value));
                this.COMport.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неверно указан COM порт!\r\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (COMport != null) CloseCOMPort();
            }
        }

        private void AutoDetectCOMPort()
        {
            if (COMport != null)
                CloseCOMPort();

            string[] ports = SerialPort.GetPortNames();
            foreach (var str in ports)
            {
                try
                {
                    this.COMport = new SerialPort(str, Convert.ToInt32(this.numericUpDownCOMBitRate.Value));
                    this.COMport.Open();

                    this.textBoxComPort.Text = this.COMport.PortName;

                    //MessageBox.Show("Успех", "кк");
                    break;
                }
                catch { }
                //catch (Exception ex) { MessageBox.Show("Не удалось автоматически выбрать COM порт.\r\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); Stop(); }
            }
        }

        private void CloseCOMPort()
        {
            if (COMport == null) //nothing to close
                return;
            try
            {
                if (COMport.IsOpen)
                    COMport.Write(";Closed&");
                int k = 0;
                while (COMport.IsOpen && k < 10)
                {
                    Thread.Sleep(k * 10);

                    this.COMport.Close();
                    ++k;

                    System.Diagnostics.Debug.WriteLine(String.Format("Try to close {0} #{1}", COMport.PortName, k));
                }

                if (COMport.IsOpen)
                    MessageBox.Show("Не удалось правильно закрыть COM порт", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка во время закрытия COM порта\r\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
