using UnityEngine;

public class LookAt : MonoBehaviour
{

    public bool forceCamera = false;
    public float rotationSpeed = 5f;

    public Transform cameraVR;
    public Transform targetMonster;


    void Update()
    {
        if (forceCamera)
        {
            Vector3 direction = targetMonster.position - cameraVR.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            cameraVR.transform.rotation = Quaternion.Slerp(
            cameraVR.transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime);
        }
    }
}
