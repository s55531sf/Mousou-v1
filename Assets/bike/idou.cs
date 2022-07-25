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
    int a;

	void Start()
    {
	  speed = 0;
	  a = 0;
    }
	void Update()
	{

		if (isLocal == false)
        {
			return;
        }
		//カメラはプレイヤーと同じ位置にする
		mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y+4, transform.position.z + zAdjust-5);
		Maker.transform.position = new Vector3(transform.position.x+30, transform.position.y + 100, transform.position.z + zAdjust);
		//TrackingSpace.transform.position = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z + zAdjust - 5);


		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(0, 50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, 50 * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(0, -50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, -50 * Time.deltaTime, 0);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			speed -= 1;
			a = 0;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			if(speed < 0)
            {
				speed++;
            }
		}
		transform.Translate(speed/1000, 0, 0);
		a++;
        if (a > 2000)
        {
			if(speed < 0)
            {
				speed++;
            }
			a = 0;
        }
	}
public void speedup() {
	speed += -10;
}

	public void speedset(int amount)
	{
		speed = amount;
	}
}


