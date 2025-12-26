using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float spawnRate = 0.4f;
    public float minX = -4f;
    public float maxX = 4f;
    public float spawnY = -5f;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnBubble();
            timer = 0f;
        }
    }

    void SpawnBubble()
    {
        float x = Random.Range(minX, maxX);
        Vector3 pos = new Vector3(x, spawnY, 6.6f);
        Instantiate(bubblePrefab, pos, Quaternion.identity);
    }
}
