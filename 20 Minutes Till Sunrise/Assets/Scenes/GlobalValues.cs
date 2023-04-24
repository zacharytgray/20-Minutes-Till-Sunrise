using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GlobalValues : MonoBehaviour
{
    
    public GameObject highScoreObject ;
    static public TextMeshProUGUI HSText;
    public int nextHS = 0;
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
    void Awake()
    {
        nextHS = 0;
        HSText =  highScoreObject.GetComponent<TextMeshProUGUI>();
        updateHighScore(nextHS);
        Debug.Log(HSText == null);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void updateHighScore(int newHS){ //UNFINISHED; TEMPORARY FOR DEBUG
        highScore = newHS;
    }
}
