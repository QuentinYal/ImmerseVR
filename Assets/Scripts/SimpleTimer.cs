using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTimer : MonoBehaviour
{
    public UnityEvent onTimeUp;
    public bool doTimer;
    public TextMeshProUGUI textBox;
    public float minuteCountStart;
    [HideInInspector] public float minuteCountCurrent;
    [HideInInspector] public float secondCountCurrent;
    [HideInInspector] public string secondCountDisplay;
    [HideInInspector] public bool endTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minuteCountCurrent = minuteCountStart;
        secondCountCurrent = 0;
        secondCountDisplay = "00";
        endTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (doTimer && !(minuteCountCurrent == 0 && secondCountCurrent == 0))
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

        if (minuteCountCurrent <= 0)
        {
            textBox.color = Color.red;
        }
        
        if (endTimer) 
        {
            DelayLoss();
            doTimer = false;
            endTimer = false;
        }
    }

    IEnumerator DelayLoss()
    {
        yield return new WaitForSeconds(20f);
        onTimeUp.Invoke();
    }

    public void SwapBoolean(bool a)
    {
        a = !a;
    }
}
