using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Shori : MonoBehaviour
{
    public GameObject Bike;
    public GameObject item;
    public GameObject red;
    public GameObject blue;

    public static int flag_start = 0;
    float num = 0;

    void Update()
    {
       if(flag_start == 1)
        {
            return;
        }
        Vector3 aaa = Bike.transform.position;
        float dis = Vector3.Distance(aaa, this.transform.position);

        if (dis > 0 && dis < 5000)
        {
            flag_start = 1;
            if (Botan_PR.flag_p == 1) //RedPlayer選択
            {
                Vector3 angle = red.transform.eulerAngles;               //初期値移動＋向き前方へ
                red.transform.position= new Vector3(19.0f,4.0f,-75.0f);
                angle.y = 90.0f;
                red.transform.eulerAngles = angle;
            }
            else if (Botan_PB.flag_p == 2) //BluePlayer選択
            {
                Vector3 angle = blue.transform.eulerAngles;
                blue.transform.position=new Vector3(23.0f, 4.0f, -75.0f);
                blue.transform.Rotate(0, 90, 0);
                angle.y = 90.0f;
                blue.transform.eulerAngles = angle;
            }
            Destroy(item);
        }
    }
}
