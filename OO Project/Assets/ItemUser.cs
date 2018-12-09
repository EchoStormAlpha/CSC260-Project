using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public interface IItemUser
    {
        int currentItem { get; set; }
        int changeItem(int item);

    }
}
