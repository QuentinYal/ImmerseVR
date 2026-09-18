using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
   public void SceneChange()
    {
        SceneManager.LoadScene("BasicScene");
    }
}
