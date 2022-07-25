using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_PB : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject test;
    void Start()
    {
        Debug.Log("PB,flag");
        Debug.Log("Start.flag_p");
        if (all.flag_p != 2 && all.flag_p!=0)
        {
            Destroy(test);
        }
    }

    void Updata()
    {
       // Botan_PR.flag_p = 0;
    }

}
