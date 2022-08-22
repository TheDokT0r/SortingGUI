using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingGUI.Sorting
{
    public class Bubble : SortAssist
    {
        public Bubble(int[] arr)
        {
            this.arr = arr;
        }

        public void sort()
        {
            bool sorted = false;
            while (!sorted)
            {
                loops++;

                progress.Add(getProgress(arr)); //Adds the progress in the current loop to the records

                sorted = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        sorted = false;

                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }
    }
}