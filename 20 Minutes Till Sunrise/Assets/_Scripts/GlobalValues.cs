using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GlobalValues : MonoBehaviour
{
    
    public GameObject highScoreObject;
    static public TextMeshProUGUI HSText;
    public int nextHS = 0;
    public int score = 0;
    public static int _highScore;
    public static int highScore{
        get{return _highScore;}
        private set{
            _highScore = value;
            if(HSText != null){
               HSText.text = "High Score: " + value.ToString("#,0");
               Debug.Log("Updated");
            }
        }
    }

    public static GlobalValues GlobalVarsInstance;
    
    

    void Awake()
    {
        nextHS = 0;
        HSText =  highScoreObject.GetComponent<TextMeshProUGUI>();
        updateHighScore(nextHS, true);
        Debug.Log(HSText == null);

        GlobalVarsInstance = this;
       
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void updateHighScore(int newHS, bool reset ){ //UNFINISHED; TEMPORARY FOR DEBUG
        if(newHS > highScore || reset){
            highScore = newHS;
        }
    }
    
}
