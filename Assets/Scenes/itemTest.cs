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
    int num_o=0;
    //public float speed;


    void Update()
    {

    if (Botan_OR.flag_p != DesFlag && Botan_OB.flag_p != DesFlag)
        {
            return;

        }

        if (Input.GetKeyDown(KeyCode.Return))

        {
            num_o += 1;
            Shot();
        }
            TextFrame.text = string.Format("{0} ‰ñ", num_o);
    }

    public void Shot()
    {
        GameObject arrow = (GameObject)Instantiate(item, transform.position, Bike.transform.rotation);
       // Rigidbody arrowRigidbody = arrow.GetComponent<Rigidbody>();
        //arrowRigidbody.AddForce(transform.forward * speed);
    }
}