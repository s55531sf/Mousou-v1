using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemTest : MonoBehaviour
{
    public GameObject Bike;
    public GameObject item;
    //public float speed;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))

        {
            Shot();
        }
    }

    public void Shot()
    {
        GameObject arrow = (GameObject)Instantiate(item, transform.position, Bike.transform.rotation);
       // Rigidbody arrowRigidbody = arrow.GetComponent<Rigidbody>();
        //arrowRigidbody.AddForce(transform.forward * speed);
    }
}