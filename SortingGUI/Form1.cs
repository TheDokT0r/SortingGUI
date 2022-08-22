using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace SortingGUI
{
    public partial class Form1 : Form
    {
        string[] unsortedArr;
        double milSeconds = 0; //Time it takes to run the sorting algorithm
        string logsPath = "./logs.txt";

        List<dynamic> sortingAlrgs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sorting Tester";
            setSortingAlrgs();
        }

        
        void setSortingAlrgs() //Sets the combo box with all of the sorting algoritms, and adds them to a list
        {
            int[] nothingArr = { 0 }; //Just a temp

            sortingAlrgs = new List<dynamic>()
            {
                new Sorting.Bubble(nothingArr),
                new Sorting.Insertion(nothingArr),
                new Sorting.Quick(nothingArr),
                new Sorting.Selection(nothingArr),
                new Sorting.Merge(nothingArr),
                new Sorting.Shell(nothingArr),
                new Sorting.Heap(nothingArr),
                new Sorting.Bongo(nothingArr)
            };

            foreach(var item in sortingAlrgs)
            {
                cmb_sortingAlgrs.Items.Add(item.getSortingName());
            }
        }
        
        
        private void btn_gen_Click(object sender, EventArgs e) //Generates a new list
        {
            int index = -1;
            if (int.TryParse(txt_amountOfDataPoints.Text, out index))
            {
                lbx_data.Items.Clear();

                Random rnd = new Random();


                var arr = new string[index];
                for(int i = 0; i < index; i++)
                {
                    arr[i] = rnd.Next().ToString();
                }
                lbx_data.Items.AddRange(arr);

                unsortedArr = arr; //Saves the unsorted array

            }

            else
            {
                MessageBox.Show("Error, please insert a valid integer");
            }
        }


        private void btn_sort_Click(object sender, EventArgs e) //Starts sorting baby
        {
            milSeconds = 0;
            timer.Start();


            int index = cmb_sortingAlgrs.SelectedIndex; //Detects the sorting type

            sortingAlrgs[index].resetData(); //Resets the data from the last sort
            sortingAlrgs[index].arr = lstToArr(); //Generate a new arr
            sortingAlrgs[index].sort(); //Sorts it
            printData(sortingAlrgs[index].getData()); //Prints the data

            timer.Stop();
            MessageBox.Show("Done");
            txt_time.Text = "Time: " + milSeconds;
            
        }


        int[] lstToArr()
        {
            int[] arr = new int[lbx_data.Items.Count];

            for (int i = 0; i < arr.Length; i++) //Converts data to integers
            {
                arr[i] = int.Parse(lbx_data.Items[i].ToString());
            }

            return arr;
        }
        

        double getProgress(int[] arr) //Gets the % of the current list that's sorted
        {
            double unsorted = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (!(arr[i] > arr[i + 1]))
                {
                    unsorted++;
                }
            }

            double final = unsorted / arr.Length * 100;


            //Debug stuff
            /*string txt = "Length: " + arr.Length + "\nunsorted: " + unsorted + "\nfinal: " + final;
            MessageBox.Show(txt);*/

            return final;
        }


        private void btn_undo_Click(object sender, EventArgs e) //Undo the sorting
        {
            lbx_data.Items.Clear();
            lbx_data.Items.AddRange(unsortedArr);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            milSeconds = milSeconds + 00.1;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void printData(Data data)
        {
            //Saves the data to the logs
            SaveData saveData = new SaveData(data.arr, data.loops, 0, data.progress, data.sortingType);
            saveData.toText(logsPath);

            txt_loops.Text = "Loops: " + data.loops.ToString();

            //string[] arrButString = Array.ConvertAll(data.arr, x => x.ToString()); //Doesn't works for some reason

            var arrButString = new List<string>();

            foreach(int i in data.arr)
            {
                arrButString.Add(i.ToString());
            }

            lbx_data.Items.Clear();
            lbx_data.Items.AddRange(arrButString.ToArray());

            //Adds data to chart
            chart_SortingProgress.Series["sorted (%)"].Points.Clear();
            foreach (int i in data.progress)
            {
                chart_SortingProgress.Series["sorted (%)"].Points.AddY(i);
            }
        }


        private void btn_logs_Click(object sender, EventArgs e)
        {
            if(File.Exists(logsPath))
            {
                System.Diagnostics.Process.Start("notepad.exe", logsPath);
                return;
            }

            MessageBox.Show("Logs file doesn't exist", "Error");
        }


        private void button1_Click(object sender, EventArgs e) //Load an array from a txt file
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text File (*.txt)|*.txt|Sample File (*.sample)|*.sample";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }

                var lst = new List<int>();
                int currentNum = -1;

                foreach(var line in fileContent.Split('\n'))
                {
                    if(int.TryParse(line, out currentNum))
                    {
                        lst.Add(currentNum);
                    }
                }
                unsortedArr = Array.ConvertAll(lst.ToArray(), x => x.ToString()); //So the user could undo the sorting


                lbx_data.Items.Clear();
                foreach(var item in lst)
                {
                    lbx_data.Items.Add(item);
                }
                MessageBox.Show("List has been inserted to the program");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var results = MessageBox.Show("Are you sure you want to delete the logs?", "Are you sure", MessageBoxButtons.YesNo);
            if (results == DialogResult.No)
            {
                return;
            }

            if (File.Exists(logsPath))
            {
                File.Delete(logsPath);
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Logs file doesn't exist");
            }
        }

        private void btn_isSorted_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbx_data.Items.Count - 1; i++)
            {
                if(Convert.ToInt64(lbx_data.Items[i]) > Convert.ToInt64(lbx_data.Items[i + 1]))
                {
                    MessageBox.Show("False", "Is sorted");
                    return;
                }
            }

            MessageBox.Show("True", "Is sorted");
        }

        private void btn_randomize_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] arr = lbx_data.Text.Split('\u002C');

            string[] arrRandomized = arr.OrderBy(x => rnd.Next()).ToArray();

            lbx_data.Items.Clear();
            lbx_data.Items.AddRange(arrRandomized);

            unsortedArr = arr; //For the undo button

            MessageBox.Show("Done!");
        }
    }
}
