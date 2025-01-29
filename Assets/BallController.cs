using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f; //ball speed doubled 
    public float jumpPower = 5f; //jump power
    public bool isGrounded = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) //tagged plane as Ground
        {
            isGrounded = true; //Allowed to jump!
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; //Jumped!
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 inputVector = Vector2.zero;

        if(Input.GetKey(KeyCode.W)) 
        {
            inputVector += Vector2.up;
        }

        if(Input.GetKey(KeyCode.A)) 
        {
            inputVector += Vector2.left;
        }

        if(Input.GetKey(KeyCode.S)) 
        {
            inputVector += Vector2.down;
        }

        if(Input.GetKey(KeyCode.D)) 
        {
            inputVector += Vector2.right;
        }

        if(Input.GetKey(KeyCode.Space)) 
        {
            
        }
        
        if (isGrounded)
        {
            // Example: Allow jumping only when grounded
            if (Input.GetKeyDown(KeyCode.Space))
            {
                sphereRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse); //Jump!
                
            }
        }

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}