using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Limit : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider){
        if(collider.gameObject.CompareTag("Red_Ball")){
            Destroy(collider.gameObject);
            GameObject scripted = GameObject.Find("Scripted");
            scripted.GetComponent<Score_Manager>().Raise_Score(1);
            scripted.GetComponent<Game_Over_Manager>().lose2(-1);
        }
    }
}
