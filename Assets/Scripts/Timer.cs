using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text textTimer;
    public float time = 50;
    public bool rotation = false;
    void Update()
    {
        if(time > 0){
        time -= Time.deltaTime;
        textTimer.text = "Tiempo: " + time.ToString("f0");
        }
        if(time <= 10){
            rotation = true;
        }
        if(time <= 0){
           GameObject scripted = GameObject.Find("Scripted");
           scripted.GetComponent<Game_Over_Manager>().lose(true); 
        }
    }
}
