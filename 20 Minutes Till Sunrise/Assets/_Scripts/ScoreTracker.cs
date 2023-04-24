using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int score = 0;
    public static ScoreTracker ScoreTrackerInstance;

    void Awake(){
        ScoreTrackerInstance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void resetScore(){
        score = 0;
    }

    public void increaseScoreBy(int num){
        score += num;
    }
}
