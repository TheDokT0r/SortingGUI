using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingGUI
{
    public class Data
    {
        public int[] arr;
        public int loops;
        public double[] progress;
        public string sortingType;

        public Data(int[] arr, int loops, double[] progress, string sortingType)
        {
            this.arr = arr;
            this.loops = loops;
            this.progress = progress;
            this.sortingType = sortingType;
        }
    }
}
