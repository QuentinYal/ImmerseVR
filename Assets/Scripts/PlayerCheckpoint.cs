using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class checkPointsList
{
    public List<Vector2> checkPoints = new List<Vector2>();
}

public class Playercheckpoint : MonoBehaviour
{
    public Transform playerLocation;
    public Transform playerToMove;
    public bool forceReset = false;

    [Header("1. Xbounds 2. Zbounds 3. Respawn Location")]
    public List<checkPointsList> checkPointsList = new List<checkPointsList>();

    void Update()
    {
        if (forceReset)
        {
            resetPlayerLocation();
            forceReset = false;
        }
    }

    public void resetPlayerLocation()
    {
        for (int i = 0; i < checkPointsList.Count; i++)
        {
            Vector2 point1 = checkPointsList[i].checkPoints[0];
            Vector2 point2 = checkPointsList[i].checkPoints[1];

            if (playerLocation.position.x > point1.x &&
                playerLocation.position.x < point1.y &&
                playerLocation.position.z > point2.x &&
                playerLocation.position.z < point2.y)
            {
                playerToMove.transform.position = new Vector3(
                    checkPointsList[i].checkPoints[2].x,
                    playerToMove.transform.position.y,
                    checkPointsList[i].checkPoints[2].y);
                break;
            }
        }
    }

}

