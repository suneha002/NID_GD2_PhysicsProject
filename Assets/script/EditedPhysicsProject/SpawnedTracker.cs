using UnityEngine;

public class SpawnedTracker : MonoBehaviour
{
    Spawn1 spawner;

    public void Init(Spawn1 s)
    {
        spawner = s;
    }

    void OnDestroy()
    {
        if (spawner != null)
            spawner.OnSpawnedDestroyed();
    }
}
