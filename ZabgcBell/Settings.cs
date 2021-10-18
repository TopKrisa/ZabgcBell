using System;
using System.Windows.Forms;
using Helper;
using System.IO;

namespace ZabgcBell
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            trackBar1.Scroll += (s, e) =>
            {
                label5.Text = trackBar1.Value.ToString();
            };
        }
        private static string Path= Directory.GetCurrentDirectory()+ @"\Resources\" + "Duration_cfg.txt";
        public static string Pathcheckdur= Directory.GetCurrentDirectory() + @"\Resources\"+ "Checkercfg.txt";

        public static string duration;
        private static string data;
        private void Settings_Load(object sender, EventArgs e)
        {
            ConfigClass configClass = new ConfigClass();
            configClass.ReadCfg(Path);
            label1.Text = configClass.retcfg;
            duration = configClass.retcfg; 
            trackBartime.Value = Convert.ToInt32(duration);
            trackBar1.Value = Convert.ToInt32(configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "VolumeValue.txt"));
            label5.Text = trackBar1.Value.ToString();
            if(configClass.ReadCfg(Pathcheckdur) == "1")
            {
                checkBox1.Checked = true;

            }
            else if(configClass.ReadCfg(Pathcheckdur) == "0")
            {
                checkBox1.Checked = false;
            }
            Weeks.SelectedIndex=Convert.ToInt32(configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "SemesterValue.txt"));
            int IndexPreset;
            ChoiseOfPreSet.SelectedIndex = IndexPreset = Convert.ToInt32(configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "BellSetting.txt"));
            if(IndexPreset == 0)
            {
                label3.Text = "Длительность громкого звонка";
            }
            else if(IndexPreset == 1)
            {
                label3.Text = "Длительность перемены";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = trackBartime.Value.ToString();
            var cfgcls = new ConfigClass();
            cfgcls.WriteCfg(Path, data);

            if(checkBox1.Checked == true)
            {
                cfgcls.WriteCfg(Pathcheckdur, "1");
            }
            else if(checkBox1.Checked==false)
            {

                cfgcls.WriteCfg(Pathcheckdur, "0");
            }
          
            int week = Weeks.SelectedIndex;
            cfgcls.WriteCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "SemesterValue.txt", week.ToString());
            cfgcls.WriteCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "BellSetting.txt", ChoiseOfPreSet.SelectedIndex.ToString());
            cfgcls.WriteCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "VolumeValue.txt", trackBar1.Value.ToString());
            Close();
        }

        private void trackBartime_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBartime.Value.ToString();
        }

        private void ChoiseOfPreSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IndexPreset = ChoiseOfPreSet.SelectedIndex;
            if (IndexPreset == 0)
            {
                label3.Text = "Длительность громкого звонка";
            }
            else if (IndexPreset == 1)
            {
                label3.Text = "Длительность перемены";
            }
        }
    }
}
