using System.Collections;
using UnityEngine;

public class playerCamLoc : MonoBehaviour
{
    private bool triggered = false;
    public GameObject monster;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !triggered)
        {
            StartCoroutine(go());
        }
    }

    IEnumerator go()
    {
        monster.SetActive(true);
        yield return new WaitForSeconds(1);
        monsterAIv3.instance.toPlayerPos(transform.position);
        triggered = true;
    }
}
