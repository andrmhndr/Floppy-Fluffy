using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public int speed = 10;
    public int distance = 100;

    private Vector2 target;

    void Update()
    {
        target = new Vector2(-distance, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position.x == -distance)
        {
            Destroy(gameObject);
        }
    }
}
