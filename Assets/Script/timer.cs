using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static int flag_stop = 0;
    public static float CountDownTime=10.0F;
    public Text TextCountDown;
    public GameObject goal;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Start_Shori.flag_start == 1)
        {
        if(CountDownTime > 0)
        {
        flag_stop = 1;//カウントダウン中
        TextCountDown.text = String.Format("{0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;
        }
   
        if(CountDownTime < 0)
        {
            TextCountDown.text = String.Format("START!");
            goal.SetActive(true);
            flag_stop = 2;//レーススタート
        }
        }
}
}
