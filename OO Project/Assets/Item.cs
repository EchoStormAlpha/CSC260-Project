using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    [System.Serializable]
    public class Item : Player
    {
        int itemId;
        int setId;

        public Item(int itemID, int setID)
        {
            itemId = itemID;
            setId = setID;
        }
        public Item(int itemID)
        {
            itemId = itemID;
        }
        public bool canpickup(int ID)
        {
            if (ID == itemId - 1)
                return true;
            else
                return false;
        }

    }
}
