using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class Gate : Player, IItemUser
    {

        new public int currentItem { get; set; }//item to be deposited
        public Gate()
        {
            currentItem = 1; 
        }
        public Gate(int num)
        {
            currentItem = num;
        }
        new public int changeItem(int item)
        {
            return item++;
        }
    }
}
