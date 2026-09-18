using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{
    private bool leftHandActive = true;
    private bool rightHandActive = true;

    public GameObject leftHand;
    public GameObject rightHand;

    private void Awake()
    {
        if(leftHandActive == false)
        {
            leftHand.SetActive(false);
        }

        if (rightHandActive == false) 
        {
            rightHand.SetActive(false);
        }

        if (leftHandActive == true)
        {
            leftHand.SetActive(true);
        }

        if (rightHandActive == true)
        {
            rightHand.SetActive(true);
        }
    }

    public void TurnOffLeftHand()
    {
        leftHandActive = false;
    }

    public void TurnOffRightHand() 
    {
        rightHandActive = false;
    }

    public void TurnOnLeftHand() 
    {
        leftHandActive = true;
    }

    public void TurnOnRightHand() 
    {
        rightHandActive = true;
    }
}
