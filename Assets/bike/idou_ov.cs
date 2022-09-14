using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou_ov : MonoBehaviour
{
	public GameObject mainCamera;
	public GameObject TrackingSpace;
	public GameObject Maker;
	public int zAdjust = -25;
	//public float speed;
	public int DesFlag;
	float spd = 1;
	// Start is called before the first frame update
	void Start()
    {
		spd = 300;
		if (Botan_OR.flag_p == DesFlag)
		{
			//カメラはプレイヤーと同じ位置にする
			mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			Maker.transform.position = new Vector3(transform.position.x + 30, transform.position.y + 100, transform.position.z + zAdjust);
			//mainCamera.transform.Rotate(0, transform.localEulerAngles.y, 0);
			//TrackingSpace.transform.position = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z + zAdjust - 5);

		}
	}

	void Update()
	{
		if (Botan_OR.flag_p != DesFlag)
		{
			return;

		}
		/*
		if (Botan_OR.flag_p == DesFlag)
		{
			//カメラはプレイヤーと同じ位置にする
			mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z );
			Maker.transform.position = new Vector3(transform.position.x + 30, transform.position.y + 100, transform.position.z + zAdjust);
			//mainCamera.transform.Rotate(0, transform.localEulerAngles.y, 0);
			//TrackingSpace.transform.position = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z + zAdjust - 5);

		}
		*/
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(0, 50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, 80 * Time.deltaTime, 0);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(0, 50 * Time.deltaTime, 0);
			mainCamera.transform.Rotate(0, -80 * Time.deltaTime, 0);
		}
		else if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Rotate(50 * Time.deltaTime, 0,0);
			mainCamera.transform.Rotate( -80 * Time.deltaTime,0,0);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Rotate(0, 50 * Time.deltaTime,0, 0);
			mainCamera.transform.Rotate(80 * Time.deltaTime,0,0);
		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			mainCamera.transform.Rotate(0, 90, 0);
		}
		if (Input.GetKey(KeyCode.W))
		{
			mainCamera.transform.Translate(0, 0, spd/1000);
		}
		if (Input.GetKey(KeyCode.S))
		{
			mainCamera.transform.Translate(0, 0, -spd/1000);
		}
		if (Input.GetKey(KeyCode.A))
		{
			mainCamera.transform.Translate(-spd/1000, 0, 0);
		}
		if (Input.GetKey(KeyCode.D))
		{
			mainCamera.transform.Translate(spd/1000, 0, 0);
		}
		if (Input.GetKey(KeyCode.Space))
		{
			mainCamera.transform.Translate(0,spd / 1000, 0);
		}
		if (Input.GetKey(KeyCode.LeftShift))
		{
			mainCamera.transform.Translate(0, -spd / 1000, 0);
		}
	}
}
