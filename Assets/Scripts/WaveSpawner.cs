using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public int enemiesPerWave = 5;

    private int waveNumber = 0;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        waveNumber++;

        for (int i = 0; i < enemiesPerWave; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitForSeconds(timeBetweenWaves);
        StartCoroutine(SpawnWave());
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
