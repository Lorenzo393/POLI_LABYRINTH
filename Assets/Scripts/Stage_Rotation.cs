using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Rotation : MonoBehaviour
{
    public Timer timer;
    private float angle_rotation = 1;
    void FixedUpdate(){
        if(timer.rotation == true){
            gameObject.transform.Rotate(angle_rotation * Vector3.up, Space.World);
        }
    }
}
