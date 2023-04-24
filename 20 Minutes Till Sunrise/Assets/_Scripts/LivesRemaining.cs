using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class LivesRemaining : MonoBehaviour
{

    public Text LivesLabel;
    // Start is called before the first frame update
    void Start()
    {
        LivesLabel.text = "Lives: 3";
    }

    // Update is called once per frame
    void Update()
    {
        int lives = PlayerPrefs.GetInt("Lives");
        LivesLabel.text = "Lives: " + lives.ToString();
        // print(lives);
    }

}
