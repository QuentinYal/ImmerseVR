using UnityEngine;

public class CloseUI : MonoBehaviour
{   
    // This does not work currently
    public GameObject gameObjectPrefab;
    public void ClosePuzzleScreen(GameObject GO)
    {
        Destroy(GO);
        Debug.Log("I Should be dead");
        GameObject GOmake = Instantiate(gameObjectPrefab);
        Debug.Log("Did Above");
        
    }
}
