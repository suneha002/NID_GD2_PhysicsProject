using UnityEngine;

public class Spawn1 : MonoBehaviour
{

    [Header("Prefabs")]
public GameObject normalPrefab;   
public GameObject penaltyPrefab;

    [Header("Spawn timing")]
    public float spawnInterval = 3f;
    public int maxActiveObjects = 5;
    [Header("Global spawn control")]
public float spawnRateMultiplier = 1.6f; 

    BoxCollider[] colliders;
    int activeCount = 0;

    void Awake()
    {
        
        colliders = GetComponents<BoxCollider>();

        if (colliders.Length == 0)
            Debug.LogError("No BoxColliders found");
    }

   void Start()
{
    InvokeRepeating(
        nameof(SpawnRandom),
        0f,
        spawnInterval * spawnRateMultiplier
    );
}


 void SpawnRandom()
{
    if (activeCount >= maxActiveObjects) return;
    if (colliders.Length == 0) return;

    Vector3 spawnPos = GetRandomPointInL();

    GameObject prefabToSpawn;

    if (Random.value < 0.6f) 
        prefabToSpawn = normalPrefab;
    else
        prefabToSpawn = penaltyPrefab;

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

    
    Vector3 center = col.transform.TransformPoint(col.center);

    
    Vector3 size = Vector3.Scale(col.size, col.transform.lossyScale);
    Vector3 half = size * 0.5f;

    float x = Random.Range(center.x - half.x, center.x + half.x);
    float y = center.y; 
    float z = Random.Range(center.z - half.z, center.z + half.z);

    return new Vector3(x, y, z);
}


    public void OnSpawnedDestroyed()
    {
        activeCount--;
    }
}
