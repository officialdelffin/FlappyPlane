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


        startPosition.x = -6;
        startPosition.y = 0;
        startPosition.z = 0;


        boundaryY = -4.5f;


        transform.position = startPosition;



    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
        
        
            planeRigidyBory.linearVelocity = Vector2.up * upwardForce;


        }


        if (transform.position.y <= boundaryY)
        {


            transform.position = new Vector3(transform.position.x, boundaryY, transform.position.z);



        } 
       

        
    }


}
