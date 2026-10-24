using UnityEngine;

public class scaleFromMic : MonoBehaviour
{
    void Update()
    {
        float loudness = MicDetector.Instance.GetLoudnessFormMic() * MicDetector.Instance.sensibilty;
        if (loudness > MicDetector.Instance.threshold) gameObject.transform.position += new Vector3(0.1f, 0, 0);
    }
}
