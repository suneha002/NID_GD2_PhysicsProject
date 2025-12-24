using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //Debug.Log("hi! i'm start!");

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log("hi! i'm update!");
        //did the player press button?
        if (Input.GetKey(KeyCode.W))
        {
           Debug.Log("Pressed w!");
           //move the player
           transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+0.1f);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
           Debug.Log("Pressed w!");
           //move the player
           transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-0.1f);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
           Debug.Log("Pressed w!");
           //move the player
           transform.position = new Vector3(transform.position.x-0.1f,transform.position.y,transform.position.z);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
           Debug.Log("Pressed w!");
           //move the player
           transform.position = new Vector3(transform.position.x+0.1f,transform.position.y,transform.position.z-0.1f);
            
        }
        if (Input.GetKey(KeyCode.G))
        {
           Debug.Log("Pressed w!");
           //move the player
           transform.position = new Vector3(transform.position.x,transform.position.y+0.2f,transform.position.z+0.1f);
            
        }
        
    }
}
