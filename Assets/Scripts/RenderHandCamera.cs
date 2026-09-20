using UnityEngine;

public class RenderHandCamera : MonoBehaviour
{
    public MeshRenderer screenRenderer = null;

    private Camera renderCamera = null;

    private void Awake()
    {
        renderCamera = GetComponentInChildren<Camera>();
    }

    private void Start()
    {
        CreateRenderTexture();
        TurnOff();
    }

    private void CreateRenderTexture()
    {
        RenderTexture newTexture = new RenderTexture(256, 256, 32, RenderTextureFormat.Default, RenderTextureReadWrite.sRGB);
        newTexture.antiAliasing = 4;

        renderCamera.targetTexture = newTexture;
        screenRenderer.material.mainTexture = newTexture;
    }

    //private Texture2D RenderCameraToTexture(Camera camera)
    //{
    //    camera.Render();
    //    RenderTexture.active = camera.targetTexture;

    //    Texture2D photo = new Texture2D(256, 256, TextureFormat.RGB24, false);
    //    photo.ReadPixels(new Rect(0, 0, 256, 256), 0, 0);
    //    photo.Apply();

    //    return photo;
    //}

    public void TurnOn()
    {
        renderCamera.enabled = true;
        screenRenderer.material.color = Color.white;
    }

    public void TurnOff()
    {
        renderCamera.enabled = false;
        screenRenderer.material.color = Color.black;
    }
}
