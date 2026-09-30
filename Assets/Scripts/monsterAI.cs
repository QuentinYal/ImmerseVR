using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class monsterAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public float randomRadius;
    public float lingerRadius;
    public float distanceForLinger;
    private float radius;
    public GameObject player;
    public LayerMask blockingLayer;
    private float speed;
    public float huntingSpeed;
    public float lingerSpeed;
    private bool gonnaLinger;
    public bool lingering;
    public float minLingerTime;
    public float maxLingerTime;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = agent.speed;
        radius = randomRadius;
        agent.SetDestination(GetRandomPos());
    }

    // Update is called once per frame
    void Update()
    {
        bool canSee = !Physics.Linecast(transform.position, player.transform.position, blockingLayer);

        if (radius == randomRadius)
            lingering = false;
        else if (radius == lingerRadius)
            lingering = true;

        if (canSee)
        {
            agent.SetDestination(player.transform.position);
            gonnaLinger = true;
            agent.speed = huntingSpeed;
        }
        else if(lingering)
        {
            agent.speed = lingerSpeed;
        }
        else
        {
            agent.speed = speed;
        }

        if (agent.remainingDistance < 1 && !canSee)
        {
            if (gonnaLinger)
                StartCoroutine(Linger());
            agent.SetDestination(GetRandomPos());
            Debug.Log(Vector3.Distance(transform.position, agent.destination));
            if (Vector3.Distance(transform.position, agent.destination) > distanceForLinger)
            {
                gonnaLinger = true;
            }
        }
    }
    public Vector3 GetRandomPos()
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, radius, 1);
        return hit.position;
    }

    public IEnumerator Linger()
    {
        gonnaLinger = false;
        radius = lingerRadius;
        yield return new WaitForSeconds(Random.Range(minLingerTime, maxLingerTime));
        radius = randomRadius;
    }
}
