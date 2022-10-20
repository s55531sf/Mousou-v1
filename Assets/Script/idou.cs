using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoftGear.Strix.Client.Core.Auth.Message;
using SoftGear.Strix.Client.Core.Error;
using SoftGear.Strix.Client.Core.Model.Manager.Filter;
using SoftGear.Strix.Client.Core;
using SoftGear.Strix.Unity.Runtime;
using SoftGear.Strix.Net.Logging;
using SoftGear.Strix.Unity.Runtime.Event;


public class idou : StrixBehaviour
{
	public GameObject mainCamera;
	public GameObject TrackingSpace;
	public GameObject Maker;
	public int zAdjust = -25;
	public float speed;
	public float speed2;
	public int DesFlag;
	public int left = 10;
	public int right = -15;
	public GameObject OVR;
    int a;

	void Start()
    {
	  speed = 0;
	  a = 0;
    }
	void Update()
	{
		left = InputManager.value;
		right = (InputManager.value+5)*-1;
		/*
		Debug.LogWarning("left");
		Debug.LogWarning(left);
		Debug.LogWarning("right");
		Debug.LogWarning(right);
		*/
		if (isLocal == false)  //クローンか否か
        {
			Destroy(OVR);
			return;
        }

		//Debug.Log(Botan_PB.flag_p);


		if (Botan_PB.flag_p == DesFlag || Botan_PR.flag_p == DesFlag)  //プレイヤー選択したか？
        {
		//カメラはプレイヤーと同じ位置にする
		mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y+4, transform.position.z + zAdjust-5);
		Maker.transform.position = new Vector3(transform.position.x+30, transform.position.y + 100, transform.position.z + zAdjust);

		}
        else
        {
			return;
        }

		//ひだり
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(0, 50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, 50 * Time.deltaTime, 0);
		}
		//みぎ
		if (Arduino.handle_dif < right)
		{
			transform.Rotate(0, -50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, 50 * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow) )
		{
			transform.Rotate(0, -50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, -50 * Time.deltaTime, 0);
		}
		//ひだり
		if (Arduino.handle_dif > left)
		{
			transform.Rotate(0, 50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, -50 * Time.deltaTime, 0);
		}
		//かそく
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			speed -=0.2f;
			a = 0;
		}
		//げんそく
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			if(speed < 0)
            {
				speed++;
            }
		}

        if (Arduino.speed_arduino != 0&&timer.flag_stop!=1)
        {
		speed = Arduino.speed_arduino*-1; //Arduinoからspeed
        }

        if (timer.flag_stop == 1)
        {
			speed = 0;   //カウントダウン中強制停止
        }

		speed2 = speed * ((1 + (Ouen_VR.kazu_o / 10)) * (1 + (Ouen.kazu_o / 10)));
		transform.Translate(speed * ((1 + (Ouen_VR.kazu_o / 10)) * (1 + (Ouen.kazu_o / 10))) / 90, 0, 0);
		a++;
        if (a > 2000)
        {
			if(speed < 0)
            {
				speed++;   //すこしずつ減速
            }
			a = 0;
        }
	}


	public void speedset(int amount)
	{
		speed = amount;
	}
}


