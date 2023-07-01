using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour{

    public Game_Over_Manager go;
    public int speed = 10;
    private Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody> ();
    }
    
    void FixedUpdate(){
        if(go.game_over == false){
            float move_horizontal = Input.GetAxis("Horizontal");
            float move_vertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(move_horizontal , 0.0f , move_vertical);
            rb.AddForce(movement * speed);
        }
    }
}
