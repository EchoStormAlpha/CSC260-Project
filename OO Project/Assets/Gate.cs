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
        protected int setID;
        public Gate()
        {
            currentItem = 1;
        }
        protected Gate(int num)
        {
            currentItem = 1;

        }
         protected int changeItem(int item)
        {
            return item++;
        }
    }
}
