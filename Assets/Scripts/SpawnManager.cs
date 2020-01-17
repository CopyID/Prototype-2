using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        //generates random value's'
        int type = Random.Range(0, 50);
        int animalIndexType1 = Random.Range(0, 3);
        int animalIndexType2 = Random.Range(3, 6);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
//            int animalIndex = Random.Range(0, animalPrefabs.Length);
        //spawns a random animal
        if (type == 49)
        {
            Instantiate(animalPrefabs[animalIndexType2], spawnPos, animalPrefabs[animalIndexType2].transform.rotation);
        }
        else if (type <= 49)
        {
            Instantiate(animalPrefabs[animalIndexType1], spawnPos, animalPrefabs[animalIndexType1].transform.rotation);
        }
    }
}
