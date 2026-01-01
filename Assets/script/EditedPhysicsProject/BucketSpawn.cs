using UnityEngine;

public class BucketSpawn : MonoBehaviour
{
    public float speed = 2f;
    public float maxHeight = 5.5f;

    float startY;
    public GameObject hitSparkPrefab;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if (transform.position.y >= startY + maxHeight)
        {
            Destroy(gameObject);
        }
    }

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Punch"))
    {
        AudioManager.Instance.PlayPenaltyHit();
        GameManager.Instance.AddScore(+10);
        if (hitSparkPrefab != null)
        {
            Renderer r = GetComponentInChildren<Renderer>();
Vector3 spawnPos = r.bounds.center;

Instantiate(hitSparkPrefab, spawnPos, Quaternion.identity);
            Debug.Log("Spark spawned at " + hitSparkPrefab.transform.position);
        }
        else
        {
            Debug.LogError("HitSparkPrefab NOT assigned on " + gameObject.name);
        }

        Destroy(gameObject);
    }
}
}
