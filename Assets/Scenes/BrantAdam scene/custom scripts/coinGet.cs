using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinGet : MonoBehaviour {
    private GameObject Game_Manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            //GameObject.GetComponent<collisionRevision>.TickUpScore();






            // WHY WON'T THIS WORK AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA!!!!!!!!!!!!!!!!!!!







            Game_Manager.GameManager.TickUpScore();
            Destroy(other.gameObject);
        }
    }
    
}
