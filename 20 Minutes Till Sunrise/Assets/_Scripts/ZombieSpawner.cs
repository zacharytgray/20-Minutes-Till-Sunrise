using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnInterval;
    public int maxZombiesPerWave;


   // private int zombiesSpawned = 0;

    void Start()
    {
        waveMaker();
    }

    void waveMaker()
    {
        StartCoroutine(SpawnZombies());
        maxZombiesPerWave++;
        Invoke("waveMaker", 30f);
    }

    public IEnumerator SpawnZombies()
    {
        int zombiesSpawned = 0;
        while (zombiesSpawned < maxZombiesPerWave)
        {
            yield return new WaitForSeconds(Random.Range(spawnInterval - 0.5f, spawnInterval + 0.5f));
            Instantiate(zombiePrefab, transform.position, Quaternion.identity);
            zombiesSpawned++;
        }
    }
}
