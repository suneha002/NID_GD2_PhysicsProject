using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject bubblePrefab;
    public GameObject canPrefab;

    [Header("Spawn Timing")]
    public float minSpawnTime = 1.8f;
    public float maxSpawnTime = 2.5f;

    [Header("Spawn Area")]
    public float minX = -4f;
    public float maxX = 4f;
    public float spawnY = -5f;
    public float spawnZ = 6.6f;

    [Header("Spacing")]
    public float minDistanceX = 2.6f;

    [Header("Can Chance")]
    [Range(0f, 1f)]
    public float canChance = 0.2f; // 20% chance

    float timer;
    float nextSpawnTime;
    float lastX = 999f;

    void Start()
    {
        nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextSpawnTime)
        {
            SpawnObject();
            timer = 0f;
            nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void SpawnObject()
    {
        float x = GetSpacedX();
        Vector3 pos = new Vector3(x, spawnY, spawnZ);

        GameObject prefabToSpawn =
            Random.value < canChance ? canPrefab : bubblePrefab;

        Instantiate(prefabToSpawn, pos, Quaternion.identity);
    }

    float GetSpacedX()
    {
        float x;
        int tries = 0;

        do
        {
            x = Random.Range(minX, maxX);
            tries++;
        }
        while (Mathf.Abs(x - lastX) < minDistanceX && tries < 10);

        lastX = x;
        return x;
    }
}
