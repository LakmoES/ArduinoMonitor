using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor
{
    class PingProcessor
    {
        private string host;
        public long Ping { private set; get; }
        public long PingAvg { private set; get; }
        private long[] lastPingValue;
        private int k;
        public PingProcessor(string host = "google.com")
        {
            this.host = host;

            Ping = -1;
            PingAvg = -1;

            lastPingValue = new long[20];
            k = 0;
        }
        private void CalculateAvg(long newValue)
        {
            if (k < lastPingValue.Length - 1)
                ++k;
            else
                k = 0;

            lastPingValue[k] = newValue;
            long avg = 0;
            foreach (var l in lastPingValue)
                avg += l;
            PingAvg = avg / lastPingValue.Length;
        }
        public void Update()
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(host, 3000);
                if (reply != null)
                {
                    if (reply.Status == IPStatus.Success)
                    {
                        Ping = reply.RoundtripTime;
                        try
                        {
                            CalculateAvg(Ping);
                        }
                        catch { Ping = -100; }
                    }
                    else
                        Ping = -1;
                    //Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);

                }
                else
                    Ping = -1;
            }
            catch
            {
                Ping = -2;
            }
        }
    }
}
