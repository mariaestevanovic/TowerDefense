using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;
    private int waypointIndex = 0;
    public float speed = 2f;

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].position, speed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].position)
            {
                waypointIndex++;
            }
        }
    }
}
