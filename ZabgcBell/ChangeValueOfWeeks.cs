using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZabgcBell
{
    public partial class ChangeValueOfWeeks : Form
    {
        public ChangeValueOfWeeks(int seconds, string Values, string Path)
        {

            int _seconds = seconds;
            InitializeComponent();
            label1.Text = $"Смена расписания ({_seconds})";
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            ConfigClass configClass = new ConfigClass();
            timer.Tick += (s, e) =>
             {


                 label1.Text = $"Смена расписания ({_seconds})";
                 _seconds--;
                 if (_seconds <= 0)
                 {
                     configClass.WriteCfg(Directory.GetCurrentDirectory() + @"\Resources\" + $"{Path}", Values);
                     Close();
                 }
                

             };

        }
    }
}
