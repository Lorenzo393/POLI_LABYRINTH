using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public Text scoreText;
    int score = 10;

    public void Raise_Score(int s){
        score += s;
        scoreText.text = "Puntaje: " + score + "";
        if(score <= 0){
            gameObject.GetComponent<Game_Over_Manager>().lose(true);
        }
    }
}
