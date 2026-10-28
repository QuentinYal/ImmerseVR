using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monsterAIv2 : MonoBehaviour
{
    public NavMeshAgent agent;
    public float lingerRadius;
    public GameObject player;
    public LayerMask blockingLayer;
    public float normalSpeed;
    public float huntingSpeed;
    public float lingerSpeed;
    public bool lingering;
    public float chaseTime;
    public bool chasing;
    public float minLingerTime;
    public float maxLingerTime;
    public bool canSee;

    public GameObject[] camPositions;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent.speed = normalSpeed;
        StartCoroutine(wander());
    }

    // Update is called once per frame
    void Update()
    {
        canSee = !Physics.Linecast(transform.position, player.transform.position, blockingLayer);

        if(canSee && !chasing)
        {
            StopAllCoroutines();
            lingering = false;
            agent.speed = normalSpeed;
            StartCoroutine(chase());
        }

        if(chasing) agent.SetDestination(player.transform.position);


        if (lingering)
        {
            if(agent.remainingDistance < 1f && !agent.pathPending) agent.SetDestination(GetRandomPos());
        }
    }


    public IEnumerator wander()
    {
        agent.SetDestination(GetRandomCamPos());

        yield return new WaitUntil(() => !agent.pathPending);
        yield return new WaitUntil(() => agent.remainingDistance < 0.1f);

        StartCoroutine(Linger());
    }
    public IEnumerator Linger()
    {
        lingering = true;
        agent.speed = lingerSpeed;
        yield return new WaitForSeconds(Random.Range(minLingerTime, maxLingerTime));
        agent.speed = normalSpeed;
        lingering = false;
        StartCoroutine(wander());
    }

    public IEnumerator chase()
    {
        chasing = true;
        yield return new WaitForSeconds(chaseTime);
        chasing = false;
        yield return new WaitUntil(() => !agent.pathPending);
        yield return new WaitUntil(() => agent.remainingDistance < 0.1f);
        StartCoroutine(Linger());
    }

    public Vector3 GetRandomCamPos()
    {
        int index = Random.Range(0, camPositions.Length);

        return camPositions[index].transform.position;
    }

    public Vector3 GetRandomPos()
    {
        Vector3 randomDirection = Random.insideUnitSphere * lingerRadius;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, lingerRadius, 1);
        return hit.position;
    }

    
}
