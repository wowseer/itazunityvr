using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPathScript : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 1f;
    private int currentWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move(waypoints[currentWaypoint].position);
    }

    private void move(Vector3 targetPosition) 
    {
        Vector3 distance = targetPosition - transform.position;
        if(distance.magnitude < 1) {nextWaypoint();}
        Vector3 direction = Vector3.Normalize(distance);
        float stepLenght = speed * Time.deltaTime;
        transform.position += direction * stepLenght;
    }
    [ContextMenu("Next Waypoint")]
    private void nextWaypoint()
    {
        if (currentWaypoint == waypoints.Length - 1)
        {currentWaypoint = 0;}
        else {currentWaypoint++;}
    }
}
