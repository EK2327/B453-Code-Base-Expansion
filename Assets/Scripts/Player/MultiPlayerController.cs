using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayerController : PlayerController
{
    [SerializeField] PlayerNumber playerNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        horizontalMovement = Input.acceleration.x / 2;
        verticalMovement = Input.acceleration.y / 2;
#else
        if (playerNumber == PlayerNumber.One)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                horizontalMovement = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                horizontalMovement = 1;
            }
            else
            {
                horizontalMovement = 0;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                verticalMovement = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                verticalMovement = -1;
            }
            else
            {
                verticalMovement = 0; 
            }
        }
        else if (playerNumber == PlayerNumber.Two)
        {
            if (Input.GetKey(KeyCode.A))
            {
                horizontalMovement = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                horizontalMovement = 1;
            }
            else
            {
                horizontalMovement = 0;
            }
            if (Input.GetKey(KeyCode.W))
            {
                verticalMovement = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                verticalMovement = -1;
            }
            else
            {
                verticalMovement = 0;
            }
        }
#endif
    }
}
