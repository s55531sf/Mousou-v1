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
        if (Botan_PR.flag_p == 1)
        {
            red.SetActive(true);
            blue.SetActive(false);
        }
        else if (Botan_PB.flag_p==2 )
        {
            blue.SetActive(true);
            red.SetActive(false);
        }
    }

    
}
