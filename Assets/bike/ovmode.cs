using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovmode : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public GameObject mode;

    void Start()
    {
        if (Botan_OR.flag_p == 3||Botan_OB.flag_p==4)
        {
            Destroy(red);
            Destroy(blue);
            Destroy(mode);
        }
    }

}
