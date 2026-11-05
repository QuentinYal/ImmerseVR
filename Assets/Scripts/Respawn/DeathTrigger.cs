using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public bool deathTriggered = false;

    private void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.name);

        if (other.CompareTag("monster"))
        {
            deathTriggered = true;
        }
    }
}
