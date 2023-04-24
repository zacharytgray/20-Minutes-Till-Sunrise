using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ButtonPress : MonoBehaviour
{
    public static GlobalValues values;
    // public int HS = 0;
    

     void Start(){
        GameObject HSDisplay = GameObject.Find("Canvas");
        values = HSDisplay.GetComponent<GlobalValues>();
        Debug.Log(values.nextHS);
    }

    public void StartButtonPress(){
        Debug.Log("Game Start");
    }

    public void InstructButtonPress(){
        Debug.Log("Instructions Open");
    }

    public void quitButtonPress(){
        Application.Quit();
    }

    public void debugHighScoreAdd1(){
        values.nextHS+=1;
        values.updateHighScore(values.nextHS);
        Debug.Log(values.nextHS);
       
    }

    public void debugHighScoreReset(){
        values.nextHS = 0;
        values.updateHighScore(values.nextHS);
    }

     void Update(){
       
    }
}
