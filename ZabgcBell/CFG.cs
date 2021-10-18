using NAudio.Wave;
using System;
using System.IO;
namespace Helper
{
    public class ConfigClass
    {
        public string retcfg;


        public void WriteCfg(string Path, string data)
        {
            File.WriteAllBytes(Path, new byte[0]);
            var writer = new StreamWriter(Path);
            writer.WriteLine(data);
            writer.Close();
        }
        public string ReadCfg(string Path)
        {
            var reader = new StreamReader(Path);
            retcfg = reader.ReadLine();
            reader.Close();
            return retcfg;
        }

        public static TimeSpan GetWaveTime(string FileName)
        {
            WaveFileReader waveFile = new WaveFileReader(FileName);
            return waveFile.TotalTime;
        }

    }
}
