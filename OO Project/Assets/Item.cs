using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    [System.Serializable]
    public class Item
    {
        
    
            
            public int itemId;/// <summary>
            /// sets item Id and allows expansion with sets of Items
            /// </summary>
            protected int setId;//can be used to expand difficulty

           public Item(int itemID, int setID)
            {
                itemId = itemID;
                setId = setID;
            }

            public Item(int itemID)
            {
                itemId = itemID;
            }
        /*p
           public bool canpickup(int ID)///previously useful functions that were replaced
           {
               if (ID == itemId - 1)
                   return true;
               else
                   return false;
    */

    }


}
    

