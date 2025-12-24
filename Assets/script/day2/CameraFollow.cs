
//using System.Numerics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject targetObject;
    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=targetObject.transform.position + offset;
    }
}
