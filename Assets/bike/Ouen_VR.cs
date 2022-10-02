using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouen_VR : MonoBehaviour
{
    public int str_o = 0;
    public GameObject ouen1;
    public GameObject ouen2;
    public GameObject ouen3;
    public GameObject ouen4;
    public GameObject ouen5;
    public GameObject ouen6;
    public GameObject ouen7;
    public GameObject ouen8;
    public GameObject ouen9;
    public GameObject ouen10;

    int kazu_o = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ouenflag()
    {
        kazu_o += 1;
        Debug.Log("kazu_o");
        Debug.Log(kazu_o);
        if (kazu_o == 1)
        {
           ouen1.SetActive(true);
        }
        else if (kazu_o == 2)
        {
            ouen2.SetActive(true);
        }
        else if (kazu_o == 3)
        {
            ouen3.SetActive(true);
        }
        else if (kazu_o == 4)
        {
            ouen4.SetActive(true);
        }
        else if (kazu_o == 5)
        {
            ouen5.SetActive(true);

        }
        else if (kazu_o == 6)
        {
            ouen6.SetActive(true);

        }
        else if (kazu_o == 7)
        {
            ouen7.SetActive(true);

        }
        else if (kazu_o == 8)
        {
            ouen8.SetActive(true);

        }
        else if (kazu_o == 9)
        {
            ouen9.SetActive(true);

        }
        else if (kazu_o == 10)
        {
            ouen10.SetActive(true);
            kazu_o = 1;
        }

    }
}
