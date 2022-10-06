using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mejirushi : MonoBehaviour
{
    public GameObject y1;


    // Update is called once per frame
    void Update()
    {
        if (Ouen.kazu_o > 3|| Ouen_VR.kazu_o > 3)
        {
            y1.SetActive(true);
        }
        else
        {
            y1.SetActive(false);
        }
    }
}
