using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Arduino : MonoBehaviour
{

    int test;
    int test2;
    int test3;
    SerialPort portNo = new SerialPort("COM9", 9600);
    // Start is called before the first frame update
    void Start()
    {
        portNo.Open();
        portNo.ReadTimeout = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        if (portNo.IsOpen)
        {
            try
            {
                test = portNo.ReadByte();
                //test2 = portNo.ReadByte();
                //test3 = portNo.ReadByte();
                Debug.Log("test");
                Debug.Log(test);
                //Debug.Log("test2");
                //Debug.LogWarning(test2);
               // Debug.LogError(test3);

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}