using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Helper;
using System.Media;
using System.IO;


namespace ZabgcBell
{
    public partial class Bell : Form
    {
        private int _soundId;
       
        private int DurationBell;
        private int _Duration = Convert.ToInt32(new ConfigClass().ReadCfg(Directory.GetCurrentDirectory()+ @"\Resources\" + "Duration_cfg.txt"));
        private bool _CheckDuration;
        private float ValueVolume = Convert.ToInt32(new ConfigClass().ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "VolumeValue.txt"));
        private AudioEndPoint audioEndPoint = new AudioEndPoint();
        private SoundPlayer soundPlayer = new SoundPlayer();
        private ConfigClass configClass = new ConfigClass();
        /// <summary>
        /// для checkduration true 10 минут 
        /// false 5 минут
        /// </summary>
        //
        public Bell(int SoundId, int Duration, bool checkDuration)
        {
            InitializeComponent();
            timer1.Start();
            _soundId = SoundId;
            _Duration = Duration;
           
        }
        private void Bell_Load(object sender, EventArgs e)
        {
            if(_Duration > 360)
            {
                _CheckDuration = true;
            }
            else
            {
                _CheckDuration = false;
            }
             ConfigClass configClass = new ConfigClass();
             DurationBell = Convert.ToInt32(configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "Duration_cfg.txt"));
            if(_CheckDuration == true)
            {
                PathRead = Directory.GetCurrentDirectory() + @"\Resources\PlayList10Min.txt";


            }
            else
            {
                PathRead =  Directory.GetCurrentDirectory() + @"\Resources\SchedulePlaylist.txt"; 


            }
           
            StreamReader SoundPathReader = new StreamReader(PathRead);
            string sound;
            PathList.Clear(); 
             while ((sound = SoundPathReader.ReadLine()) != null)
            {
                PathList.Add(sound);
            }
            timer1.Enabled = true;
            timer1.Start();
        }
        List<string> PathList = new List<string>();
        private string PathRead;
        int dur = 60;
        int gromko = Convert.ToInt32(new ConfigClass().ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "Duration_cfg.txt"));
        private bool CheckOutBell = Form1.CheckOutBell;
        private TimeSpan FiveMinutes = new TimeSpan(0, 5, 30);
        private void timer1_Tick(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(configClass.ReadCfg(Directory.GetCurrentDirectory() + @"\Resources\" + "BellSetting.txt"));


            if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                if (a == 0)
                {
                    if(_CheckDuration == false)
                    soundPlayer.SoundLocation = Directory.GetCurrentDirectory()+ $@"/5 Minutes/" + PathList[_soundId];
                    else
                    soundPlayer.SoundLocation = Directory.GetCurrentDirectory() +  $@"/10 Minutes/" + PathList[_soundId];

                    if (_Duration > 0)
                    {
                        if (CheckOutBell == true)
                        {
                            soundPlayer.Play();
                            CheckOutBell = false;
                        }

                        _Duration -= 1;
                        gromko--;
                        label4.Text = _Duration.ToString() + "сек. ";
                        if (gromko >= 55)
                        {
                            audioEndPoint.Inizialize(1f);
                        }
                        else if (gromko <= 0 && _Duration >90)
                        {
                            audioEndPoint.Inizialize(ValueVolume / 100);

                        }
                        else if (_Duration <= 90)
                        {
                            audioEndPoint.Inizialize(1f);
                        }
                    }
                    else
                    {
                       // bil stop

                    }
                    if (_Duration <= 0)
                    {
                        soundPlayer.Stop();
                        Close();
                     }
                    else
                    {
                        label2.Text = "Окно закроется через: ";
                        label4.Text = _Duration.ToString() + " сек.";
                        dur--;
                    }
                   
                }
                else if (a == 1)
                {

                    soundPlayer.SoundLocation = Directory.GetCurrentDirectory()+ $@"/5 Minutes/"+PathList[_soundId];
                    audioEndPoint.Inizialize(1f);

                    if (DurationBell > 0)
                    {
                        if (CheckOutBell == true)
                        {

                            audioEndPoint.Inizialize(1f);
                            soundPlayer.Play();
                            CheckOutBell = false;
                        }

                        DurationBell --;
                        label4.Text = DurationBell.ToString() + "сек. ";
                    }
                    else
                    {
                        soundPlayer.Stop();

                    }

                    if (gromko <= 0)
                    {
                        label2.Text = "Длительность звонка:";
                        Close();
                    }
                    else
                    {
                        label2.Text = "Окно закроется через: ";
                        dur--;
                        label4.Text = $"{gromko.ToString()}" + " сек.";

                    }
                }

            }else if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                dur--;
                if(dur <= 0)
                {
                    Close();
                }

            }
        }
    }
}
