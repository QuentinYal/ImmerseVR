using System.Collections;
using UnityEngine;

public class slideDeur : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    
    public float closedpos1;
    public float closedpos2;
    public float openpos1;
    public float openpos2;

    public float lerpDuration;

    private bool inAnim;


    private void OnTriggerEnter(Collider other)
    {
        StopAllCoroutines();
        StartCoroutine(open());
    }

    private void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();
        StartCoroutine(close());
    }


    public IEnumerator open()
    {
        float timeElapsed = 0f;

        while(timeElapsed < lerpDuration)
        {
            door1.transform.localPosition = new Vector3(door1.transform.localPosition.x, door1.transform.localPosition.y, Mathf.SmoothStep(door1.transform.localPosition.z, openpos1, timeElapsed / lerpDuration));
            door2.transform.localPosition = new Vector3(door2.transform.localPosition.x, door2.transform.localPosition.y, Mathf.SmoothStep(door2.transform.localPosition.z, openpos2, timeElapsed / lerpDuration));
            timeElapsed += Time.deltaTime;

            yield return null;
        }

        door1.transform.localPosition = new Vector3(door1.transform.localPosition.x, door1.transform.localPosition.y, openpos1);
        door2.transform.localPosition = new Vector3(door2.transform.localPosition.x, door2.transform.localPosition.y, openpos2);
    }

    public IEnumerator close()
    {
        
        float timeElapsed = 0f;

        while (timeElapsed < lerpDuration)
        {
            door1.transform.localPosition = new Vector3(door1.transform.localPosition.x, door1.transform.localPosition.y, Mathf.SmoothStep(door1.transform.localPosition.z, closedpos1, timeElapsed / lerpDuration));
            door2.transform.localPosition = new Vector3(door2.transform.localPosition.x, door2.transform.localPosition.y, Mathf.SmoothStep(door2.transform.localPosition.z, closedpos2, timeElapsed / lerpDuration));
            timeElapsed += Time.deltaTime;

            yield return null;
        }

        door1.transform.localPosition = new Vector3(door1.transform.localPosition.x, door1.transform.localPosition.y, closedpos1);
        door2.transform.localPosition = new Vector3(door2.transform.localPosition.x, door2.transform.localPosition.y, closedpos2);
    }
}
