using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public bool deathTriggered = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("monster"))
        {
            deathTriggered = true;
        }
        else
        {
             deathTriggered = false;
        }
    }
}
