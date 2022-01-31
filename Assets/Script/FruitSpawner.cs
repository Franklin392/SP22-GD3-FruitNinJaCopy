using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();

    public GameObject fruitPrefab1;
    public GameObject fruitPrefab2;
    public GameObject fruitPrefab3;
    public GameObject fruitPrefab4;

    public Transform[] spawnPoints;
    public float minDelay = 1f;
    public float maxDelay = 20f;
    public bool FirstRound;
     void Start()
    {
        prefabList.Add(fruitPrefab1);
        prefabList.Add(fruitPrefab2);
        prefabList.Add(fruitPrefab3);
        prefabList.Add(fruitPrefab4);

        //FirstRound = true;
        StartCoroutine(SpawnFruits_Start());
        
    }
   //void Update()
   // {
   //     if (FirstRound == true)
   //     {
   //         SpawnFruits_WithoutBumb();
   //     }

   //     if (FirstRound == false)
   //     {
   //         SpawnFruits();
   //     }

   // }

    IEnumerator SpawnFruits()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);


            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            int prefabIndex = Random.Range(0, 4);
            Instantiate(prefabList[prefabIndex], spawnPoint.position, spawnPoint.rotation);

        }



    }
    IEnumerator SpawnFruits_WithoutBumb()
    {
        float delay = Random.Range(minDelay, maxDelay);
        yield return new WaitForSeconds(delay);


        int spawnIndex = Random.Range(1, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        int prefabIndex = Random.Range(0, 3);
        Instantiate(prefabList[prefabIndex], spawnPoint.position, spawnPoint.rotation);
    }
    IEnumerator SpawnFruits_Start()
    {
        SpawnFruits_WithoutBumb();
        FirstRound = false;
        yield return new WaitForSeconds(1f);

        StartCoroutine(SpawnFruits());
    }
}
