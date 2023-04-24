using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Stopwatch watch;
    private Text uiText;
    void Start()
    {

        uiText = GetComponent<Text>();
        print(uiText.text);
        watch = new Stopwatch();
        watch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = watch.Elapsed.ToString(@"m\:ss");
    }

    public void Restart()
    {
        watch = new Stopwatch();
        watch.Start();
    }
}
