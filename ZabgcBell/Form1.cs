using Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ZabgcBell
{
    public partial class Form1 : Form
    {
        private static int Year;
        private static int Month;
        private static int Day;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }
        public int DurationForBells;
        public string MusicPath;
        public static bool CheckOutBell;
        public bool GlobalCheck = true;
        public int result;
        List<string> Pathlist = new List<string>();
        private static string pathDuration = Directory.GetCurrentDirectory() + @"\Resources\" + "Duration_cfg.txt";
        public List<DateTime> TimeOfStart = new() { };
        public List<DateTime> TimeOfHalf = new() { };
        public List<DateTime> TimeOfEnd = new() { };
        public List<DateTime> TimeOfHalfEnd = new() { };
        #region Заполнение Листов

        private void TakedateFullDay()
        {
            TimeOfStart = new List<DateTime>
              {
            new DateTime(Year,Month,Day,8,30,00),
            new DateTime(Year,Month,Day,10,15,00),
            new DateTime(Year,Month,Day,12,30,00),
            new DateTime(Year,Month,Day,14,05,00),
            new DateTime(Year,Month,Day,16,00,00),

            };
            TimeOfHalf = new List<DateTime>
            {
            new DateTime(Year,Month,Day,9,15,00),
            new DateTime(Year,Month,Day,11,00,00),
            new DateTime(Year,Month,Day,12,35,00),
            new DateTime(Year,Month,Day,15,00,00),
            new DateTime(Year,Month,Day,16,45,00),
            };
            TimeOfHalfEnd = new List<DateTime>
            {
            new DateTime(Year,Month,Day,09,20,00),
            new DateTime(Year,Month,Day,11,05,00),
            new DateTime(Year,Month,Day,13,20,00),
            new DateTime(Year,Month,Day,15,05,00),
            new DateTime(Year,Month,Day,16,50,00),
            };
            TimeOfEnd = new List<DateTime>
            {
            new DateTime(Year,Month,Day,10,05,00),
            new DateTime(Year,Month,Day,11,50,00),
            new DateTime(Year,Month,Day,14,05,00),
            new DateTime(Year,Month,Day,15,50,00),
            new DateTime(Year,Month,Day,17,35,00),
            };
            label2.Visible = false;
            StandartWeek();
        }
        private void TakedateHalfDay()
        {
            TimeOfStart = new List<DateTime>
            {
            new DateTime(Year,Month,Day,08,30,00),
            new DateTime(Year,Month,Day,9,40,00),
            new DateTime(Year,Month,Day,10,50,00),
            new DateTime(Year,Month,Day,12,00,00),
            new DateTime(Year,Month,Day,13,10,00),

            };
            TimeOfEnd = new List<DateTime>
            {
            new DateTime(Year,Month,Day,9,30,00),
            new DateTime(Year,Month,Day,10,40,00),
            new DateTime(Year,Month,Day,11,50,00),
            new DateTime(Year,Month,Day,13,00,00),
            new DateTime(Year,Month,Day,14,10,00),

            };
            label2.Visible = true;
            CutWeek();
        }
        private void TakedateTuesday()
        {
            TimeOfStart = new List<DateTime>
            {
            new DateTime(Year,Month,Day,08,30,00),
            new DateTime(Year,Month,Day,10,15,00),
            new DateTime(Year,Month,Day,12,00,00),
            new DateTime(Year,Month,Day,13,15,00),
            new DateTime(Year,Month,Day,15,00,00),
            new DateTime(Year,Month,Day,16,45,00),

            };
            TimeOfHalf = new List<DateTime>
            {
            new DateTime(Year,Month,Day,09,15,00),
            new DateTime(Year,Month,Day,11,00,00),
            new DateTime(Year,Month,Day,14,00,00),
            new DateTime(Year,Month,Day,15,45,00),
            new DateTime(Year,Month,Day,17,30,00),
             new DateTime(Year,Month,Day,18,20,00),
            };
            TimeOfHalfEnd = new List<DateTime>
            {
            new DateTime(Year,Month,Day,09,20,00),
            new DateTime(Year,Month,Day,11,05,00),
            new DateTime(Year,Month,Day,14,05,00),
            new DateTime(Year,Month,Day,15,50,00),
            new DateTime(Year,Month,Day,17,35,00),
             new DateTime(Year,Month,Day,18,20,00),
            };
            TimeOfEnd = new List<DateTime>
            {
            new DateTime(Year,Month,Day,15,18,00),
            new DateTime(Year,Month,Day,11,50,00),
            new DateTime(Year,Month,Day,12,45,00),
            new DateTime(Year,Month,Day,14,50,00),
            new DateTime(Year,Month,Day,16,35,00),
            new DateTime(Year,Month,Day,18,20,00),


            };
            label2.Visible = false;
            ClassHour();

        }
        #endregion
        private void TimerStart_Tick(object sender, EventArgs e)
        {
              ConfigClass configClass = new ConfigClass();
              label1.Text = DateTime.Now.ToLongTimeString();
               RunningString();
              if (configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "Duration_cfg.txt") == "0")
               {
                label2.Visible = false;
                 }
               else
                 {
                label2.Visible = true;
                 }


            string duration = Directory.GetCurrentDirectory() + @"\Resources\" + "Checkercfg.txt";

            if (configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "SemesterValue.txt") == "1")
            { 
                duration = configClass.ReadCfg(duration);
                if (configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "WeekCFG.txt") == "0")
                {
                    label4.Text = "Стандартная неделя.";
                    if (duration == "0") { TakedateFullDay(); }
                    else if (duration == "1") 
                    {
                        if (DateTime.Now.Hour == 23 & DateTime.Now.Minute == 59)
                        {
                            GlobalTimer.Stop();
                            new ChangeValueOfWeeks(65, "0", "Checkercfg.txt").ShowDialog();
                            GlobalTimer.Start();
                        }
                        TakedateHalfDay(); 
                    };
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday & DateTime.Now.Hour == 23 & DateTime.Now.Minute == 59)
                    {
                        GlobalTimer.Stop();
                        new ChangeValueOfWeeks(65, "1", "WeekCFG.txt").ShowDialog();
                        GlobalTimer.Start();
                    }
                }
                else if (configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "WeekCFG.txt") == "1")
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        label4.Text = "Сегодня классный час.";
                        TakedateTuesday();
                    }
                    else
                    {

                        label4.Text = "Неделя с классным часом.";
                        if (duration == "0") { TakedateFullDay(); }
                        else if (duration == "1")
                        {
                            if (DateTime.Now.Hour == 23 & DateTime.Now.Minute == 59)
                            {
                                new ChangeValueOfWeeks(65, "0", "Checkercfg.txt").ShowDialog();
                            }
                            TakedateHalfDay();
                        
                        };
                        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday & DateTime.Now.Hour == 23  & DateTime.Now.Minute == 59)
                        {
                            GlobalTimer.Stop();
                            new ChangeValueOfWeeks(65, "0", "WeekCFG.txt").ShowDialog();
                            GlobalTimer.Start();
                        }
                    }
                }

            }else if (configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "SemesterValue.txt") == "0")
            {
                duration = Directory.GetCurrentDirectory() + @"\Resources\" + "Checkercfg.txt";
                duration = configClass.ReadCfg(duration);
                label4.Text = "Семестр без классного часа.";
                if (duration == "0") { TakedateFullDay(); }
                else if (duration == "1")
                {
                    if (DateTime.Now.Hour == 23 & DateTime.Now.Minute == 59)
                    {
                        new ChangeValueOfWeeks(65, "0", "Checkercfg.txt");
                    }
                    TakedateHalfDay();};
            }
        }
        private void OnBell(int NumberOfMusic,DurationStatus.DurationStatusEnum durationStatus,Timer timer)
        {
            
            result = NumberOfMusic;
            timer.Stop();
         //   DurationForBells = Convert.ToInt32(Durationcfg());
            CheckOutBell = true;
            Bell bell = new Bell(NumberOfMusic, ((int)durationStatus),OnChoiseBell());
            bell.ShowDialog();
            timer.Start();
        }
        private bool OnChoiseBell()
        {
            ConfigClass config = new ConfigClass();
            bool ChoiseBell = false;

            int a = Convert.ToInt32(config.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "BellSetting.txt"));
            if (a == 1)
                ChoiseBell = true;
            else if (a == 0)
                ChoiseBell = false;
            return ChoiseBell;
        }
        public string Durationcfg()
        {
            ConfigClass configClass1 = new ConfigClass();

            string duration = Directory.GetCurrentDirectory() + @"\Resources\" + "Checkercfg.txt";
            configClass1.ReadCfg(duration);
            if (configClass1.retcfg == "0") { TakedateFullDay(); }
            else if (configClass1.retcfg == "1") { TakedateHalfDay(); }
            var lists = new Lists();
            string Duration;
            var cfg = new ConfigClass();
            cfg.ReadCfg(pathDuration);
            label8.Text = cfg.retcfg + " секунд";
            Duration = cfg.retcfg;
            return Duration;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ChoiseNextSound(-1);
            Lists lists = new Lists();
            Year = lists.GetCurrentYear();
            Month = lists.GetCurrentMonth();
            Day = lists.GetCurrentDay();
            Durationcfg();
            label1.Text = DateTime.Now.ToLongTimeString();





        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            Durationcfg();
        }
        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms["Service"] == null)
            //    new Service().Show();
        }
        private void рассписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ScheduleForm"] == null)
                new ScheduleForm().Show();
        }
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Settings"] == null)
                new Settings().Show();
        }
        private void ChoiseNextSound(int SoundID)
        {
            StreamReader SoundPathReader = new StreamReader(Directory.GetCurrentDirectory() + @"\Resources\SchedulePlaylist.txt");
            string sound;
            while ((sound = SoundPathReader.ReadLine()) != null)
            {
                Pathlist.Add(sound);
            }
            string name = "";
            if (SoundID >= 0 && SoundID < Pathlist.Count() - 1)
            {
                name = Path.GetFileName(Pathlist[SoundID + 1]);
            }
            else
            {
                name = Path.GetFileName(Pathlist[0]);
            }
            label9.Text = name;
            SoundPathReader.Close();
        }
        private void RunningString()
        {

            if (label9.Text.Length >= 80)
            {
                if (label9.Left > -label9.Width)
                {
                    label9.Left -= 1;
                }
                else
                {
                    label9.Left = this.Width;
                }
            }
            else
            {
                label9.Location = new Point((gradientPanel1.Width - label9.Width) / 2, 10);
            }
        }
        private void CutWeek()
        {
            for (int inc = 0; inc <= TimeOfStart.Count - 1; inc++)
            {
                if ((DateTime.Now.Minute == TimeOfStart[inc].Minute) & (DateTime.Now.Hour == TimeOfStart[inc].Hour))
                {

                    OnBell(inc, DurationStatus.DurationStatusEnum.odnaminuta, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;
                }
                else if ((DateTime.Now.Minute == TimeOfEnd[inc].Minute) & (DateTime.Now.Hour == TimeOfEnd[inc].Hour))
                {
                    OnBell(inc, DurationStatus.DurationStatusEnum.Desyatminut, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;
                }
            }

        }
        private void ClassHour()
        {
            for (int inc = 0; inc <= TimeOfStart.Count - 1; inc++)
            {

                if ((DateTime.Now.Minute == TimeOfStart[inc].Minute) & (DateTime.Now.Hour == TimeOfStart[inc].Hour))
                {

                    OnBell(inc, DurationStatus.DurationStatusEnum.odnaminuta, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;
                }

                else if ((DateTime.Now.Minute == TimeOfHalf[inc].Minute) & (DateTime.Now.Hour == TimeOfHalf[inc].Hour))
                {
                    OnBell(inc, DurationStatus.DurationStatusEnum.pyatminut, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;
                }

                else if ((DateTime.Now.Minute == TimeOfHalfEnd[inc].Minute) & (DateTime.Now.Hour == TimeOfHalfEnd[inc].Hour))
                {
                    OnBell(inc, DurationStatus.DurationStatusEnum.odnaminuta, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;

                }

                else if ((DateTime.Now.Minute == TimeOfEnd[inc].Minute) & (DateTime.Now.Hour == TimeOfEnd[inc].Hour))
                {
                    if ((DateTime.Now.Minute == TimeOfEnd[2].Minute) & (DateTime.Now.Hour == TimeOfEnd[2].Hour))
                    {
                        OnBell(inc, DurationStatus.DurationStatusEnum.Tridcatminut, GlobalTimer);
                        ChoiseNextSound(inc);
                        break;
                    }
                    else
                    {
                        OnBell(inc, DurationStatus.DurationStatusEnum.Desyatminut, GlobalTimer);
                        ChoiseNextSound(inc);
                        break;
                    }
                }

            }
        }
        private void StandartWeek()
        {
            for (int inc = 0; inc <= TimeOfStart.Count - 1; inc++)
            {
                if ((DateTime.Now.Minute == TimeOfStart[inc].Minute) & (DateTime.Now.Hour == TimeOfStart[inc].Hour))
                {
                    OnBell(inc, DurationStatus.DurationStatusEnum.odnaminuta, GlobalTimer);                   
                    ChoiseNextSound(inc);
                    break;
                }
                else if ((DateTime.Now.Minute == TimeOfHalf[inc].Minute) & (DateTime.Now.Hour == TimeOfHalf[inc].Hour))
                {
                    OnBell(inc, DurationStatus.DurationStatusEnum.pyatminut, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;
                }
                else if ((DateTime.Now.Minute == TimeOfHalfEnd[inc].Minute) & (DateTime.Now.Hour == TimeOfHalfEnd[inc].Hour))
                {
                    OnBell(inc, DurationStatus.DurationStatusEnum.odnaminuta, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;
                }
                else if ((DateTime.Now.Minute == TimeOfEnd[inc].Minute) & (DateTime.Now.Hour == TimeOfEnd[inc].Hour))
                {
                    if ((DateTime.Now.Minute == TimeOfEnd[1].Minute) & (DateTime.Now.Hour == TimeOfEnd[1].Hour))
                    {
                        OnBell(inc, DurationStatus.DurationStatusEnum.Sorokminut, GlobalTimer);
                        ChoiseNextSound(2);
                        break;
                    }
                    else if ((DateTime.Now.Minute == TimeOfEnd[4].Minute) & (DateTime.Now.Hour == TimeOfEnd[4].Hour))
                    {
                        OnBell(inc, DurationStatus.DurationStatusEnum.odnaminuta, GlobalTimer);
                         ChoiseNextSound(2);
                        break;
                    }

                  
                    OnBell(inc, DurationStatus.DurationStatusEnum.Desyatminut, GlobalTimer);
                    ChoiseNextSound(inc);
                    break;

                }

            }
        }

        private void добавитьПеснюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Звонки с расширением |*.wav;";
            TimeSpan FiveMinutes = new TimeSpan(0, 5, 30);
           
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                string path = fileDialog.FileName;
                string MoveTopath = fileDialog.SafeFileName;

                Directory.CreateDirectory(Directory.GetCurrentDirectory());
                foreach (string fn in fileDialog.FileNames)
                {
                    if(ConfigClass.GetWaveTime(fn) <= FiveMinutes)
                    {
                        File.Copy(fn, Directory.GetCurrentDirectory() + @"/5 Minutes" + @"/" + System.IO.Path.GetFileName(fn), false);
                    }
                    else
                    {
                        File.Copy(fn, Directory.GetCurrentDirectory() + @"/10 Minutes" + @"/" + System.IO.Path.GetFileName(fn), false);
                    }
                    
                }
            }
        }
        private void заменитьНеделюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigClass writerconf = new ConfigClass();
            string ValueWeek = new ConfigClass().ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "WeekCFG.txt");
            if (ValueWeek == "1")
            {
                writerconf.WriteCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "WeekCFG.txt", "0");

            }
            else if (ValueWeek == "0")
            {
                writerconf.WriteCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "WeekCFG.txt", "1");
            }
        }
    }
}
