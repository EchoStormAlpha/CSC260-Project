using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets
{


    public class Player_Collision : MonoBehaviour {
        Vector3 originalPos;
        // Use this for initialization
        levelSettings levelSettings = new levelSettings();
        Player player = new Player();
        Gate gate1 = new Gate();
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
    }
    }
}