using UnityEngine;

public class GrafitiWall : MonoBehaviour
{
    Renderer rend;

    public Texture2D[] wallTextures;

    [Tooltip("Which material index is the wall")]
    public int wallMaterialIndex = 1;

    void Awake()
    {
        rend = GetComponentInChildren<Renderer>();
    }

    void Start()
    {
        // Set initial wall texture
        SetWallState(0);
    }

    public void SetWallState(int state)
    {
        if (wallTextures == null || wallTextures.Length == 0) return;
        if (state < 0 || state >= wallTextures.Length) return;

        Material[] mats = rend.materials;
        mats[wallMaterialIndex].mainTexture = wallTextures[state];
        rend.materials = mats;
    }
}
