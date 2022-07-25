using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_PR : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject test;
    void Start()
    {
        if (Botan_PR.flag_p != 1)
        {
            Destroy(test);
        }
    }
    void Updata()
    {
        Botan_PR.flag_p = 0;
    }

}
