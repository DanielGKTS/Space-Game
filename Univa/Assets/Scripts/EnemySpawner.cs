using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 3f;
    public float spawnRange = 5f;
        
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Prefab Spawner Start");
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        while (true)
        {
            SpawnPrefabs();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnPrefab()
    {
		Debug.Log("Spawn Prefab");
		float spawnZ = Random.Range(transform.position.z - spawnRange, transform.position.z + spawnRange);
		float spawnY = Random.Range(transform.position.y - spawnRange, transform.position.y + spawnRange);
		Vector3 spawnPosition = new Vector3(transform.position.x, spawnY, spawnZ);
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}
