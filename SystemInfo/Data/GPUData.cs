using System.Management;

namespace SystemInfo.Data
{
    internal class GPUData
    {
        public Dictionary<string, string> GPUDataDictionary = new();

        public void GetData()
        {
            ManagementObjectSearcher GPUObjectSearcher = new("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (var obj in GPUObjectSearcher.Get())
            {
                GPUDataDictionary.Add("name", Convert.ToString(obj["Name"]));
                GPUDataDictionary.Add("memory", Convert.ToString(obj["MaxMemorySupported"]));
                GPUDataDictionary.Add("driver", Convert.ToString(obj["DriverVersion"]));
                GPUDataDictionary.Add("status", Convert.ToString(obj["Status"]));
            }
        }
    }
}
