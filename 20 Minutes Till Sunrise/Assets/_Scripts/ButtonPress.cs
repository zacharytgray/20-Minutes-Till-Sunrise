using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ButtonPress : MonoBehaviour
{
    //public static GlobalValues values;
    // public int HS = 0;
    
       

     void Start(){
        GameObject HSDisplay = GameObject.Find("StartCanvas");
        GlobalValues.GlobalVarsInstance = HSDisplay.GetComponent<GlobalValues>();
        // Debug.Log(GlobalValues.GlobalVarsInstance.nextHS);

        
    }

    public void StartButtonPress(){
        Debug.Log("Game Start");
        ScenesManager.LoadStage();
    }

    public void InstructButtonPress(){
        Debug.Log("Instructions Open");
        ScenesManager.LoadInstruct();
    }

    public void quitButtonPress(){
        Application.Quit();
    }

    public void debugHighScoreAdd1(){
        GlobalValues.GlobalVarsInstance.nextHS+=1;
        GlobalValues.GlobalVarsInstance.updateHighScore(GlobalValues.GlobalVarsInstance.nextHS, false);
        Debug.Log(GlobalValues.GlobalVarsInstance.nextHS);
       
    }

    public void debugHighScoreReset(){
        GlobalValues.GlobalVarsInstance.nextHS = 0;
        GlobalValues.GlobalVarsInstance.updateHighScore(GlobalValues.GlobalVarsInstance.nextHS, true);
    }

    public void gameOver(){
        ScenesManager.LoadGameOver();
    }
    

    public void ReturnToMenu(){
        debugHighScoreReset();
         ScoreTracker.ScoreTrackerInstance.score = 0;
        ScenesManager.LoadTitle();
    }

    public void increaseScoreBy1(){
        ScoreTracker.ScoreTrackerInstance.increaseScoreBy(1);
        Debug.Log(ScoreTracker.ScoreTrackerInstance.score + "Press");
    }

    public void exitInstructions(){
        ScenesManager.LoadTitle();
    }
    

}
