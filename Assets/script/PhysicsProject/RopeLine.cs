using UnityEngine;

public class RopeLine : MonoBehaviour
{
    public Transform startPoint; // roof / anchor
    public Transform endPoint;   // spike

    LineRenderer lr;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void LateUpdate()
    {
        if (!startPoint || !endPoint) return;

        lr.SetPosition(0, startPoint.position);
        lr.SetPosition(1, endPoint.position);
    }
}
