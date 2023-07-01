using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions_2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Green_Ball")){
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameObject scripter = GameObject.Find("Scripted");
            scripter.GetComponent<Game_Over_Manager>().lose(true);
        }
    }
}
