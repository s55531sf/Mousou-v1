using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer_R : MonoBehaviour
{
    public GameObject bike;
    public GameObject mainCamera;


 
    // Update is called once per frame
    void Update()
    {
        if (Botan_OR.flag_p != 3)
        {
           mainCamera.transform.position = bike.transform.position + new Vector3(0,1, -10);    }

        }
}
