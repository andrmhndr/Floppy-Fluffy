using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    private GameObject spawner;

    public int cloudNumber;
    public float speed;
    public int distance = 20;

    private Vector2 target;

    void Start()
    {
        spawner = GameObject.Find("cloudSpawner");
        speed = spawner.GetComponent<cloudSpawner>().cloudSpeed[cloudNumber];
        target = new Vector2(-distance, transform.position.y);
    }

    void Update()
    {
        transform.localPosition = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if(transform.position.x == -distance)
        {
            Destroy(gameObject);
        }
    }
}
