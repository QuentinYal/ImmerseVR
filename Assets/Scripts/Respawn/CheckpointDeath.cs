using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class CheckPointsList
{
    public List<Vector2> checkPoints = new List<Vector2>();
}

public class CheckpointDeath : MonoBehaviour
{
    public bool forceDeathSecuence = false;

    public Transform playerLocation;
    public Transform playerToMove;

    public BlackScreen blackScreenScript;
    public LookAt lookAtScript;
    public DeathTrigger deathTriggerScript;

    [Header("1. Xbounds 2. Zbounds 3. Respawn Location")]
    public List<CheckPointsList> checkPointsList = new List<CheckPointsList>();


    public float deathTimer;
    public float timeUntilFadeIn = 2;
    public float timeUntilRespawn = 4;
    public float timeUntilFadeOut = 5;


    void Update()
    {

        if (deathTriggerScript.deathTriggered)
        {
            forceDeathSecuence = true;
        }

        if (forceDeathSecuence)
        {
            deathTimer += Time.deltaTime;
            lookAtScript.forceCamera = true;
            if (deathTimer > timeUntilFadeIn && deathTimer < timeUntilFadeOut)
            {
                blackScreenScript.blackScreenActive = true;
            }
            if (deathTimer > timeUntilRespawn)
            {
                resetPlayerLocation();
            }
            if (deathTimer > timeUntilFadeOut)
            {

                forceDeathSecuence = false;
            }
        }
        else
        {
            blackScreenScript.blackScreenActive = false;
            deathTriggerScript.deathTriggered = false;
            lookAtScript.forceCamera = false;
            deathTimer = 0;
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