using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZabgcBell
{

    public partial class ScheduleForm : Form
    {
        private string _Playlistpath5Minutes = Directory.GetCurrentDirectory() + @"\Resources\SchedulePlaylist.txt";

        public List<string> NameSongs = new List<string>();
        public List<string> AllSongs = new List<string>();
        private string _Playlistpath10Minutes = Directory.GetCurrentDirectory() + @"\Resources\PlayList10Min.txt";
        private string _LongBellPlayList = Directory.GetCurrentDirectory() + @"\Resources\LongBellPL.txt";
        public ScheduleForm()
        {
            InitializeComponent();
            GetCurrentList(listBox1,_Playlistpath5Minutes);
            var toolTip = new ToolTip();
            toolTip.SetToolTip(RefreshButton, "Обновить Список");
            toolTip.SetToolTip(UpButton, "Поднять песню");
            toolTip.SetToolTip(DownButton, "Спустить песню");
            #region changeindexLB

            UpBTN2.Click += (s, e) => { MoveUp(listBox2); };
            DownBTN2.Click += (s, e) => { MoveDown(listBox2); };

            UpButton.Click += (s, e) =>
            {
                MoveUp(listBox1);
            };
            DownButton.Click += (s, e) =>
            {
                MoveDown(listBox1);
            };
            LNGdwn.Click += (s, e) =>
            {
                MoveDown(LongBellsList);
            };
            LNGup.Click += (s, e) =>
            {
                MoveUp(LongBellsList);
            };

            void MoveUp(ListBox listBox)
            {
                MoveItem(-1, listBox);
            }

            void MoveDown(ListBox listBox)
            {
                MoveItem(1, listBox);
            }

            void MoveItem(int direction, ListBox listBox)
            {
                if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                    return;
                int newIndex = listBox.SelectedIndex + direction;
                if (newIndex < 0 || newIndex >= listBox.Items.Count)
                    return; // Index out of range - nothing to do
                object selected = listBox.SelectedItem;
                listBox.Items.Remove(selected);
                listBox.Items.Insert(newIndex, selected);
                listBox.SetSelected(newIndex, true);
            }
            #endregion
            Save.Click += (s, e) =>
            {
                SavePlayLists(listBox1, _Playlistpath5Minutes);
                if(listBox2.Items.Count != 0)
                {
                    SavePlayLists(listBox2, _Playlistpath10Minutes);
                }
                
                Close();
            };
            SaveBTN2.Click += (s, e) =>
            {
                SavePlayLists(listBox2, _Playlistpath10Minutes);
                if (listBox1.Items.Count != 0)
                {
                    SavePlayLists(listBox1, _Playlistpath5Minutes);
                }
                Close(); 
            };
            LNGSave.Click += (s, e) =>
           {
               SavePlayLists(LongBellsList, _LongBellPlayList);
               Close();
           };
            RefreshLongBells.Click += (s, e) =>
            {
                GetAllSongs(LongBellsList);
            };
            RefreshButton.Click += (s, e) =>
             { GetAllSongs(listBox1); };
            RefreshBTN2.Click += (s, e) =>
             { GetAllSongs(listBox2); };
            OutButton.Click += (s, e) =>
            { Close(); };
            CloseBTN2.Click += (s, e) => { Close(); };
            LNGcls.Click += (s, e) =>
            {
                Close();
            };
        }
        void GetCurrentList(ListBox listBox,string Path)
        {
            listBox.Items.Clear();
            var reader = new StreamReader(Path);
            string song = "";
           while((song = reader.ReadLine())!= null)
            {
                listBox.Items.Add(song);
            }
            reader.Close();
        }
        void GetAllSongs(ListBox listBox)
        {
            string Fiveminutes = @"\5 Minutes";
            string Tenminutes = @"\10 Minutes";
            string LongBell = @"\LongBell";
            string dirpath ="";
            if (tabControl1.SelectedIndex == 0)
            {
                //5min
                dirpath = Directory.GetCurrentDirectory() + Fiveminutes;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                dirpath = Directory.GetCurrentDirectory() + Tenminutes;
            }
            else if (tabControl1.SelectedIndex == 2)
                dirpath = Directory.GetCurrentDirectory() + LongBell;
            
            DirectoryInfo dir = new DirectoryInfo(dirpath);
            FileInfo[] files = dir.GetFiles("*.wav");
            AllSongs.Clear();
            int i = 1;
            foreach (FileInfo fi in files)
            {
                
                AllSongs.Add(fi.Name.ToString());
                i++;

            }
            listBox.Items.Clear();
            foreach (string songs in AllSongs)
            {
                listBox.Items.Add(songs.TrimStart());
            }
        }
        private  void SavePlayLists(ListBox listBox, string Path)
        {
            StreamWriter writer = new StreamWriter(Path);
            foreach (string song in listBox.Items)
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    writer.WriteLine(song);

                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    writer.WriteLine(song);
                }
                else if(tabControl1.SelectedIndex == 2)
                {
                    writer.WriteLine(song);
                }
                


            }
            writer.Close();
            

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                GetCurrentList(listBox1, _Playlistpath5Minutes);
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                GetCurrentList(listBox2, _Playlistpath10Minutes);
            }
            else if(tabControl1.SelectedIndex == 2)
            {
                GetCurrentList(LongBellsList, _LongBellPlayList);
            }
        }
    }
}
