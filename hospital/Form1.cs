using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hospitalGUI
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();
        List<string> lines = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
            bs.DataSource = sList;
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            

        }

        static List<Surgery> sList = new List<Surgery>();

        int indexCount;
        bool saveClicked = false;

        Inventory newInventory = new Inventory(sList);


      

        static List<int> indexList = new List<int>();


        internal void receiveData(int index)
        {
            if(index < 0 || index > sList.Count() - 1)
            {
                MessageBox.Show("Invalid index entered");
            }
            else
            {
                indexList.Add(index);
            }
            
        }







        //remove surgeries
        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove");
            }
            else
            {
                newInventory.deleteItem(listBox1.SelectedIndex);
                bs.ResetBindings(false);
            }
            
        }
        
        //sort surgeries
        private void button2_Click(object sender, EventArgs e)
        {
            newInventory.sort();


            bs.ResetBindings(false);
        }
       
        // edit button
        private void button3_Click(object sender, EventArgs e)
        {
            Surgery s = makeSurgery();

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to replace");
            }
            else
            {
                newInventory.deleteItem(listBox1.SelectedIndex);
                
            }

            newInventory.addSurgery(s);

            bs.ResetBindings(false);

        }
        // perform surgeries
        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (sList[index].available)
            {


                sList[index].available = false;
            }
            else
            {
                sList[index].available = true;
            }

            bs.ResetBindings(false);



        }
        //search button
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if(indexList.Count > 0)
            {
                int i = indexList[0];
                bool check = false;
                indexList.Remove(0);
                foreach(Surgery s in sList)
                {
                    if (i == s.index)
                    {
                        MessageBox.Show(s.ToString());
                        check = true;
                    }


                }
                if (!check)
                {
                    MessageBox.Show("Invalid Index");
                }
             

            }
            
            bs.ResetBindings(false);
        }
        //add button
        private void button6_Click(object sender, EventArgs e)
        {

           

            Surgery s = makeSurgery();

            newInventory.addSurgery(s);

            

           
            bs.ResetBindings(false);


        }
        // save inventory
        private void button7_Click(object sender, EventArgs e)
        {
          
            List<string> outContents = new List<string>();

            foreach(Surgery s in sList)
            {
                outContents.Add(s.ToString());
            }


            indexCount = sList.Last().index;


            
            string outFile = @"C:\demos\inventory.txt";

            File.WriteAllLines(outFile, outContents);
            saveClicked = true;

        }

        // load inventory
        private void button8_Click(object sender, EventArgs e)
        {
            if (saveClicked)
            {
                MessageBox.Show("Error: Cannot Load Saved Inventory Until Application is Restarted");
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    String filePath = openFileDialog.FileName;
                    string[] inventoryList = File.ReadAllLines(filePath);
                    foreach (String s in inventoryList)
                    {
                        string[] delimeters = { "Surgery name: ", " Surgeon: ", " Result: ", " Cost: $", " Risk: ", "% chance of survival This Surgery is: ", "ID humber: " };
                        string[] items = s.Split(delimeters, StringSplitOptions.None);

                        float cost = float.Parse(items[4]);
                        float risk = float.Parse(items[5]);
                        bool b = true;
                        if (items[6] == "unavailable")
                        {
                            b = false;
                        }
                        int ID = int.Parse(items[7]);
                        Surgery surgery = new Surgery(items[1], items[2], items[3], cost, risk, b, ID);
                        newInventory.addSurgery(surgery);

                    }

                }
                bs.ResetBindings(false);

                List<string> outContents = new List<string>();
                outContents.Clear();
                string outFile = @"C:\demos\inventory.txt";

                File.WriteAllLines(outFile, outContents);
            }
        }
        private Surgery makeSurgery()
        {
            String surgName = surgeryName_txt.Text;
            String surgeonName = surgeonName_txt.Text;
            String result = result_txt.Text;



            float cost = float.Parse(cost_txt.Text);
            if (cost < 0)
            {
                cost = 1000;
                MessageBox.Show("Invalid input, default value of $1000 used");
            }
            
           
            
            float survival = float.Parse(risk_txt.Text);

            if(survival < 0 || survival > 100)
            {
                survival = 50;
                MessageBox.Show("Invalid input, default value of 50% used");
            }

            Boolean available;
            if(sList.Count == 0)
            {
                indexCount = 0;
            }
            else
            {
               indexCount = sList.Last().index;

            }
            
            int i = indexCount + 1;
            if (availableBox.Checked)
            {
                available = true;
            }
            else
            {
                available = false;
            }
            indexCount++;
            Surgery s = new Surgery(surgName, surgeonName, result, cost, survival, available, i);
            return s;
        }
        // close window
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
