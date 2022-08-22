using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingGUI
{
    public abstract class SortAssist
    {
        public int[] arr;
        protected int loops;
        protected List<double> progress;
        protected string sortingType;

        protected SortAssist()
        {
            progress = new List<double>();
            sortingType = getSortingName();
        }

        public Data getData()
        {
            return new Data(arr, loops, progress.ToArray(), sortingType);
        }


        protected double getProgress(int[] arr) //Gets the % of the current list that's sorted
        {
            double unsorted = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (!(arr[i] > arr[i + 1]))
                {
                    unsorted++;
                }
            }

            return unsorted / arr.Length * 100;
        }


        public string getSortingName()
        {
            var og = this.ToString().Split('.');
            return og[og.Length - 1] + "Sort";
        }


        public void resetData()
        {
            arr = null;
            loops = 0;
            progress.Clear();
        }
    }
}
