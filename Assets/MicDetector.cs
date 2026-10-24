using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MicDetector : MonoBehaviour
{
    public static MicDetector Instance;
    
    private int sampleWindow = 64;

    private AudioClip micClip;
    private string micName;

    public Slider sens;
    public Slider thresh;
    public TextMeshProUGUI sensText;
    public TextMeshProUGUI threshText;
    
    public float minSens, maxSens;
    public float minThreshold, maxThreshold;

    public float sensibilty;
    public float threshold;
    
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        micToAudioClip(0);

        sens.value = 0.5f;
        thresh.value = 0.5f;
        setSens(sens.value);
        setThreshold(thresh.value);
    }

    private void OnEnable()
    {
        micSelector.onMicChange += ChangeMicrophoneSource;
    }
    private void OnDisable()
    {
        micSelector.onMicChange -= ChangeMicrophoneSource;
    }

    private void ChangeMicrophoneSource(int deviceIndex)
    {
        micToAudioClip(deviceIndex);
    }

    private void micToAudioClip(int micIndex)
    {
        micName = Microphone.devices[micIndex];
        micClip = Microphone.Start(micName, true, 20, AudioSettings.outputSampleRate);
    }

    public float GetLoudnessFormMic()
    {
        return GetLoudnessFormAudioClip(Microphone.GetPosition(micName), micClip);
    }

    public float GetLoudnessFormAudioClip(int clipPosition, AudioClip clip)
    {
        int startPosition = clipPosition - sampleWindow;

        if(startPosition < 0) return 0;

        float[] waveData = new float[sampleWindow];
        clip.GetData(waveData, startPosition);

        float totalLoudness = 0;

        foreach(var sample in waveData)
        {
            totalLoudness += Mathf.Abs(sample);
        }

        return totalLoudness / sampleWindow;
    }

    public void setSens(float t)
    {
        sensText.text = sensibilty.ToString();
        sensibilty = Mathf.Lerp(minSens, maxSens, t);
    }
    public void setThreshold(float t)
    {
        threshText.text = threshold.ToString();
        threshold = Mathf.Lerp(minThreshold, maxThreshold, t);
    }
}
