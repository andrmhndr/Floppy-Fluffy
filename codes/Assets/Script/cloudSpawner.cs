using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    public float minY;
    public float maxY;

    [SerializeField]
    private GameObject[] cloud;

    [SerializeField]
    private float[] cloudSpawnTime;

    [SerializeField]
    public float[] cloudSpeed;

    void Start()
    {
        InvokeRepeating("spawnCloud0", cloudSpawnTime[0], cloudSpawnTime[0]);
        InvokeRepeating("spawnCloud1", cloudSpawnTime[1], cloudSpawnTime[1]);
        InvokeRepeating("spawnCloud2", cloudSpawnTime[2], cloudSpawnTime[2]);
    }

    private void spawnCloud0()
    {
        float y =Random.Range(minY, maxY);
        Instantiate(cloud[0], new Vector2(transform.position.x, y), Quaternion.identity);
    }

    private void spawnCloud1()
    {
        float y =Random.Range(minY, maxY);
        Instantiate(cloud[1], new Vector2(transform.position.x, y), Quaternion.identity);
    }

    private void spawnCloud2()
    {
        float y =Random.Range(minY, maxY);
        Instantiate(cloud[2], new Vector2(transform.position.x, y), Quaternion.identity);
    }
}
