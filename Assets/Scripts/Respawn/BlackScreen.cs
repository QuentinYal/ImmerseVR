using UnityEngine;
using UnityEngine.UI;

public class BlackScreen : MonoBehaviour
{
    public bool blackScreenActive = false;
    public float fadeSpeed = 1f;
    public Image blackScreen;

    void Update()
    {
        Color color = blackScreen.color;
        if (blackScreenActive)
        {
            color.a += fadeSpeed * Time.deltaTime;
        }
        else
        {
            color.a -= fadeSpeed * Time.deltaTime;
        }

        color.a = Mathf.Clamp01(color.a);
        blackScreen.color = color;
    }
}
