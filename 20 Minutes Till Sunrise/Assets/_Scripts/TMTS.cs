using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class TMTS : MonoBehaviour
{
    private static TMTS S;
    public Timer timer;
    public PlayerController player;
    public int finalScore = 0;


    void Start()
    {
        S = this;
        //Instantiate fields that need instantiating
    }


    void Update()
    {
    }

    int getCurrentScore()
    {
        return timer.getCurrentScore();
    }

    //player calls playerDead on this when health = 0
    public static void playerDead()
    {
        S.finalScore = S.getCurrentScore();
        S.Invoke("gameOver", 3.0f);
    }

    void gameOver()
    {
        ScoreTracker.ScoreTrackerInstance.score = finalScore;
        GlobalValues.GlobalVarsInstance.updateHighScore(finalScore, false);
        ScenesManager.LoadGameOver();
    }

}
