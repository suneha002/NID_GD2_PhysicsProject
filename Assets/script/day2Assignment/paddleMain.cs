
using UnityEngine;

public class paddleMain : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
          if (Input.GetKey(KeyCode.W))
        {
          
           transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+0.1f);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
           
           transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-0.1f);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
           
           transform.position = new Vector3(transform.position.x-0.1f,transform.position.y,transform.position.z);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
           
           transform.position = new Vector3(transform.position.x+0.1f,transform.position.y,transform.position.z-0.1f);
            
        }
    }
}
