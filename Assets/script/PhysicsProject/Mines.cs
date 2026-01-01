using UnityEngine;

public class Mines : MonoBehaviour
{
    public float speed = 0.4f;
    public float destroyY = 6f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("Mine prefab is missing Rigidbody", this);
            enabled = false;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector3.up * speed * Time.fixedDeltaTime);

        if (rb.position.y > destroyY)
        {
            Destroy(gameObject);
        }
    }

void OnTriggerEnter(Collider other)
{
    if (!other.CompareTag("Spike")) return;

    // GameManager.Instance.CanHit();
    Destroy(gameObject);
}

}
