using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class HandGone : MonoBehaviour
{
    public GameObject handModel;
    public GameObject pokeModel;
    public Rigidbody handRigidbody;
    public XRBaseInteractor interactor;

    private void OnEnable()
    {
        interactor.selectEntered.AddListener(HideHand);
        interactor.selectExited.AddListener(ShowHand);
    }

    private void OnDisable()
    {
        interactor.selectEntered.RemoveListener(HideHand);
        interactor.selectExited.RemoveListener(ShowHand);
    }

    IEnumerator StartShowHand(SelectExitEventArgs args)
    {
        pokeModel.SetActive(false);
        handModel.SetActive(true);
        handRigidbody.detectCollisions = false;
        yield return new WaitForSeconds(.5f);
        handRigidbody.detectCollisions = true;
    }

    private void HideHand(SelectEnterEventArgs args)
    {
        handModel.SetActive(false);
        pokeModel.SetActive(true);
    }

    private void ShowHand(SelectExitEventArgs args)
    {
        StartCoroutine(StartShowHand(args));
    }
}