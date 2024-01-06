using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public GameObject level;
    public float spawnTime = 5f;
    void Start()
    {
        InvokeRepeating("levelSpawner", spawnTime ,spawnTime);
    }

    void levelSpawner()
    {
        Instantiate(level);
    }
}
