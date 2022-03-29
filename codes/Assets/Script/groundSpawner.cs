using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject ground;
    float time = 0;
    public float timer = 2;

    void Update()
    {
        if (time <= 0)
        {
            Instantiate(ground, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
