using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public int correctButtonAmount = 0;

    public MonoBehaviour[] Row1Buttons = new MonoBehaviour[8];
    public MonoBehaviour[] Row2Buttons = new MonoBehaviour[8];
    public MonoBehaviour[] Row3Buttons = new MonoBehaviour[8];
    public MonoBehaviour[] Row4Buttons = new MonoBehaviour[8];
    public MonoBehaviour[] Row5Buttons = new MonoBehaviour[8];
    public MonoBehaviour[] Row6Buttons = new MonoBehaviour[8];
    public MonoBehaviour[] Row7Buttons = new MonoBehaviour[8];
    public MonoBehaviour[] Row8Buttons = new MonoBehaviour[8];

    private MonoBehaviour[][] allRows;

    void Awake()
    {
        // Combine all 8 rows into one jagged array
        allRows = new MonoBehaviour[][]
        {
            Row1Buttons,
            Row2Buttons,
            Row3Buttons,
            Row4Buttons,
            Row5Buttons,
            Row6Buttons,
            Row7Buttons,
            Row8Buttons
        };
    }

    public void CheckButtons()
    {
        correctButtonAmount = 0;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (allRows[row][col] is ButtonScript script)
                {
                    if (script.bool1 == script.bool2)
                    {
                        correctButtonAmount++;
                    }
                }
            }
        }

        Debug.Log("Correct buttons: " + correctButtonAmount);
    }

    void Update()
    {
        // Optional: auto-check every frame
        // CheckButtons();
    }
}

// Fix for CS0246: The type or namespace name 'ButtonScript' could not be found (are you missing a using directive or an assembly reference?)
// You must define or add a reference to the 'ButtonScript' class. If you have this script, ensure it is in your project and properly named.
// If you do not have it, you need to create it. Here is a minimal placeholder definition you can adjust as needed:

public class ButtonScript : MonoBehaviour
{
    public bool bool1;
    public bool bool2;
}
