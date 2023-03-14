using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA07
{
    public partial class Form1 : Form
    {
        List<string> myList;
        string name;

        public Form1()
        {
            InitializeComponent();
            myList = new List<string>();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            name = UI_value_tbx.Text;

            UI_SortedName_Lbx.Items.Clear();   
            
            myList.Add(name);
            UI_UnsortedName_Lbx.Items.Add(name);
            UI_value_tbx.Text = null;

            myList.Sort();
            foreach (string names in myList)
            {
               UI_SortedName_Lbx.Items.Add(names);
            }

        }
        //********************************************************************************************
        //Method: private int RBinarySearch(List<string> myList, string name, int low, int high)
        //Purpose: Create the searchbinary to search in the list 
        //Parameters:
        //List<string> myList - create the list to add string into
        //string name - use the value of user 
        //int low - lowest element in the list 
        //int high - highest element in the list 
        //********************************************************************************************
        private int RBinarySearch(List<string> myList, string name, int low, int high)
        {

            if (low <= high)
            {
                int mid = (low + high) / 2;//We calculate the middle index

                //We compare our search value with the value at the middle index
                //If the values match, we have found the value at position mid
                // so we return mid as the index
                if (myList[mid].CompareTo(name) == 0)
                    return mid;

                //If my search value is > the value at mid
                //I only have to search the lower half of the list
                if (myList[mid].CompareTo(name) > 0)
                    return RBinarySearch(myList, name, low, mid - 1);

                // The  search value is higher than the value at mid
                // so I need to search only the higher half of the list
                return RBinarySearch(myList, name, mid + 1, high);

            }
            return -1; //If we reach here, it means high < low. So we haven't found a match
        }
        private void button2_Click(object sender, EventArgs e)
        {
            name = UI_value_tbx.Text.ToString();
            int index = RBinarySearch(myList, name, 0, myList.Count-1);
            if (UI_value_tbx.Text == "")
            {
                MessageBox.Show("Nothing to search");
            }
            else if (index < 0)
            {
                MessageBox.Show(name + " not found");
            }
            else
            {
                MessageBox.Show(name + " found at index " + index);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
