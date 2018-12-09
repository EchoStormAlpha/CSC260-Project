using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class levelSettings
{
    protected int numItems;//max5 per set
   // protected int numItemSets;//max3
    public levelSettings()
    {
        numItems = 1;
       // numItemSets = 1;
    }
    public levelSettings(int numI)
    {
        numItems = numI;
    }
   /* public levelSettings(int numI, int numS)
    {
        numItems = numI;
        numItemSets = numS;
    }*/
}


public abstract class ItemUser : levelSettings
{
    int lastitem;
    
   
    abstract public int changeItem(int item);

    
}
    
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
    
public class Player: ItemUser
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

    public bool canpickup(int ID)
    {
        if (ID == itemId - 1)
            return true;
        else
            return false;
    }

}

