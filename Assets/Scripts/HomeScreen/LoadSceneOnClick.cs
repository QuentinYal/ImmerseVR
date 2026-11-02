using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    public string sceneName;
    public void OnPointerClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
