using UnityEngine;

public class camManager : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;
    public GameObject cam9;

    private int index;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        index = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (index == 1) index = 9;
            else index--;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (index == 9) index = 1;
            else index++;
        }
        
        if (index == 1 && cam1 != null)
        {
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam1.SetActive(true);
            cam9.SetActive(false);

        }
        if (index == 2 && cam2 != null)
        {
            cam1.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam2.SetActive(true);
            cam9.SetActive(false);

        }
        if (index == 3 && cam3 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam3.SetActive(true);
            cam9.SetActive(false);

        }
        if (index == 4 && cam4 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam4.SetActive(true);
            cam9.SetActive(false);

        }
        if (index == 5 && cam5 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam5.SetActive(true);
            cam9.SetActive(false);

        }
        if (index == 6 && cam6 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam7.SetActive(false);
            cam6.SetActive(true);
            cam9.SetActive(false);

        }
        if (index == 7 && cam7 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(true);
            cam9.SetActive(false);

        }
        if (index == 8 && cam8 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(true);
            cam9.SetActive(false);
        }
        if (index == 9 && cam9 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(true);
        }
    }
}
