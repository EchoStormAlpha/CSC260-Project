using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets
{
    

    public class Player_Collision : MonoBehaviour {
        Vector3 originalPos;
        // Use this for initialization
        public levelSettings levelSettings = new levelSettings();
        public Player player = new Player();
        public Item item1 = new Item(1);
        public Gate gate1 = new Gate();
        void Start() {
            
            originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        // Update is called once per frame
        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Obstacle")
            {
                player.iscollected = false;
                gameObject.transform.position = originalPos;
            }
            if(collisionInfo.collider.tag=="Item")
            {
                if (player.currentItem == item1.currentItem)
                    player.iscollected = true;
            }
            if(collisionInfo.collider.tag=="Gate")
            {
                if (player.currentItem == gate1.currentItem && gate1.currentItem == levelSettings.numItems)
                    player.isdeposited = true;
                if (player.isdeposited == true)
                    Debug.Log("winner");
            }
    }
        
    }
}