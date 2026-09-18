using UnityEngine;

public class CameraDetectorTwo : MonoBehaviour
{
    public Camera camera;
    Plane[] cameraFrustum;
    Collider Collider;
    public bool photoInRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        var bounds = Collider.bounds;
        cameraFrustum = GeometryUtility.CalculateFrustumPlanes(camera);
        if (GeometryUtility.TestPlanesAABB(cameraFrustum, bounds))
        {
            photoInRange = true;
        }
        else
        {
            photoInRange = false;
        }
    }
}
