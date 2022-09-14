using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouen : MonoBehaviour
{
    public int str_o = 0;
    public RectTransform ouen1;
    public RectTransform ouen2;
    public RectTransform ouen3;
    public RectTransform ouen4;
    public RectTransform ouen5;
    int kazu_o = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ouen1.position += new Vector3(0.3f, 0, 0);
        ouen2.position += new Vector3(0.3f, 0, 0);
        ouen3.position += new Vector3(0.3f, 0, 0);
        ouen4.position += new Vector3(0.3f, 0, 0);
        ouen5.position += new Vector3(0.3f, 0, 0);
        //ouen1.position = new Vector3(-488, 132, 0);
    }

    public void ouenflag()
    {
        kazu_o += 1;
        Debug.Log("kazu_o");
        Debug.Log(kazu_o);
        if (kazu_o == 2)
        {
           ouen1.position = new Vector3(-40, 370, 92);         
        }
        else if (kazu_o == 3)
        {
            ouen2.position = new Vector3(-90, 400, 92);
        }
        else if (kazu_o == 4)
        {
            ouen3.position = new Vector3(-110, 430, 92);
        }
        else if (kazu_o == 5)
        {
            ouen4.position = new Vector3(-80, 330, 92);
        }
        else if (kazu_o == 6)
        {
            ouen5.position = new Vector3(-60, 460, 92);
            kazu_o = 1;
        }
    }
}
