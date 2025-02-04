using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTODOlist
{
    internal class ItemsTodoList
    {
        public List<Item> todolist;

        public ItemsTodoList()
        {
            todolist = new List<Item>();
        }
        public void ShowTodoList()

        {
            Console.WriteLine();
            for (int i = 0; i < todolist.Count; i++)
            {
                //Console.WriteLine((i + 1) + " : " + todolist[i].GetDataList());
            }


        }
    }
}
