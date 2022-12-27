/* 
copied from pill game, change vector3 to vector2 to accomodate 2d

waypoint are key points that sets the begining
 and ending for the platform to move to.

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints; //an array of points
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        //Debug.Log(currentWaypointIndex);
        if (Vector2.Distance(transform.position,waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)//if reach the end of waypoint array
            {
                currentWaypointIndex = 0;
            }
        }

        //move toward 
        transform.position = Vector2.MoveTowards(transform.position,waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    

        //flip the ghost scale when moving to the right
        if (currentWaypointIndex == 1)
        {
            transform.localScale = new Vector3(-3,3,3);
        }
        else
        {
            transform.localScale = new Vector3(3,3,3);
        }
    }
}