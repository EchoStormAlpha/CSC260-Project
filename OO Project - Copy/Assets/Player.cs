﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{   [System.Serializable]
    public class Player : MonoBehaviour, IItemUser
    {
        Rigidbody rb;
        public int currentItem { get; set; }//item to collect
        public bool iscollected;
        public bool isdeposited;
        public Player()
        {
            currentItem = 1;
            iscollected = false;
            isdeposited = false;
           
        }
        public int changeItem(int item)
        {
            return item++;
        }
        
    }
}
