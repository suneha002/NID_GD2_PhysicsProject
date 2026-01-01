using UnityEngine;

public class RopeLiner : MonoBehaviour
{
    public Transform ball;
    LineRenderer lr;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void LateUpdate()
    {
        lr.SetPosition(0, transform.position); // tile
        lr.SetPosition(1, ball.position);      // ball
    }
}
