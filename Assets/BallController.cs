using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
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

        Debug.Log("Result Vector:" + inputVector);
    }
}
