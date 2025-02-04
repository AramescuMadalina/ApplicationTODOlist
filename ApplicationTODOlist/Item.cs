using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTODOlist
{
    internal class Item
    {
        public string Name;
        public string Priority;
        public string Date;
        public string Plan;
        private string? aInput;

        public Item(string name, string priority, string date, string plan)
        {
            Name = name;
            Priority = priority;
            Date = date;
            Plan = plan;    
        }
    }
}
