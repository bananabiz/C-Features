using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbitWithPanAndZoom : MonoBehaviour
{
    public Transform target; //Target object to orbit around
    public float panSpeed = 5f; //Speed of panning
    public float sensitivity = 1f; //Sensitivity of mouse

    //Minimum and maximum zoom distance
    public float distanceMin = 0.5f;
    public float distanceMax = 15f;

    private float distance = 0f; //Current distance between target and camera
    //Stored X & Y euler rotation
    private float x = 0.0f;
    private float y = 0.0f;

    //Create an enum to use for mouse input (just for readability)
    public enum MouseButton
    {
        LeftMouse = 0,
        RightMouse = 1,
        MiddleMouse = 2,
    }

    void Start()
    {
        //Call target transform's SetParent(null)

        //... Detaches the target from childre


        //Set distance = Vector3.Distance(targets's position, transform's position)

        //... Calculates distance to target


        //Let angles = transform's eulerAngles

        //Set x = angles.x

        //Set y = angles.y

        //... Records the current euler rotation

    }

    void Orbit()
    {
        //Set x = x + Input Axis "Mouse X" x sensitivity

        //Set y = y - Input Axis "Mouse Y" x sensitivity

    }

    void Movement()
    {
        //If target != null

            //Let rotation = Quaterion Euler(x, y, 0)


            //Let desiredDist = distance - Input Axis "Mouse ScrollWheel"


            //Set desiredDist = desiredDist x sensitivity

            //... Amplifies desiredDist by sensitivity (Scroll Speed)


            //Set distance = Mathf Clamp (desiredDist, distanceMin, distanceMax);

            //... Clamps the result so that distance doesn't go outside of constraints


            //Let invDistanceZ = new Vector3(0, 0, -distance)


            //Set invDistanceZ = rotation * invDistanceZ

            //... Rotates the direction of vector to be local to camera


            //Let position = target.position + invDistanceZ


            //Set transform.rotation = rotation

            //Set transform.position = position

    }

    //Moves the target using X and Y mouse coordinates to create panning effect
    void Pan()
    {
        //Let inputX = -Input GetAxis "Mouse X"

        //Let inputY = -Input GerAxis "Mouse Y"


        //Let inputDir = new Vector3(inputX, inputY)


        //Let movement = transform.TransformDirection(inputDir)

        //Set target.transform.position += movement x panSpeen x deltaTime

    }

    //Hides/Unhides the cursor
    void HideCursor(bool isHiding)
    {
        //If isHiding

        //Lock the cursor

        //Hide the cursor

        //Else

        //Unlock the cursor

        //Unhide the cursor
        
    }

    
    // Update is called once per frame
    void Update ()
    {
		
	}


    void LateUpdate()
    {
        //If Input MouseButton Right
        if (Input.GetMouseButton((int)MouseButton.RightMouse))
        {
            //Call HideCursor(true) ... Hides the cursor

            //Call Orbit() ... Update orbit of the camera

        }
        //Else if Input MouseButton Middle

            //Call HideCursor(true)

            //Call Pan() ... Pans the camera

        //Else

            //Call HideCursor(false) ... Unhides the cursor


        //Call Movement() ... Always update movement regardless of any input

    }
}
