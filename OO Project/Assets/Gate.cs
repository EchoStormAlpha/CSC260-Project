using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class Gate : Player, IItemUser
    {
        
         public int currentItem { get; set; }//item to be deposited
        
        public Gate()
        {
           
            currentItem = 1;
        }
        public Gate(int num)
        {
            currentItem = 1;

        }
         public int changeItem(int item)
        {
            return item++;
        }
    }
}
