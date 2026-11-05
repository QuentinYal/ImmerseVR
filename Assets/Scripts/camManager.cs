using TMPro;
using UnityEngine;

public class camManager : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public Camera cam8;
    public Camera cam9;
    public Camera cam10;
    public Camera cam11;

    public TextMeshProUGUI text;

    private int index;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        index = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (index == 1) index = 11;
            else index--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (index == 11) index = 1;
            else index++;
        }
        
        if (index == 1 && cam1 != null)
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;
            
            
            /*cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam7.depth = 0;
            cam8.depth = 0;
            cam10.depth = 0;
            cam9.depth = 0;
            cam1.depth = 1;*/
        }
        if (index == 2 && cam2 != null)
        {
            cam1.enabled = false;
            cam2.enabled = true;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam3.depth= 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam8.depth = 0;
            cam7.depth = 0;
            cam9.depth = 0;
            cam10.depth= 0;
            cam2.depth = 1;*/
        }
        if (index == 3 && cam3 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam4.depth= 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam7.depth = 0;
            cam8.depth = 0;
            cam9.depth= 0;
            cam10.depth = 0;
            cam3.depth = 1;*/

        }
        if (index == 4 && cam4 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = true;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam7.depth= 0;
            cam8.depth = 0;
            cam10.depth = 0;
            cam9.depth = 0;
            cam4.depth = 1;*/
        }
        if (index == 5 && cam5 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = true;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam6.depth = 0;
            cam7.depth = 0;
            cam8.depth= 0;
            cam10.depth = 0;
            cam9.depth = 0;
            cam5.depth = 1;*/
        }
        if (index == 6 && cam6 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = true;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam7.depth = 0;
            cam8.depth = 0;
            cam10.depth = 0;
            cam9.depth = 0;
            cam6.depth = 1;*/
        }
        if (index == 7 && cam7 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = true;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam8.depth = 0;
            cam10.depth = 0;
            cam9.depth = 0;
            cam7.depth = 1;*/
        }
        if (index == 8 && cam8 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = true;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam7.depth = 0;
            cam10.depth = 0;
            cam9.depth = 0;
            cam8.depth = 1;*/
        }
        if (index == 9 && cam9 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = true;
            cam10.enabled = false;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam7.depth = 0;
            cam8.depth = 0;
            cam10.depth = 0;
            cam9.depth = 1;*/
        }
        if (index == 10 && cam10 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = true;
            cam11.enabled = false;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam7.depth = 0;
            cam8.depth = 0;
            cam9.depth = 0;
            cam10.depth = 1;*/
        }
        if (index == 11 && cam11 != null)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            cam5.enabled = false;
            cam6.enabled = false;
            cam7.enabled = false;
            cam8.enabled = false;
            cam9.enabled = false;
            cam10.enabled = false;
            cam11.enabled = true;

            /*cam1.depth = 0;
            cam2.depth = 0;
            cam3.depth = 0;
            cam4.depth = 0;
            cam5.depth = 0;
            cam6.depth = 0;
            cam7.depth = 0;
            cam8.depth = 0;
            cam9.depth = 0;
            cam10.depth = 1;*/
        }
        text.text = "CAM " + index;

    }
}
