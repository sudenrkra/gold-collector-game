using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnRangeX = 5f;
    public float spawnRangeZ = 5f;
    public float minSpawnTime = 0.2f;
    public float maxSpawnTime = 1.5f;

    private GameObject player;
    private float yOffset = 1f;
    private float groundY;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        groundY = GameObject.Find("Plane").transform.position.y;
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            if (player != null)
            {
                float randomX = Random.Range(player.transform.position.x - spawnRangeX, player.transform.position.x + spawnRangeX);
                float spawnZ = player.transform.position.z + Random.Range(6f, 12f);

                Vector3 spawnPosition = new Vector3(randomX, groundY + yOffset, spawnZ);
                Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
            }

            float waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
