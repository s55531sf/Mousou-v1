using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normalmode : MonoBehaviour
{
    public GameObject obj;


    // Update is called once per frame
    void Update()
    {
        if (Botan_VR.flag_vr == 1)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }
}
