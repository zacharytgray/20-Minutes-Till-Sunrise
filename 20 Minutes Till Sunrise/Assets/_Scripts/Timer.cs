using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Stopwatch watch;
    private Text uiText;
    public string currentTime;
    int totalSeconds;
    void Start()
    {
        currentTime = "0:00";
        totalSeconds = 0;
        uiText = GetComponent<Text>();
        print(uiText.text);
        watch = new Stopwatch();
        watch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = watch.Elapsed.ToString(@"m\:ss");
        uiText.text = currentTime;
        TimeSpan ts = TimeSpan.Parse(currentTime);
        totalSeconds = (int)ts.TotalSeconds/60;
    }

    public void Restart()
    {
        watch = new Stopwatch();
        watch.Start();
    }

    public string getCurrentTime()
    {
        return currentTime;
    }

    public int getCurrentScore()
    {
        return totalSeconds;
    }
}
