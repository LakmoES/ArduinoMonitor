using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Net.NetworkInformation;

namespace ArduinoMonitor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyDebugFuncCOM();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void MyDebugFuncCOM()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach(var str in ports)
            {
                Debug.WriteLine(str);
            }
        }
    }
}
