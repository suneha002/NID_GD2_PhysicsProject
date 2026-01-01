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
        SetWallState(0);
    }

    public void SetWallState(int state)
    {
        if (rend == null) return;
        if (wallTextures == null || wallTextures.Length == 0) return;

        
        
        state = Mathf.Clamp(state, 0, wallTextures.Length - 1);

        Material[] mats = rend.materials;
        mats[wallMaterialIndex].SetTexture("_BaseMap", wallTextures[state]); 
        rend.materials = mats;
    }
}
