using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeGameManager : MonoBehaviour
{
    public Vector3 startPosition;
    [SerializeField]
    private Vector3 homePosition;
    private Vector3 distance;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Hello Welcome to my game Go Home");
        print("Instructions how to play the game");
        print("Press up-arrow to move to forward /n Press down-arrow to move backward");
        print("My start position is " + startPosition);
        print("My home position is  " + homePosition);
        distance = homePosition - startPosition;// Vector 3 
        print("The distance to cover is " + distance.magnitude);
        if (startPosition == homePosition)
            print("We are in home");
        //float finalDistance = distance.magnitude;//-this line//Postive 
        //if (finalDistance > 0)
        //    print("To move forward");
        //else if (finalDistance < 0)
        //    print("To move backward");
        //else if (finalDistance == 0)
        //    print("You reached home");

    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerMovement(KeyCode.UpArrow,new Vector3(0,1,0));
        CheckPlayerMovement(KeyCode.DownArrow,new Vector3(0,-1,0));
        CheckPlayerMovement(KeyCode.LeftArrow,new Vector3(-1,0,0));
        CheckPlayerMovement(KeyCode.RightArrow,new Vector3(1,0,0));
        CheckPlayerMovement(KeyCode.M,new Vector3(0,0,1));
        CheckPlayerMovement(KeyCode.N,new Vector3(0,0,-1));
    }

    private void CheckPlayerMovement(KeyCode arrow,Vector3 value)
    {

        if (Input.GetKeyDown(arrow))
        {
            //print("up-arrow is pressed");
            startPosition = startPosition + value;
            distance = homePosition - startPosition;

            print("distance to home is " + distance.magnitude);
            //float finaldistance = distance.magnitude;
            //if (finaldistance < 0)
            //{
            //    print("Please press downarrow to move backward");
            //}
            //else if (finaldistance > 0)
            //    print("please press uparrow to forward");

            if (startPosition == homePosition)
                print("You reached home");

        }
    }
}
