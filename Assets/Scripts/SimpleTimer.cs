using TMPro;
using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    public bool doTimer;
    public TextMeshProUGUI textBox;
    public float minuteCountStart;
    [HideInInspector] public float minuteCountCurrent;
    [HideInInspector] public float secondCountCurrent;
    [HideInInspector] public string secondCountDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minuteCountCurrent = minuteCountStart;
        secondCountCurrent = 0;
        secondCountDisplay = "00";
    }

    // Update is called once per frame
    void Update()
    {
        if (doTimer)
        {
            if (secondCountCurrent <= 0)
            {
                minuteCountCurrent -= 1;
                secondCountCurrent = 60;
            }
            else
            {
                secondCountCurrent -= Time.deltaTime;
            }

            if (secondCountCurrent < 10)
            {
                secondCountDisplay = "0" + (int)secondCountCurrent;
            }
            else
            {
                secondCountDisplay = "" + (int)secondCountCurrent;
            }
        }
        textBox.text = minuteCountCurrent + ":" + secondCountDisplay;
    }
}
