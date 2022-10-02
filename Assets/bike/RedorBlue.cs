using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedorBlue : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    // Start is called before the first frame update
    void Start()
    {
        if (Botan_PR.flag_p == 1&& Botan_VR.flag_vr == 1)
        {
            red.SetActive(true);
        }
        else if (Botan_PB.flag_p==2 && Botan_VR.flag_vr == 1)
        {
            blue.SetActive(true);
        }
    }

    
}
