using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [Header("Setup")]
    public Transform tile;
    public float mouseForce = 60f;

    Rigidbody rb;

    
    bool touchingWall;
    Vector3 wallNormal;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.mass = Mathf.Max(5f, rb.mass);
        rb.linearDamping = 0f;
        rb.angularDamping = 0.3f;

       
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }

    void FixedUpdate()
{
    float mouseX = Input.GetAxis("Mouse X");
    if (Mathf.Abs(mouseX) < 0.01f) return;

    float y = Mathf.Abs(Mathf.DeltaAngle(tile.eulerAngles.y, 0f));
    bool leftWall = y < 45f;

    
    Vector3 worldSideways = leftWall ? -Vector3.forward : -Vector3.right;

    if (touchingWall)
    {
        rb.linearVelocity = Vector3.ProjectOnPlane(rb.linearVelocity, wallNormal);
    }

    rb.AddForce(worldSideways * mouseX * mouseForce, ForceMode.Acceleration);
}


    
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            touchingWall = true;
            wallNormal = collision.contacts[0].normal;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            touchingWall = false;
        }
    }
}
