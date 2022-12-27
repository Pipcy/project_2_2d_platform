using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //room camera
    // [SerializeField] private float speed;
    // private float currentPosX;
    // private Vector3 velocity = Vector3.zero;

    //follow player
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;
    private float side;
    
    private void Update()
    {
        
        /*Room camera
        the damping effect of the camera movement
        parameter: smoothDamp("current cam pos", "new cam pos", ref "velocity", "speed" * timr.deltaTime) 
        
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), 
        ref velocity, speed * Time.deltaTime);
        */

        //Follow player
        /*some mod: the original video uses localscale.x to determine the left and right pan of the camera
        but because we mod the code to be independent of the localscale.x, so this value is no longer useable
        so instead we use the sign user input "horizontalInput" to get a direction (negative = left, positive = right)
        */
        float horizontalInput = Input.GetAxis("Horizontal");
        //Debug.Log(horizontalInput);
        if (horizontalInput >=0.5){ //-0.5 to 0.5 is a threshold
            side = 1;
        }
        else if (horizontalInput <= -0.5){
            side = -1;
        }
        else{
            side = 0;
        }
        //Debug.Log(side+ " "+ horizontalInput);

        transform.position = new Vector3(player.position.x + lookAhead, player.position.y,
        transform.position.z); //follow player pos on the x and y axis
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * side), Time.deltaTime * cameraSpeed); //note "side"


    }

    public void MoveToNewRoom()
    {
        ;
    }
    
}

