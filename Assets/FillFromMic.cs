using UnityEngine;
using UnityEngine.UI;

public class FillFromMic : MonoBehaviour
{
    public Image bar;

    public void Update()
    {
        float loudness = MicDetector.Instance.GetLoudnessFormMic() * MicDetector.Instance.sensibilty;
        Debug.Log(loudness);
        if (loudness < MicDetector.Instance.threshold) loudness = 0;

        bar.fillAmount = loudness;
    }
}
