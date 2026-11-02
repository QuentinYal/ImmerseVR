using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene("_HomeScreen");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("monster"))
        {
            SceneManager.LoadScene("_HomeScreen");
        }
    }
}
