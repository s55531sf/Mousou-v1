using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class Arduino : MonoBehaviour
{

    int test;
    int test2;
    int test3;
    int flag = 0;
    int handle_fir = 0;
    int handle=0;
    string aa = "COM6";
    public static int handle_dif = 0;
    public static int speed_arduino = 0;
    SerialPort portNo = new SerialPort("COM6", 9600);
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
                Debug.Log(handle_dif);

                if (test > 100)
                {
                    handle = test;
                }
                else if(test>0)
                {
                    speed_arduino = test;

                }
                if (test > 100&&flag==0)
                {
                    handle_fir = test;
                    flag = 1;
                }

                handle_dif = handle - handle_fir;
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