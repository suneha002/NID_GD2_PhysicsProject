using UnityEngine;

public class addForceBall : MonoBehaviour
{
    private Rigidbody rball;
    public float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        force= Random.Range(7f,15f);
        rball= GetComponent<Rigidbody>();
        Vector3 forceVector= new Vector3(force,0,0);
        rball.AddForce(forceVector);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
