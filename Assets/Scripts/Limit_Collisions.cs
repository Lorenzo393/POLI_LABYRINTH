using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit_Collisions : MonoBehaviour
{
    public GameObject player;
    public GameObject blue_ball;
    public GameObject red_ball;
    public GameObject green_ball;
    private Rigidbody rigid_player;
    void Start(){
        rigid_player = player.GetComponent<Rigidbody> ();
    }
    private void OnCollisionEnter(Collision collision){

        if(collision.gameObject.CompareTag("Player")){
            rigid_player.velocity = Vector3.zero;
            rigid_player.angularVelocity = Vector3.zero;
            player.transform.position = new Vector3(0, 1, 0);
            }

        if (collision.gameObject.CompareTag("Blue_Ball")) {
            GameObject scripted = GameObject.Find("Scripted");
            scripted.GetComponent<Score_Manager>().Raise_Score(-1);

            Destroy(collision.gameObject);
            Instantiate(blue_ball, new Vector3(-6, 1, 0),Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Red_Ball")){
            GameObject scripted = GameObject.Find("Scripted");
            scripted.GetComponent<Score_Manager>().Raise_Score(-1);

            Destroy(collision.gameObject);
            Instantiate(red_ball, new Vector3(0, 1, 6), Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Green_Ball")){
            GameObject scripted = GameObject.Find("Scripted");
            scripted.GetComponent<Score_Manager>().Raise_Score(-1);

            Destroy(collision.gameObject);
            Instantiate(green_ball, new Vector3(6, 1, 0), Quaternion.identity);
        }
    }
    
}
