using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public abstract class ItemUser : levelSettings
    {
        int lastitem;


        abstract public int changeItem(int item);


    }
}
