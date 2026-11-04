using UnityEngine;

public class LookAt : MonoBehaviour
{

    public bool forceCamera = false;
    public float rotationSpeed = 5f;
    public float pivotHeight = 1.5f;

    public Transform targetMonster;

    public Camera cameraNormal;
    public Camera cameraDeath;
    public Transform cameraNormalTransform;
    public Transform cameraDeathTransform;


    void Update()
    {
        Vector3 adjustedTargetMonster = new Vector3(targetMonster.position.x, cameraDeathTransform.position.y + pivotHeight, targetMonster.position.z);


        if (forceCamera)
        {
            cameraNormal.enabled = false;
            cameraDeath.enabled = true;

            var direction = adjustedTargetMonster - cameraDeathTransform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            cameraDeathTransform.transform.rotation = Quaternion.Slerp(
            cameraDeathTransform.transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime);
        }
        else
        {
            cameraDeathTransform.position = cameraNormalTransform.position;
            cameraDeathTransform.rotation = cameraNormalTransform.rotation;

            cameraNormal.enabled = true;
            cameraDeath.enabled = false;
        }
    }
}
