using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingGUI.Sorting
{
    public class Selection : SortAssist
    {
        public Selection(int[] arr)
        {
            this.arr = arr;
        }

        public void sort()
        {
            for (var i = 0; i < arr.Length; i++)
            {
                loops++;
                progress.Add(getProgress(arr));

                var min = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    var lowerValue = arr[min];
                    arr[min] = arr[i];
                    arr[i] = lowerValue;
                }
            }
        }
    }
}
