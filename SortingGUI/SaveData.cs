using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingGUI
{
    public class SaveData
    {
        int[] arr;
        double[] progress;
        int loops;
        double time;
        string sortingType;

        public SaveData(int[] arr, int loops, double time, double[] progress, string sortingType)
        {
            this.arr = arr;
            this.loops = loops;
            this.time = time;
            this.progress = progress;
            this.sortingType = sortingType;
        }

        public void toText(string path)
        {
            string txt = "";
            txt += sortingType + " (" + DateTime.Now + "):" + "\n";

            txt += "Length: " + arr.Length +  " Loops: " + loops + " | Time: " + time + " | Sorting type: " + sortingType + "\n";

            txt += "sorted array: [ ";
            foreach(int i in arr)
            {
                txt += i + " ";
            }
            txt += "]\n";

            txt += "progress: \n + [ ";
            foreach (int i in progress)
            {
                txt += i + " ";
            }
            txt += "]\n";


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
