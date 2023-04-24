using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    public ZombieSpawner[] spawners;
    public int currentWave = 0;

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Zombie").Length == 0)
        {
            currentWave++;
            if (currentWave < spawners.Length)
            {
                spawners[currentWave].gameObject.SetActive(true);
            }
        }
    }
}

