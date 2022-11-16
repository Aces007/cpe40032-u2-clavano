using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Stores our prefab animals inside an array.
    public GameObject[] animalPrefabs;
    // Variables of animals' spawn range and spawn position topBound.
    private float spawnRangeX = 11;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float startInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // This line reads we will repatedly call SpawnRandomAnimal() starting at 2seconds and call it again every 1.5seconds.
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void SpawnRandomAnimal()
    {
        // Randomly Generate animals index thus random spawn positions.
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // Will clone our animalPrefabs so they could be spawned in the game.
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
