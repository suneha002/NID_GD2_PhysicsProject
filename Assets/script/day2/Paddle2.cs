
using UnityEngine;

public class Paddle2 : MonoBehaviour
{

    private Rigidbody rb2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 forceToAdd= new Vector3(0,0,0);
        //get initial position, add force in direction of player input

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //force to left
            forceToAdd += Vector3.left*5;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            forceToAdd += Vector3.right*5;
        }

        //force in direction of player input
        rb2.AddForce(forceToAdd);


    }
}
