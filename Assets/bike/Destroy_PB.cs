using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_PB : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject test;
    void Start()
    {
        if (Botan_PB.flag_p != 2)
        {
            Destroy(test);
        }
    }

}
