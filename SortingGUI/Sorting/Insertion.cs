using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingGUI.Sorting
{
    public class Insertion : SortAssist
    {
        public Insertion(int[] arr)
        {
            this.arr = arr;
        }

        public void sort()
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                loops++;
                progress.Add(getProgress(arr));

                var item = arr[i];
                var currentIndex = i;
                while (currentIndex > 0 && arr[currentIndex - 1] > item)
                {
                    arr[currentIndex] = arr[currentIndex - 1];
                    currentIndex--;
                }
                arr[currentIndex] = item;
            }
        }
    }
}
