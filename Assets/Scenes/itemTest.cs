using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemTest : MonoBehaviour
{
    public GameObject Bike;
    public GameObject item;
    public Text TextFrame;
    public int DesFlag;
    public static int num_o=0;
    int num_s = 0;
    public int flag = 0;
    //public float speed;


    void Update()
    {

    if (Botan_OR.flag_p != DesFlag && Botan_OB.flag_p != DesFlag)  
        {
            return;

        }

        if (Input.GetKeyDown(KeyCode.Return)) //EnterÉLÅ[ì¸óÕ

        {
            if(flag==1)
            {
                num_s++;
                if (num_s == 5) 
                {
            num_o += 1;
            Debug.LogWarning("num_o");
            Debug.LogWarning(num_o);
            TextFrame.text = string.Format("{0} âÒ", num_o);
                    Shot();
                    num_s = 0;
                }
            }else if (flag == 0)
            {
            Shot();
            }
        }
    }

    public void Shot()
    {
        GameObject arrow = (GameObject)Instantiate(item, transform.position, Bike.transform.rotation);
       // Rigidbody arrowRigidbody = arrow.GetComponent<Rigidbody>();
        //arrowRigidbody.AddForce(transform.forward * speed);
    }
}