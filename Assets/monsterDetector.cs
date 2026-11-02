using UnityEngine;
using System.Linq;

public class monsterDetector : MonoBehaviour
{
    public GameObject monster;
    public Camera cam;

    private bool canSee;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, monster.transform.position);
        canSee = !Physics.Linecast(transform.position, monster.transform.position, LayerMask.NameToLayer("wall"));

        if (canSee)
        {
            Debug.Log(gameObject.name + " detecting");
        } 
    }

   
}
