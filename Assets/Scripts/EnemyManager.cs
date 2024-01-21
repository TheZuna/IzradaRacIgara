using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject zombie;
    public Transform[] spawnPoints;
    public float spawnTime = 3f;

    void Start()
    {
        Spawn();
        //InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(zombie, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}