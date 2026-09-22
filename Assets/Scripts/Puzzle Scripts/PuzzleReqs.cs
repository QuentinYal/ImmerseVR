using UnityEngine;

public class PuzzleReqs : MonoBehaviour
{
    public bool mustBeOn;
    [HideInInspector] public bool currentState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = false;
    }

 public void ChangeValue()
    {
        currentState = !currentState;
    }
}
