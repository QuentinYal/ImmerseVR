using System.Collections.Generic;
using UnityEngine;

public class CorrectAumoutCheck : MonoBehaviour
{
    public int buttonsCorrect;
    public List<PuzzleReqs> puzzleReqsList = new List<PuzzleReqs>();

    void Awake()
    {
        foreach (Transform child in transform)
        {
            PuzzleReqs req = child.GetComponent<PuzzleReqs>();
            if (req != null)
                puzzleReqsList.Add(req);
        }
    }

    void Update()
    {
        buttonsCorrect = 0;
        foreach (PuzzleReqs req in puzzleReqsList)
        {
            if (req.currentState == req.mustBeOn)
                buttonsCorrect++;
        }
    }

}
