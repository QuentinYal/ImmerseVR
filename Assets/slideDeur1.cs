using System.Collections;
using UnityEngine;

public class slideDeur1 : MonoBehaviour
{
    public static slideDeur1 instance;

    public GameObject door1;
    public GameObject door2;
    
    public float closedpos1;
    public float closedpos2;
    public float openpos1;
    public float openpos2;

    public float lerpDuration;

    private bool inAnim;
    public AudioSource source;
    public AudioClip openClip;
    public AudioClip closeClip;

    public void Start()
    {
        instance = this;
    }


    public void puzzleDoorOpen()
    {
        StopAllCoroutines();
        StartCoroutine(open());
    }
    public void puzzleDoorClose()
    {
        StopAllCoroutines();
        StartCoroutine(close());
    }


    public IEnumerator open()
    {
        source.Stop();
        source.PlayOneShot(openClip);
        float timeElapsed = 0f;

        while(timeElapsed < lerpDuration)
        {
            door1.transform.localPosition = new Vector3(Mathf.SmoothStep(door1.transform.localPosition.x, openpos1, timeElapsed / lerpDuration), door1.transform.localPosition.y, door1.transform.localPosition.z);
            door2.transform.localPosition = new Vector3(Mathf.SmoothStep(door2.transform.localPosition.x, openpos2, timeElapsed / lerpDuration), door2.transform.localPosition.y, door2.transform.localPosition.z);
            timeElapsed += Time.deltaTime;

            yield return null;
        }

        door1.transform.localPosition = new Vector3(openpos1, door1.transform.localPosition.y, door1.transform.localPosition.z);
        door2.transform.localPosition = new Vector3(openpos2, door2.transform.localPosition.y, door2.transform.localPosition.z);
    }

    public IEnumerator close()
    {
        Debug.Log("closed");
        source.Stop();
        source.PlayOneShot(closeClip);
        float timeElapsed = 0f;

        while (timeElapsed < lerpDuration)
        {
            door1.transform.localPosition = new Vector3(Mathf.SmoothStep(door1.transform.localPosition.x, closedpos1, timeElapsed / lerpDuration), door1.transform.localPosition.y, door1.transform.localPosition.z);
            door2.transform.localPosition = new Vector3(Mathf.SmoothStep(door2.transform.localPosition.x, closedpos2, timeElapsed / lerpDuration), door2.transform.localPosition.y, door2.transform.localPosition.z);
            timeElapsed += Time.deltaTime;

            yield return null;
        }

        door1.transform.localPosition = new Vector3(closedpos1, door1.transform.localPosition.y, door1.transform.localPosition.z);
        door2.transform.localPosition = new Vector3(closedpos2, door2.transform.localPosition.y, door2.transform.localPosition.z);
    }
}
