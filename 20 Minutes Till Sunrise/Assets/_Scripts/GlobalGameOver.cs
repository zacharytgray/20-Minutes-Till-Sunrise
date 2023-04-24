using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalGameOver : MonoBehaviour
{
    public GameObject GameOverText; 
    public TextMeshProUGUI GameOverScore;
    public static GlobalGameOver GameOverInstance;
    
    public void Awake(){
        GameOverScore = GameOverText.GetComponent<TextMeshProUGUI>();
        GameOverInstance = this;
    }

    public void Start(){
        updateScoreText(ScoreTracker.ScoreTrackerInstance.score);
      
        Debug.Log(ScoreTracker.ScoreTrackerInstance.score + "Start");
    }

    public void updateScoreText(int score){
        GameOverScore.text = "Your Final Score Was: " + score.ToString("#,0");
        
    }

}
