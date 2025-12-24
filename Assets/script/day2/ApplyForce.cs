//using System.Numerics;
using UnityEngine;



//apply force only at the start
public class ApplyForce : MonoBehaviour
{
    
    //refs
    private Rigidbody rb;
    
    public float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //get refs
        rb= GetComponent<Rigidbody>();

        //create the force vector
        Vector3 forceVector = new Vector3(force,0,0);

        //apply a force to the rigidbody in one direction
        rb.AddForce(forceVector);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
