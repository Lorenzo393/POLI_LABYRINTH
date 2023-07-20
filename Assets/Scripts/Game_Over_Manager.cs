using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Over_Manager : MonoBehaviour
{
    public Text gameoverText;
    public GameObject limit_collisions;
    public GameObject blue_limit;
    public GameObject red_limit;
    public GameObject green_limit;
    public bool game_over = false;
    public int game_over2 = 3;

    public void lose(bool go){
        game_over = go;
        gameoverText.text = "YOU LOSE";

        Destroy(gameObject.GetComponent<Timer>());
        Destroy(limit_collisions);
        Destroy(blue_limit);
        Destroy(red_limit);
        Destroy(green_limit);
    }

    public void lose2(int goi){
        game_over2 += goi;
        if(game_over2 <= 0){
            game_over = true;
            gameoverText.text = "YOU WIN";

            Destroy(gameObject.GetComponent<Timer>());
            Destroy(limit_collisions);
            Destroy(blue_limit);
            Destroy(red_limit);
            Destroy(green_limit);
        }
    }
}
