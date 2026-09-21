using UnityEngine;

public class AutoTileURP : MonoBehaviour
{
    public Renderer rend;
    public float multiplier = 1f;

    void Start()
    {
        if (rend == null)
            rend = GetComponent<Renderer>();

        Vector3 s = transform.localScale;
        Vector2 tiling = new Vector2(s.x * multiplier, s.z * multiplier);

        Material mat = rend.material;

        mat.SetTextureScale("_BaseMap", tiling);
        mat.SetTextureScale("_BumpMap", tiling);
        mat.SetTextureScale("_SpecGlossMap", tiling);
    }
}