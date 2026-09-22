using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public void ClosePuzzleScreen(GameObject GO)
    {
        GO.SetActive(false);
    }
}
