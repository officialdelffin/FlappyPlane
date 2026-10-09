using System.Runtime.CompilerServices;
using UnityEngine;


// Class that controls the plane's behavior in the game
public class PlaneControler : MonoBehaviour
{


    // Attributes :
    private Vector3 startPosition;
    private float boundaryY;
    [SerializeField] private Rigidbody2D planeRigidyBory;
    [SerializeField] private float upwardForce;



    // Start is called once before the first execution of Update after the PlaneControler is created
    void Start()
    {


        // Initialize the starting position of the plane
        startPosition.x = -6;
        startPosition.y = 0;
        startPosition.z = 0;


        // Define the lower boundary
        boundaryY = -4.5f;


        // Set the plane's position to the starting position
        transform.position = startPosition;



    }


    // Update is called once per frame
    void Update()
    {

        // Check if the space key is pressed to trigger upward movement
        if (Input.GetKeyDown(KeyCode.Space)) { upwardMovement(); }


        // Check if the plane has reached the lower boundary and adjust its position if necessary
        if (transform.position.y <= boundaryY) { definedLimitGround(); }
       

    }


    // Method to apply upward movement to the plane
    private void upwardMovement()
    {
         

        planeRigidyBory.linearVelocity = Vector2.up * upwardForce;


    }


    // Method to define the lower boundary for the plane's position
    private void definedLimitGround() 
    {


        transform.position = new Vector3(transform.position.x, boundaryY, transform.position.z);


    }
 

}



