namespace SystemInfo.Data
{
    internal class SystemData
    {
        public Dictionary<string, string> SystemDataDictionary = new();

        public void GetData()
        {
            SystemDataDictionary.Add("systemVersion", Environment.OSVersion.ToString());
            SystemDataDictionary.Add("userName", Environment.UserName.ToString());
            SystemDataDictionary.Add("computerName", Environment.MachineName.ToString());
        }
    }
}
