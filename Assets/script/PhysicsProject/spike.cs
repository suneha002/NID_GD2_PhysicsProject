using UnityEngine;

public class spike : MonoBehaviour
{
    Rigidbody rb2;

    public float stiffness = 150f;
    public float damping = 15f;

    // define the plane the mouse lives on
    Plane movementPlane;

    void Awake()
    {
        rb2 = GetComponent<Rigidbody>();

        // plane perpendicular to camera, passing through spike
        movementPlane = new Plane(Vector3.forward, transform.position);
    }

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (movementPlane.Raycast(ray, out float distance))
        {
            Vector3 mouseWorld = ray.GetPoint(distance);

            // ONLY X movement (2D feel)
            Vector3 target = new Vector3(
                mouseWorld.x,
                rb2.position.y,
                rb2.position.z
            );

            Vector3 error = target - rb2.position;
            Vector3 force = error * stiffness - rb2.linearVelocity * damping;

            rb2.AddForce(force, ForceMode.Force);
        }
    }
}
