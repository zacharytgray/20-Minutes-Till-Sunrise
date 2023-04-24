using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TMTS : MonoBehaviour
{

    public Timer timer;
    public PlayerController player;
    public string finalTime = "0:00";

    void Start()
    {
        //Instantiate fields that need instantiating
    }


    void Update()
    {

    }

    //player calls playerDead on this when health = 0
    void playerDead()
    {
        finalTime = timer.getCurrentTime();
        Invoke("gameOver", 5.0f);
    }

    void gameOver()
    {
        //load end scene
    }
}
