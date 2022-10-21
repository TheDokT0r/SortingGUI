using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingGUI.Logs
{
    public class SaveData
    {
        int[] arr;
        double[] progress;
        int loops;
        double time;
        string sortingType;
        public Config configFile;
        Dictionary<string, string> config;

        public SaveData(int[] arr, int loops, double time, double[] progress, string sortingType)
        {
            this.arr = arr;
            this.loops = loops;
            this.time = time;
            this.progress = progress;
            this.sortingType = sortingType;

            //string configPath = Environment.SpecialFolder.MyDocuments + "/SortingGUI/config.ini";
            string configPath = "./config.ini";
            configFile = new Config(configPath);

            if (!File.Exists(configPath))
            {
                configFile.InitializeFile();
            }
            config = configFile.GetConfig();
        }

        public void toText(string path)
        {
            string txt = "";
            txt += sortingType + " (" + DateTime.Now + "):" + "\n";


            if (config["Show Date"].ToLower() == "true")
                txt += "Length: " + arr.Length +  " Loops: " + loops + " | Time: " + time + " | Sorting type: " + sortingType + "\n";
            else
                txt += "Length: " + arr.Length + " Loops: " + loops + " | Sorting type: " + sortingType + "\n";

            if (config["Show Array"].ToLower() == "true")
            {
                txt += "sorted array: [ ";
                foreach (int i in arr)
                {
                    txt += i + " ";
                }
                txt += "]\n";
            }


            
            txt += "progress: \n + [ ";

            if (config["Show Progress"].ToLower() == "true")
            {
                foreach (int i in progress)
                {
                    txt += i + " ";
                }
                txt += "]\n";
            }
            else
                txt += "DISABLED\n";




            for(int i = 0; i < 100; i++)
            {
                txt += "-";
            }
            txt += "\n";

            if (!File.Exists(path))
            {
                var f = File.Create(path);
                f.Close();
            }

            File.AppendAllText(path, txt + Environment.NewLine);
        }
    }
}
