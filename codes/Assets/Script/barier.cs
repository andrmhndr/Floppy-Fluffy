using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barier : MonoBehaviour
{
    public float minHeight = 0f;
    public float maxHeight = 0f;
    public int speed = 5;
    public int distance = 20;

    private Vector2 target;

    float randomValue;

    void Start()
    {
        randomValue = Random.Range(minHeight, maxHeight);
        transform.position = new Vector2(transform.position.x, randomValue);
        target = new Vector2(-distance, transform.position.y);
    }

    private void Update()
    {
        transform.localPosition = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if(transform.position.x == -distance)
        {
            Destroy(gameObject);
        }
    }

}
