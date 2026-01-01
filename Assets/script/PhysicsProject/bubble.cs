using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed = 0.7f;
    public float destroyY = 6f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Move using physics so triggers fire reliably
        rb.MovePosition(rb.position + Vector3.up * speed * Time.fixedDeltaTime);

        if (rb.position.y > destroyY)
        {
            Destroy(gameObject);
        }
    }

void OnTriggerEnter(Collider other)
{
    if (!other.CompareTag("Spike")) return;

    // GameManager.Instance.BubbleHit();
    Destroy(gameObject);
}


}
