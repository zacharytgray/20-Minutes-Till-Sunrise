using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Intstance;
    public void Awake(){
        Intstance = this; 
    }

    public  enum Scene{
        TitleScreen,
        GameOver,
        Stage,
        Instructions
    }

    public static void LoadScene(Scene scene){
        SceneManager.LoadScene(scene.ToString());
    }

    public static void LoadTitle(){
        LoadScene(Scene.TitleScreen);
    }

    public static void LoadGameOver(){
        LoadScene(Scene.GameOver);
    }

    public static void LoadStage(){
        LoadScene(Scene.Stage);
    }

    public static void LoadInstruct(){
        LoadScene(Scene.Instructions );
    }
    
}
