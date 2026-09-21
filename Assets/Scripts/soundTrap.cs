using UnityEngine;
using UnityEngine.AI;

public class soundTrap : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;
    public AudioClip noise;
    private AudioSource source;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("rn");
        agent.SetDestination(player.transform.position);
        source.resource = noise;
        source.Play();
    }
}
