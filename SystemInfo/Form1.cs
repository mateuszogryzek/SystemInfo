namespace SystemInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.CPUData cpuData = new(); cpuData.GetData();
                CPUNameLabel.Text = cpuData.CPUDataDicionary["name"];
                clockSpeedLabel.Text = "Clock Speed: " + cpuData.CPUDataDicionary["clockSpeed"] + " MHz";
                coreNumberLabel.Text = "Cores: " + cpuData.CPUDataDicionary["coreNumber"];
                CPUStatusLabel.Text = "Status: " + cpuData.CPUDataDicionary["status"];

            Data.GPUData gpuData = new(); gpuData.GetData();
                GPUNameLabel.Text = gpuData.GPUDataDictionary["name"];
                memoryLabel.Text = "Memory: " + gpuData.GPUDataDictionary["memory"];
                driverLabel.Text = "Driver: " + gpuData.GPUDataDictionary["driver"];
                GPUStatusLabel.Text = "Status: " + gpuData.GPUDataDictionary["status"];

            Data.SystemData systemData = new(); systemData.GetData();
                userNameLabel.Text = "User Name: " + systemData.SystemDataDictionary["userName"];
                systemVersionLabel.Text = "OS Version: " + systemData.SystemDataDictionary["systemVersion"];
                computerNameLabel.Text = "Computer Name: " + systemData.SystemDataDictionary["computerName"];
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For any feedback:\n\nmateusz.ogryzek@icloud.com", "About SystemInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            toolStripTimeLabel.Text = "" + time;
        }
    }
}