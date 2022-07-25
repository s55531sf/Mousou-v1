using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test123 : MonoBehaviour
{
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test123");
        if (Botan_PR.flag_p == 1)
        {
            Destroy(test);
        }
    }


}
