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
    public RectTransform ouen6;
    public RectTransform ouen7;
    public RectTransform ouen8;
    public RectTransform ouen9;
    public RectTransform ouen10;
    public static float kazu_o = 0;
    int flag_o = 0;

    void Start()
    {
        InvokeRepeating("down", 1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        ouen1.position += new Vector3(-1.5f, 0, 0);
        ouen2.position += new Vector3(-1.5f, 0, 0);
        ouen3.position += new Vector3(-1.5f, 0, 0);
        ouen4.position += new Vector3(-1.5f, 0, 0);
        ouen5.position += new Vector3(-1.5f, 0, 0);
        ouen6.position += new Vector3(-1.5f, 0, 0);
        ouen7.position += new Vector3(-1.5f, 0, 0);
        ouen8.position += new Vector3(-1.5f, 0, 0);
        ouen9.position += new Vector3(-1.5f, 0, 0);
        ouen10.position += new Vector3(-1.5f, 0, 0);
        //ouen1.position = new Vector3(-488, 132, 0);
    }

    void down()
    {
        if (kazu_o > 0)
        {
            kazu_o--;
            Debug.LogWarning("down");
            Debug.LogWarning(kazu_o);

        }
    }

    public void ouenflag()
    {
        kazu_o += 1;
        flag_o++;
        Debug.Log("kazu_o");
        Debug.Log(kazu_o);
        if (flag_o == 1)
        {
            ouen1.position = new Vector3(2200, 300, 92);
        }
        else if (flag_o == 2)
        {
            ouen2.position = new Vector3(2200, 400, 92);
        }
        else if (flag_o == 3)
        {
            ouen3.position = new Vector3(2200, 500, 92);
        }
        else if (flag_o == 4)
        {
            ouen4.position = new Vector3(2200, 600, 92);
        }
        else if (flag_o == 5)
        {
            ouen5.position = new Vector3(2200, 800, 92);

        }
        else if (flag_o == 6)
        {
            ouen6.position = new Vector3(2200, 700, 92);

        }
        else if (flag_o == 7)
        {
            ouen7.position = new Vector3(2200, 400, 92);

        }
        else if (flag_o == 8)
        {
            ouen8.position = new Vector3(2200, 900, 92);

        }
        else if (flag_o == 9)
        {
            ouen9.position = new Vector3(2200, 1000, 92);

        }
        else if (flag_o == 10)
        {
            ouen10.position = new Vector3(2200, 300, 92);
            flag_o = 1;
        }

    }
}
