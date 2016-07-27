using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Hardware;

namespace ArduinoMonitor
{
    class TempProcessor
    {
        public float CPU { private set; get; }
        public float GPU { private set; get; }
        public float CPUmax { private set; get; }
        public float GPUmax { private set; get; }
        private Computer comp;
        public TempProcessor()
        {
            CPU = -1;
            GPU = -1;
            CPUmax = CPU;
            GPUmax = GPU;
            Init();
        }
        private void Init()
        {
            comp = new Computer() { CPUEnabled = true, GPUEnabled = true };
        }
        public void Update()
        {
            comp.Open();
            foreach (IHardware hw in comp.Hardware)
            {
                if (hw.HardwareType == HardwareType.CPU)
                {
                    hw.Update();
                    foreach (ISensor s in hw.Sensors)
                    {
                        if (s.SensorType == SensorType.Temperature)
                        {
                            if (s.Value != null)
                            {
                                CPU = s.Value ?? -1.0f;
                                CPUmax = CPU > CPUmax ? CPU : CPUmax;
                            }
                        }
                    }
                }

                if (hw.HardwareType == HardwareType.GpuNvidia)
                {
                    hw.Update();
                    foreach (ISensor s in hw.Sensors)
                    {
                        if (s.SensorType == SensorType.Temperature)
                        {
                            if (s.Value != null)
                            {
                                GPU = s.Value ?? -1.0f;
                                GPUmax = GPU > GPUmax ? GPU : GPUmax;
                            }
                        }
                    }
                }
            }
            comp.Close();
        }
    }
}
