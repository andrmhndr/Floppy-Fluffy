using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virusSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] barier;
    int random;
    float time = 0;
    public float timer = 2;

    void Update()
    {
        if (time <= 0)
        {
            random = Random.Range(0, barier.Length);
            Instantiate(barier[random], transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
