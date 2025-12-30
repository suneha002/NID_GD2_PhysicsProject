using UnityEngine;

public class Line : MonoBehaviour
{
    public Transform sphere;
    public LineRenderer line;

    void LateUpdate()
    {
        if (sphere == null || line == null) return;

        // Point 0 = cube
        line.SetPosition(0, transform.position);

        // Point 1 = sphere
        line.SetPosition(1, sphere.position);
    }
}
