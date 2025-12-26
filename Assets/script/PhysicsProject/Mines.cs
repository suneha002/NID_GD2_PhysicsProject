
using System.Runtime.CompilerServices;
using UnityEngine;

public class Mines : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed=0.4f;
    public float destroyY=6f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up*speed*Time.deltaTime;
        if (transform.position.y > destroyY)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Spike"))
        {
            Destroy(gameObject);
        }
    }
}
