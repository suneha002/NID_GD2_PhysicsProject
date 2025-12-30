using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    [Header("Prefab to spawn")]
    public GameObject prefabToSpawn;

    [Header("Spawn timing")]
    public float spawnInterval = 3f;
    public int maxActiveObjects = 5;

    BoxCollider[] colliders;
    int activeCount = 0;

    void Awake()
    {
        // Get all BoxColliders on this L-shaped spawner
        colliders = GetComponents<BoxCollider>();

        if (colliders.Length == 0)
            Debug.LogError("No BoxColliders found on SpawnZone_L");
    }

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandom), 0f, spawnInterval);
    }

    void SpawnRandom()
    {
        if (prefabToSpawn == null) return;
        if (activeCount >= maxActiveObjects) return;
        if (colliders.Length == 0) return;

        Vector3 spawnPos = GetRandomPointInL();

        GameObject obj = Instantiate(
            prefabToSpawn,
            spawnPos,
            Quaternion.identity
        );

        activeCount++;

        obj.AddComponent<SpawnedTracker>().Init(this);
    }

    Vector3 GetRandomPointInL()
{
    BoxCollider col = colliders[Random.Range(0, colliders.Length)];

    // Convert collider local center to world space
    Vector3 center = col.transform.TransformPoint(col.center);

    // Account for scale properly
    Vector3 size = Vector3.Scale(col.size, col.transform.lossyScale);
    Vector3 half = size * 0.5f;

    float x = Random.Range(center.x - half.x, center.x + half.x);
    float y = center.y; // keep Y fixed
    float z = Random.Range(center.z - half.z, center.z + half.z);

    return new Vector3(x, y, z);
}


    public void OnSpawnedDestroyed()
    {
        activeCount--;
    }
}
