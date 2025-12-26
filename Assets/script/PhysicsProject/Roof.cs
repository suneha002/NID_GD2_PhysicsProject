using UnityEngine;

public class Roof : MonoBehaviour
{
    public float speed = 0.5f;
    public float minX = -4f;
    public float maxX = 4f;

    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
        }

        // limit movement on X
        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        transform.position = pos;
    }
}
