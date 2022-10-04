using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouen_VR : MonoBehaviour
{
    public int str_o = 0;
    public static float kazu_o = 0;
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

    

    public void Start()
    {
        InvokeRepeating("down", 1, 5);
    }

    void down()
    {
        if (kazu_o > 0)
        {
            kazu_o--;
            Debug.LogWarning("down");
            Debug.LogWarning(kazu_o);
            if (kazu_o == 1)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(false);
                ouen3.SetActive(false);
                ouen4.SetActive(false);
                ouen5.SetActive(false);
                ouen6.SetActive(false);
                ouen7.SetActive(false);
                ouen8.SetActive(false);
                ouen9.SetActive(false);
                ouen10.SetActive(false);
            }
            else if (kazu_o == 2)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(false);
                ouen4.SetActive(false);
                ouen5.SetActive(false);
                ouen6.SetActive(false);
                ouen7.SetActive(false);
                ouen8.SetActive(false);
                ouen9.SetActive(false);
                ouen10.SetActive(false);
            }
            else if (kazu_o == 3)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(false);
                ouen5.SetActive(false);
                ouen6.SetActive(false);
                ouen7.SetActive(false);
                ouen8.SetActive(false);
                ouen9.SetActive(false);
                ouen10.SetActive(false);
            }
            else if (kazu_o == 4)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(true);
                ouen5.SetActive(false);
                ouen6.SetActive(false);
                ouen7.SetActive(false);
                ouen8.SetActive(false);
                ouen9.SetActive(false);
                ouen10.SetActive(false);
            }
            else if (kazu_o == 5)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(true);
                ouen5.SetActive(true);
                ouen6.SetActive(false);
                ouen7.SetActive(false);
                ouen8.SetActive(false);
                ouen9.SetActive(false);
                ouen10.SetActive(false);

            }
            else if (kazu_o == 6)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(true);
                ouen5.SetActive(true);
                ouen6.SetActive(true);
                ouen7.SetActive(false);
                ouen8.SetActive(false);
                ouen9.SetActive(false);
                ouen10.SetActive(false);

            }
            else if (kazu_o == 7)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(true);
                ouen5.SetActive(true);
                ouen6.SetActive(true);
                ouen7.SetActive(true);
                ouen8.SetActive(false);
                ouen9.SetActive(false);
                ouen10.SetActive(false);

            }
            else if (kazu_o == 8)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(true);
                ouen5.SetActive(true);
                ouen6.SetActive(true);
                ouen7.SetActive(true);
                ouen8.SetActive(true);
                ouen9.SetActive(false);
                ouen10.SetActive(false);

            }
            else if (kazu_o == 9)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(true);
                ouen5.SetActive(true);
                ouen6.SetActive(true);
                ouen7.SetActive(true);
                ouen8.SetActive(true);
                ouen9.SetActive(true);
                ouen10.SetActive(false);

            }
            else if (kazu_o == 10)
            {
                ouen1.SetActive(true);
                ouen2.SetActive(true);
                ouen3.SetActive(true);
                ouen4.SetActive(true);
                ouen5.SetActive(true);
                ouen6.SetActive(true);
                ouen7.SetActive(true);
                ouen8.SetActive(true);
                ouen9.SetActive(true);
                ouen10.SetActive(true);
                kazu_o = 10;
            }
        }
    }

    public void ouenflag()
    {
        kazu_o += 1;
        Debug.Log("kazu_o");
        Debug.Log(kazu_o);
        if (kazu_o == 1)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(false);
            ouen3.SetActive(false);
            ouen4.SetActive(false);
            ouen5.SetActive(false);
            ouen6.SetActive(false);
            ouen7.SetActive(false);
            ouen8.SetActive(false);
            ouen9.SetActive(false);
            ouen10.SetActive(false);
        }
        else if (kazu_o == 2)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(false);
            ouen4.SetActive(false);
            ouen5.SetActive(false);
            ouen6.SetActive(false);
            ouen7.SetActive(false);
            ouen8.SetActive(false);
            ouen9.SetActive(false);
            ouen10.SetActive(false);
        }
        else if (kazu_o == 3)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(false);
            ouen5.SetActive(false);
            ouen6.SetActive(false);
            ouen7.SetActive(false);
            ouen8.SetActive(false);
            ouen9.SetActive(false);
            ouen10.SetActive(false);
        }
        else if (kazu_o == 4)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(true);
            ouen5.SetActive(false);
            ouen6.SetActive(false);
            ouen7.SetActive(false);
            ouen8.SetActive(false);
            ouen9.SetActive(false);
            ouen10.SetActive(false);
        }
        else if (kazu_o == 5)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(true);
            ouen5.SetActive(true);
            ouen6.SetActive(false);
            ouen7.SetActive(false);
            ouen8.SetActive(false);
            ouen9.SetActive(false);
            ouen10.SetActive(false);

        }
        else if (kazu_o == 6)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(true);
            ouen5.SetActive(true);
            ouen6.SetActive(true);
            ouen7.SetActive(false);
            ouen8.SetActive(false);
            ouen9.SetActive(false);
            ouen10.SetActive(false);

        }
        else if (kazu_o == 7)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(true);
            ouen5.SetActive(true);
            ouen6.SetActive(true);
            ouen7.SetActive(true);
            ouen8.SetActive(false);
            ouen9.SetActive(false);
            ouen10.SetActive(false);

        }
        else if (kazu_o == 8)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(true);
            ouen5.SetActive(true);
            ouen6.SetActive(true);
            ouen7.SetActive(true);
            ouen8.SetActive(true);
            ouen9.SetActive(false);
            ouen10.SetActive(false);

        }
        else if (kazu_o == 9)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(true);
            ouen5.SetActive(true);
            ouen6.SetActive(true);
            ouen7.SetActive(true);
            ouen8.SetActive(true);
            ouen9.SetActive(true);
            ouen10.SetActive(false);

        }
        else if (kazu_o == 10)
        {
            ouen1.SetActive(true);
            ouen2.SetActive(true);
            ouen3.SetActive(true);
            ouen4.SetActive(true);
            ouen5.SetActive(true);
            ouen6.SetActive(true);
            ouen7.SetActive(true);
            ouen8.SetActive(true);
            ouen9.SetActive(true);
            ouen10.SetActive(true);
            kazu_o = 10;
        }

    }
}
