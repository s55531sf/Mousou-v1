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
    public GameObject ouen1b;
    public GameObject ouen2b;
    public GameObject ouen3b;
    public GameObject ouen4b;
    public GameObject ouen5b;
    public GameObject ouen6b;
    public GameObject ouen7b;
    public GameObject ouen8b;
    public GameObject ouen9b;
    public GameObject ouen10b;



    public void Start()
    {
        InvokeRepeating("down", 1, 20);
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
                ouen1b.SetActive(true);
                ouen2b.SetActive(false);
                ouen3b.SetActive(false);
                ouen4b.SetActive(false);
                ouen5b.SetActive(false);
                ouen6b.SetActive(false);
                ouen7b.SetActive(false);
                ouen8b.SetActive(false);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);
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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(false);
                ouen4b.SetActive(false);
                ouen5b.SetActive(false);
                ouen6b.SetActive(false);
                ouen7b.SetActive(false);
                ouen8b.SetActive(false);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);
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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(false);
                ouen5b.SetActive(false);
                ouen6b.SetActive(false);
                ouen7b.SetActive(false);
                ouen8b.SetActive(false);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);
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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(true);
                ouen5b.SetActive(false);
                ouen6b.SetActive(false);
                ouen7b.SetActive(false);
                ouen8b.SetActive(false);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);
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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(true);
                ouen5b.SetActive(true);
                ouen6b.SetActive(false);
                ouen7b.SetActive(false);
                ouen8b.SetActive(false);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);

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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(true);
                ouen5b.SetActive(true);
                ouen6b.SetActive(true);
                ouen7b.SetActive(false);
                ouen8b.SetActive(false);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);

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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(true);
                ouen5b.SetActive(true);
                ouen6b.SetActive(true);
                ouen7b.SetActive(true);
                ouen8b.SetActive(false);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);

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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(true);
                ouen5b.SetActive(true);
                ouen6b.SetActive(true);
                ouen7b.SetActive(true);
                ouen8b.SetActive(true);
                ouen9b.SetActive(false);
                ouen10b.SetActive(false);

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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(true);
                ouen5b.SetActive(true);
                ouen6b.SetActive(true);
                ouen7b.SetActive(true);
                ouen8b.SetActive(true);
                ouen9b.SetActive(true);
                ouen10b.SetActive(false);

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
                ouen1b.SetActive(true);
                ouen2b.SetActive(true);
                ouen3b.SetActive(true);
                ouen4b.SetActive(true);
                ouen5b.SetActive(true);
                ouen6b.SetActive(true);
                ouen7b.SetActive(true);
                ouen8b.SetActive(true);
                ouen9b.SetActive(true);
                ouen10b.SetActive(true);
                kazu_o = 10;
            }
        }
    }

    public void ouenflag()
    {
        kazu_o += 1;
        Debug.LogWarning("kazu_o");
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
            ouen1b.SetActive(true);
            ouen2b.SetActive(false);
            ouen3b.SetActive(false);
            ouen4b.SetActive(false);
            ouen5b.SetActive(false);
            ouen6b.SetActive(false);
            ouen7b.SetActive(false);
            ouen8b.SetActive(false);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);
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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(false);
            ouen4b.SetActive(false);
            ouen5b.SetActive(false);
            ouen6b.SetActive(false);
            ouen7b.SetActive(false);
            ouen8b.SetActive(false);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);
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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(false);
            ouen5b.SetActive(false);
            ouen6b.SetActive(false);
            ouen7b.SetActive(false);
            ouen8b.SetActive(false);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);
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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(true);
            ouen5b.SetActive(false);
            ouen6b.SetActive(false);
            ouen7b.SetActive(false);
            ouen8b.SetActive(false);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);
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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(true);
            ouen5b.SetActive(true);
            ouen6b.SetActive(false);
            ouen7b.SetActive(false);
            ouen8b.SetActive(false);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);

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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(true);
            ouen5b.SetActive(true);
            ouen6b.SetActive(true);
            ouen7b.SetActive(false);
            ouen8b.SetActive(false);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);

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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(true);
            ouen5b.SetActive(true);
            ouen6b.SetActive(true);
            ouen7b.SetActive(true);
            ouen8b.SetActive(false);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);

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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(true);
            ouen5b.SetActive(true);
            ouen6b.SetActive(true);
            ouen7b.SetActive(true);
            ouen8b.SetActive(true);
            ouen9b.SetActive(false);
            ouen10b.SetActive(false);

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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(true);
            ouen5b.SetActive(true);
            ouen6b.SetActive(true);
            ouen7b.SetActive(true);
            ouen8b.SetActive(true);
            ouen9b.SetActive(true);
            ouen10b.SetActive(false);

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
            ouen1b.SetActive(true);
            ouen2b.SetActive(true);
            ouen3b.SetActive(true);
            ouen4b.SetActive(true);
            ouen5b.SetActive(true);
            ouen6b.SetActive(true);
            ouen7b.SetActive(true);
            ouen8b.SetActive(true);
            ouen9b.SetActive(true);
            ouen10b.SetActive(true);
            kazu_o = 10;
        }

    }
}
