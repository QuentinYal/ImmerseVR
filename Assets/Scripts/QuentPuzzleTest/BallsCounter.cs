using System.Runtime.CompilerServices;
using UnityEngine;

public class BallsCounter : MonoBehaviour
{
    [SerializeField]
    private GameObject indicator; 
    private Color correctColor = new Color(0, 255, 0, 1);
    [SerializeField]
    private GameObject ballsSpawn;

    [SerializeField]
    private bool redBall;
    [SerializeField]
    private bool greenBall;
    [SerializeField]
    private bool blueBall;

    private void OnTriggerEnter(Collider other)
    {
        if(redBall == true && other.CompareTag("RedBall"))
        {
            indicator.GetComponent<Renderer>().material.color = correctColor;
            Destroy(other.gameObject);
        }
        else
        {
            other.gameObject.transform.position = ballsSpawn.transform.position;
        }

        if (greenBall == true && other.CompareTag("GreenBall"))
        {
            indicator.GetComponent<Renderer>().material.color = correctColor;
            Destroy(other.gameObject);
        }
        else
        {
            other.gameObject.transform.position = ballsSpawn.transform.position;
        }

        if (blueBall == true && other.CompareTag("BlueBall"))
        {
            indicator.GetComponent<Renderer>().material.color = correctColor;
            Destroy(other.gameObject);
        }
        else
        {
            other.gameObject.transform.position = ballsSpawn.transform.position;
        }
    }
}
