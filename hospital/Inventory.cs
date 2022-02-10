using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalGUI
{
    class Inventory
    {

        public List<Surgery> surgeryList { get; set; }

        public Inventory(List<Surgery> surgeryList)
        {
            this.surgeryList = surgeryList;
        }

        public String getInventory()
        {
            string output = "";
            foreach(Surgery s in surgeryList)
            {
                output += s.ToString() +"\n";
            }
            return output;

        }

        public void addSurgery(Surgery s)
        {

            surgeryList.Add(s);
          
        }
       
        public Surgery searchSurgery(int index)
        {

            return surgeryList[index] ;
        }
        
        public void deleteItem(int index)
        {
            if(index <= surgeryList.Count() && index >= 0 )
            {
                surgeryList.Remove(surgeryList[index]);
            }
            
        }

        public void sort()
        {
            
           for(int i = 0; i < surgeryList.Count()-1; i++)
            {
                for(int t = i+1; t < surgeryList.Count(); t++)
                if(surgeryList[i].ToString().CompareTo(surgeryList[t].ToString()) > 0)
                    {
                        Surgery temp = surgeryList[i];
                        surgeryList[i] = surgeryList[t];
                        surgeryList[t] = temp;
                    } 
            }


            
        }






    }
}
