using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class Arduino : MonoBehaviour
{

    int test;
    int flag = 0;
    int handle_fir = 0;
    int handle=0;
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
                /*
                Debug.LogWarning("test");
                Debug.LogWarning(test);
                */
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
                    handle_fir = test;   //ハンドルの傾き初期値取得
                    flag = 1;
                }

                if (Input.GetKeyDown(KeyCode.Y))
                {
                    if (test > 100)
                    {
                        handle_fir = test;
                    }
                }

                Debug.LogWarning("fir");
                Debug.LogWarning(handle_fir);

                handle_dif = handle - handle_fir; //初期値からどれだけズレたか

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}