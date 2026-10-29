using UnityEngine;

public class scaleFromMic : MonoBehaviour
{
    private bool inRoom;
    private bool canHear;
    public GameObject ceiling;
    public float downSpeed;
    public float upSpeed;

    public float topPos;
    public float bottomPos;

    void Update()
    {
        float step = downSpeed * Time.deltaTime;
        float step2 = upSpeed * Time.deltaTime;
        
        float loudness = MicDetector.Instance.GetLoudnessFormMic() * MicDetector.Instance.sensibilty;
        if (loudness > MicDetector.Instance.threshold) canHear = true;
        else canHear = false;

        if(canHear && inRoom)
        {
            ceiling.transform.localPosition = new Vector3(ceiling.transform.localPosition.x, Mathf.MoveTowards(ceiling.transform.localPosition.y, bottomPos, step), ceiling.transform.localPosition.z);
        }
        else
        {
            ceiling.transform.localPosition = new Vector3(ceiling.transform.localPosition.x, Mathf.MoveTowards(ceiling.transform.localPosition.y, topPos, step2), ceiling.transform.localPosition.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inRoom = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inRoom = false;
        }
    }
}
