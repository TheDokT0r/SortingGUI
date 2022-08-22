using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingGUI.Sorting
{
    public class Bongo : SortAssist
    {
        public Bongo(int[] arr)
        {
            this.arr = arr;
        }

        public void sort()
        {
            while(!isSorted(arr))
            {
                arr = Shuffle(arr);

                loops++;
                progress.Add(getProgress(arr));
            }
        }


        //https://stackoverflow.com/questions/273313/randomize-a-listt Thanks mate
        private int[] Shuffle(int[] newArr)
        {
            Random r = new Random();

            return newArr.OrderBy(x => r.Next()).ToArray();
        }


        bool isSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
