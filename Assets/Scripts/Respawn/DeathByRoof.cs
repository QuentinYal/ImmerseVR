using UnityEngine;

public class DeathByRoofRespawn : MonoBehaviour
{
    Vector3 RespawnPoint = new Vector3(85, -2, -61);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("roof"))
        {
            transform.position = RespawnPoint;
        }
    }
}
