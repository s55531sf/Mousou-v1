using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPDup : MonoBehaviour
{

    public GameObject Bike;
    public GameObject item;
    private idou spd;

    void Update()
    {
        Vector3 aaa = Bike.transform.position;
        float dis = Vector3.Distance(aaa, this.transform.position);
        spd = Bike.GetComponent<idou>();

        if (dis < 4.6f)
        {
            spd.speedup();
            Debug.Log("aaa");
            Destroy(item);
        }
    }

}
