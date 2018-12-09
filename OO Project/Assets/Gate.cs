using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class Gate : ItemUser
    {

        int currentItem;//item to be deposited
        public Gate()
        {
            currentItem = 1;
        }
        override public int changeItem(int item)
        {
            return item++;
        }
    }
}
