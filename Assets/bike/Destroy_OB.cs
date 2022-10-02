using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_OB : MonoBehaviour
{
    public GameObject BikeR;
    public GameObject BikeB;
    public GameObject itemR;
    public GameObject itemB;
    void Start()
    {
        if (Botan_PR.flag_p != 1)
        {
            BikeR.transform.position = new Vector3(0, -10000, 0);
           // itemR.transform.position = new Vector3(0, -100, 0);
            Debug.Log("red Destroy");
        }
        if (Botan_PB.flag_p != 2)
        {
            BikeB.transform.position = new Vector3(0, -10000, 0);
          //  itemB.transform.position = new Vector3(0, -100, 0);
            Debug.Log("blue Destroy");
        }

        Destroy(this);
    }
    void Updata()
    {
  
    }

}
