using UnityEngine;
using System.Linq;
using TMPro;

public class monsterDetector : MonoBehaviour
{
    public GameObject monster;
    private Camera cam;
    public LayerMask wall;
    public TextMeshProUGUI text;


    private bool canSee;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, monster.transform.position);
        canSee = !Physics.Linecast(transform.position, monster.transform.position, wall);

        if (canSee)
        {
            text.enabled = true;
        }
        else text.enabled = false;
    }

}