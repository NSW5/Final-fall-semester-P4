using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
<<<<<<< HEAD
    public int coinAmount 10;
    public float areaRange = 45f;

=======
    public int coinAmount = 10;
    public float areaRange = 45f;
>>>>>>> 1fa9c7cbd2a7d532318787946b6f9be39368d520
    public GameObject collectibleObject;
    public GameObject enemyObject;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        SpawnEnemyObject();
=======
        //SpawnEnemyObject();
        StartCoroutine(SpawnRandomAmountOfEnemies());
>>>>>>> 1fa9c7cbd2a7d532318787946b6f9be39368d520
        SpawnCollectibleObject();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======

>>>>>>> 1fa9c7cbd2a7d532318787946b6f9be39368d520
    }

    void SpawnEnemyObject()
    {
<<<<<<< HEAD
        Instantiate(enemyObject, new Vector3(0, 1, 10), enemyObject.transform.rotation);
    }

    void SpawnCollectibleObject()
    {
        Instantiate(collectibleObject, new Vector3(0, 1, 15), collectibleObject.transform.rotation);
=======
        Instantiate(enemyObject, RandomSpawnPosition(), enemyObject.transform.rotation);
    }

    public void SpawnCollectibleObject()
    {
        for (int i = 0; i < coinAmount; i++)
        {
            Instantiate(collectibleObject, RandomSpawnPosition(), collectibleObject.transform.rotation);
        }
        coinAmount = 2;
>>>>>>> 1fa9c7cbd2a7d532318787946b6f9be39368d520
    }

    Vector3 RandomSpawnPosition()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-areaRange, areaRange), 1f, Random.Range(-areaRange, areaRange));

        return spawnPosition;
    }
<<<<<<< HEAD
=======

    IEnumerator SpawnRandomAmountOfEnemies()
    {
        while (true)
        {
            int randomSeconds = Random.Range(1, 8);

            yield return new WaitForSeconds(randomSeconds);

            int numberOfEnemies = Random.Range(1, 3);

            for (int i = 0; i < numberOfEnemies; i++)
            {
                Instantiate(enemyObject, RandomSpawnPosition(), enemyObject.transform.rotation);
            }
        }
    }
>>>>>>> 1fa9c7cbd2a7d532318787946b6f9be39368d520
}
