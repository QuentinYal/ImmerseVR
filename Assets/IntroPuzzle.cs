using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class IntroPuzzle : MonoBehaviour
{ 
    [SerializeField]
    TMP_Text InputCode;
    [SerializeField]
    string codeTyped;
    [SerializeField]
    Image colorChange;
    [SerializeField]
    string correctCode = "1234";
    [SerializeField]
    bool puzzleSolved = false;


    private void Start()
    {
        Button[] buttons = GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => ButtonPressed(button));
        }
    }

    private void ButtonPressed(Button button)
    {
        if (puzzleSolved)
            return;
        
        codeTyped += button.name;
        if (codeTyped.Length > 4)
        {
        codeTyped = null;
        }
        InputCode.text = codeTyped;

        if (codeTyped == correctCode)
        {
            puzzleSolved = true;
            colorChange.color = new Color32(185, 255, 200, 255); //green
            Debug.Log("Puzzle Solved!");
            slideDeur1.instance.puzzleDoorOpen();
        }
    }
}


