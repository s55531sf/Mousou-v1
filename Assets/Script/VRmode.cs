using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRmode : MonoBehaviour
{
    public GameObject obj;
 

    // Update is called once per frame
    void Update()
    {
        if (Botan_VR.flag_vr == 0) //VR mode‘I‘ð
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }
}
