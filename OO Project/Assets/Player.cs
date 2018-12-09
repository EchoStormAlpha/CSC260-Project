using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class Player : ItemUser
    {
        int currentItem;
        bool iscollected;
        bool isdeposited;
        public Player()
        {
            currentItem = 1;
            iscollected = false;
            isdeposited = false;
        }
        override public int changeItem(int item)
        {
            return item++;
        }
    }
}
