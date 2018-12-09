using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets
{
    

    public class Player_Collision : MonoBehaviour {
        Vector3 originalPos;
        // Use this for initialization
        
        public Player player = new Player();
        public Item item1 = new Item(1);
        public Item item2 = new Item(2);
        public Item item3 = new Item(3);
        public Item item4 = new Item(4);
        public Item item5 = new Item(5);
        public Item item6 = new Item(6);
        public levelSettings levelSettings = new levelSettings(6);
        public Gate gate1 = new Gate();
        void Start() {
            
            originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        // Update is called once per frame    ////Class is for handling collisions
        void OnCollisionEnter(Collision collisionInfo)
        {
           if(collisionInfo.collider.tag=="Obstacle")
            {
                player.iscollected = false;
                gameObject.transform.position = originalPos;
            }
            if(collisionInfo.collider.name=="Item1")
            {
                if (player.currentItem == item1.itemId)
                {
                    player.iscollected = true;
                    Debug.Log("Check1");
                }
            }
            if (collisionInfo.collider.name == "Item2")
            {
                if (player.currentItem == item2.itemId)
                {
                    player.iscollected = true;
                    Debug.Log("Check2");
                }
            }
            if (collisionInfo.collider.name == "Item3")
            {
                if (player.currentItem == item3.itemId)
                    player.iscollected = true;
                Debug.Log("Check3");
            }
            if (collisionInfo.collider.name == "Item4")
            {
                if (player.currentItem == item4.itemId)
                    player.iscollected = true;
                Debug.Log("Check4");
            }
            if (collisionInfo.collider.name == "Item5")
            {
                if (player.currentItem == item5.itemId)
                    player.iscollected = true;
                Debug.Log("Check5");
            }
            if (collisionInfo.collider.name == "Item6")
            {
                if (player.currentItem == item6.itemId)
                    player.iscollected = true;
                Debug.Log("Check6");
            }
            if (collisionInfo.collider.tag=="Gate")
            {
                if (player.iscollected && gate1.currentItem == levelSettings.numItems)
                    player.isdeposited = true;
                if (player.isdeposited == true)
                    Application.Quit();
                if(player.iscollected)
                {
                    player.currentItem = player.currentItem + 1;
                    Debug.Log(player.currentItem);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                   gate1.currentItem= gate1.changeItem(player.currentItem);
=======
=======
>>>>>>> parent of fa35a1b... Minor tweaks and balances, increased encapsulation and abstraction, Added more notes
                
>>>>>>> parent of fa35a1b... Minor tweaks and balances, increased encapsulation and abstraction, Added more notes
=======
                   gate1.currentItem= gate1.changeItem(player.currentItem);
>>>>>>> parent of 3f135c7... Map Balancing and bugfixes
                }
            }
    }
        
    }
}