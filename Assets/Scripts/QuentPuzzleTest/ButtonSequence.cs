using UnityEngine;
using UnityEngine.Events;

public class ButtonSequence : MonoBehaviour
{
    [SerializeField]
    int[] buttonOrder = { 0, 1, 2 };
    public UnityEvent correctCombination;
    int currentStep = 0;

    public void Press(int id)
    {
        if(id == buttonOrder[currentStep])
        {
            ++currentStep;

            if (currentStep >= buttonOrder.Length)
            {
                correctCombination.Invoke();
                currentStep = 0;
            }
        }
        else
        {
            currentStep = (id == buttonOrder[0]) ? 1 : 0;
        }
    }
}
