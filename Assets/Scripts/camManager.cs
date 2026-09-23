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
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && cam1 != null)
        {
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && cam2 != null)
        {
            cam1.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && cam3 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && cam4 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam4.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && cam5 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam5.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && cam6 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam7.SetActive(false);
            cam6.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) && cam7 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) && cam8 != null)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(true);
        }
    }
}
