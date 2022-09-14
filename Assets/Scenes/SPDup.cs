using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPDup : MonoBehaviour
{

    public GameObject Bike;
    public GameObject item;
    public GameObject ouennoyatu;
    private idou spd;
    private Ouen oue;

    void Update()
    {
        Vector3 aaa = Bike.transform.position;
        float dis = Vector3.Distance(aaa, this.transform.position);
        spd = Bike.GetComponent<idou>();
        oue = ouennoyatu.GetComponent<Ouen>();

        //if (dis < 4.6f)
        if (dis >0&&dis<5000)
        {
            spd.speedup();
            Debug.Log("aaa");
            oue.ouenflag();
            Destroy(item);
        }
    }

}
