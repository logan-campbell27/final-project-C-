using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// class object that will go into the inventory class list
namespace hospitalGUI
{
    class Surgery
    {
        //properties
        public string surgeryName { get; set; }
        public string surgeon { get; set; }
        public string result { get; set; }
        public float cost { get; set; }
        public float risk { get; set; }
        public bool available { get; set; }

        public int index { get; set; }

        //constructor
        public Surgery()
        {
            surgeryName = "name";
            surgeon = "surgeon";
            result = "result";
            cost = 1000;
            risk = 100;
            available = true;

        }
        public Surgery(string surgeryName, string surgeon, string result, float cost, float risk, bool available, int index)
        {
            this.surgeryName = surgeryName;
            this.surgeon = surgeon;
            this.result = result;
            this.cost = cost;
            this.risk = risk;
            this.available = available;
            this.index = index;
        }
        //toString method to print
        public override string ToString()
        {
            string print = "Surgery name: " + surgeryName + " Surgeon: " + surgeon + " Result: " + result + " Cost: $" + cost + " Risk: " + risk + "% chance of survival This Surgery is: ";
            if (available)
            {
                print += "available";
            }
            else
            {
                print += "unavailable";
            }
            print += " ID humber: " + index +"";
            return print;
        }
    }
}
