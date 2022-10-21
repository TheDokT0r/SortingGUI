using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingGUI.Logs
{
    public class Config
    {
        private string path;
        public Config(string path)
        {
            this.path = path;
        }

        public string Path { get { return path; } }

        public void InitializeFile() //intlz the config file
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[Options]");
            sb.AppendLine("Show Array=false");
            sb.AppendLine("Show Progress=true");
            sb.AppendLine("Show Date=true");

            var f = File.CreateText(path);
            f.Write(sb.ToString());
            f.Close();
        }


        public Dictionary<string, string> GetConfig()
        {
            var lines = File.ReadAllLines(path);
            var dict = new Dictionary<string, string>();

            foreach (var s in lines)
            {
                try
                {
                    var split = s.Split('=');
                    dict.Add(split[0], split[1]);
                }
                catch { }
            }

            return dict;
        }


        public bool IsInitialized()
        {
            if(File.Exists(path))
            {
                return true;
            }

            return false;
        }
    }
}
