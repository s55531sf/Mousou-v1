using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
public class PlayerTurn : MonoBehaviour 
{          //メインカメラ格納用
    private GameObject playerObject;            //回転の中心となるプレイヤー格納用
    public float rotateSpeed = 2.0f;   //回転の速さ
    float tmp = 0;

    //呼び出し時に実行される関数
    void Start()
    {
        //メインカメラとユニティちゃんをそれぞれ取得
        //mainCamera = Camera.main.gameObject;
        playerObject = GameObject.Find("Player");
    }


    //単位時間ごとに実行される関数
    void Update()
    {
        //rotateCameraの呼び出し
        rotateCamera();
    }

    //カメラを回転させる関数
    private void rotateCamera()
    {
        //Vector3でX,Y方向の回転の度合いを定義
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * rotateSpeed, 0);
        tmp += Input.GetAxis("Mouse Y") * rotateSpeed;
        //transform.RotateAround()をしようしてメインカメラを回転させる
        transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        if (-90 < tmp && tmp < 90)
        {
        transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
        }
        else if (tmp > 90)
        {
            tmp = 90;
        }else if(tmp < -90)
        {
            tmp = -90;
        }

    }
}