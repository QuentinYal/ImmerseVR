using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public bool deathTriggered = false;
    public float deathTimer = 0f;
    public AudioSource source;
    public AudioClip jumpscare;

    private void Update()
    {
        if (deathTriggered)
        {
            deathTimer += Time.deltaTime;
            if (deathTimer > 1f)
            {
                deathTriggered = false;
                deathTimer = 0f;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.name);

        if (other.CompareTag("monster"))
        {
            deathTriggered = true;
            source.PlayOneShot(jumpscare);

        }
    }
}

