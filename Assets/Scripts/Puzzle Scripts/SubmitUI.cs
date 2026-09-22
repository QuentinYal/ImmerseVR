using UnityEngine;
using UnityEngine.UI;

public class SubmitUI : MonoBehaviour
{
    public Button submitButton;
    public Image colorChange;
    public CorrectAumoutCheck correctAmount;

    void Start()
    {
        if (submitButton != null)
            submitButton.onClick.AddListener(submitButtonClicked);
    }

    void submitButtonClicked()
    {
        if (correctAmount.buttonsCorrect == 64)
        {
            colorChange.color = new Color32(185, 255, 200, 255); //green
        }
        else
        {
            colorChange.color = new Color32(255, 185, 185, 255); //red     
        }
    }
}
