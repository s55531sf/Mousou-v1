using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPDup : MonoBehaviour
{

    public GameObject Bike;
    public GameObject item;
    private idou spd;
    private Ouen oue;

    void Update()
    {
        Vector3 aaa = Bike.transform.position;
        float dis = Vector3.Distance(aaa, this.transform.position);
        spd = Bike.GetComponent<idou>();

        if (dis < 4.6f)
        {

            spd.speedup();
           // oue.ouenflag(1);
            Debug.Log("aaa");
            Destroy(item);
        }
    }

}
