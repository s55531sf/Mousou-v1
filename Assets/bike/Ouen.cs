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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ouen1.position += new Vector3(0.1f, 0, 0);
        ouen2.position += new Vector3(0.2f, 0, 0);
        ouen3.position += new Vector3(0.3f, 0, 0);
        ouen4.position += new Vector3(0.4f, 0, 0);
        ouen5.position += new Vector3(0.5f, 0, 0);
        //ouen1.position = new Vector3(-488, 132, 0);
    }

    public void ouenflag(int kazu_o)
    {
        if (kazu_o == 1)
        {
           ouen1.position = new Vector3(-488, 132, 0);
        }
        else if (kazu_o == 2)
        {

        }
        else if (kazu_o == 3)
        {

        }
        else if (kazu_o == 4)
        {

        }
        else if (kazu_o == 5)
        {

        }
    }
}
