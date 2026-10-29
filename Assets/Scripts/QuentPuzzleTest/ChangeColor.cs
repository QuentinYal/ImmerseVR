using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Color correctColor = new Color(0, 255, 0, 1);

    [SerializeField]
    private GameObject indicator;

    public void ColorChange()
    {
        indicator.GetComponent<Renderer>().material.color = correctColor;
    }
}
