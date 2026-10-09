using UnityEngine;


// Class that controls the plane's behavior in the game
public class PlaneControler : MonoBehaviour
{


    // Attributes :
    [SerializeField] private Rigidbody2D planeRigidyBory;
    [SerializeField] private float upwardForce;



    // Start is called once before the first execution of Update after the PlaneControler is created
    void Start()
    {


        

        
    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space)){
        
        
            planeRigidyBory.linearVelocity = Vector2.up * upwardForce;


        }

        
    }


}
