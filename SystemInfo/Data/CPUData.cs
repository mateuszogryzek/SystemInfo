using System.Management;

namespace SystemInfo.Data
{
    internal class CPUData
    {
        public Dictionary<string,string> CPUDataDicionary = new();

        public void GetData()
        {
            ManagementObjectSearcher managementObjectSearcher = new("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (var obj in managementObjectSearcher.Get())
            {
                CPUDataDicionary.Add("name", Convert.ToString(obj["Name"]));
                CPUDataDicionary.Add("clockSpeed", Convert.ToString(obj["CurrentClockSpeed"]));
                CPUDataDicionary.Add("coreNumber", Convert.ToString(obj["NumberOfCores"]));
                CPUDataDicionary.Add("status", Convert.ToString(obj["Status"]));
            }
        }
    }
}
