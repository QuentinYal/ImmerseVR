using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SceneChangeMemory : MonoBehaviour
{
    public bool pictureOne;
    public bool pictureTwo;
    public bool pictureThree;

    public Camera vrCamera;

    public AudioSource endGameAudio;

    public GameObject restartPanel;

    public GameObject wind;

    public void PictureOneActive(SelectEnterEventArgs args)
    {
        GameObject insirtedObject = args.interactableObject.transform.gameObject;
        if (insirtedObject.CompareTag("MemoryFotoOne")) {pictureOne = true;}
    }

    public void PictureOneDeactivate(SelectExitEventArgs args)
    {
        GameObject insirtedObject = args.interactableObject.transform.gameObject;
        if (insirtedObject.CompareTag("MemoryFotoOne")) { pictureOne = false; }
    }

    public void PictureTwoActive(SelectEnterEventArgs args)
    {
        GameObject insirtedObject = args.interactableObject.transform.gameObject;
        if (insirtedObject.CompareTag("MemoryFotoTwo")) { pictureTwo = true; }
    }

    public void PictureTwoDeactivate(SelectExitEventArgs args)
    {
        GameObject insirtedObject = args.interactableObject.transform.gameObject;
        if (insirtedObject.CompareTag("MemoryFotoTwo")) { pictureTwo = false; }
    }

    public void PictureThreeActive(SelectEnterEventArgs args)
    {
        GameObject insirtedObject = args.interactableObject.transform.gameObject;
        if (insirtedObject.CompareTag("MemoryFotoThree")) { pictureThree = true; }
    }

    public void PictureThreeDeactivate(SelectExitEventArgs args)
    {
        GameObject insirtedObject = args.interactableObject.transform.gameObject;
        if (insirtedObject.CompareTag("MemoryFotoThree")) { pictureThree = false; }
    }

    private void Update()
    {
        if(pictureOne == true & pictureTwo == true & pictureThree == true)
        {
            if (!endGameAudio.isPlaying)
            {
                endGameAudio.Play();
            }
            vrCamera.cullingMask |= (1 << LayerMask.NameToLayer("MemoryPlayer"));

            restartPanel.SetActive(true);

            wind.SetActive(true);
        }
    }
}
