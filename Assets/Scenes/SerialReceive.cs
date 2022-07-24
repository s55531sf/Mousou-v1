using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerialReceive : MonoBehaviour
{
    //https://qiita.com/yjiro0403/items/54e9518b5624c0030531
    //上記URLのSerialHandler.cのクラス
    public SerialHandler serialHandler;
    GameObject idou;
    idou ugoke;

    int a = 0;
    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
    }

    //受信した信号(message)に対する処理
    void OnDataReceived(string message)
    {
        var data = message.Split(
                new string[] { "\n" }, System.StringSplitOptions.None);
        try
        {
            Debug.Log(data[0]);//Unityのコンソールに受信データを表示
            a = int.Parse(data[0]);
            ugoke.Speed = a;
            Debug.Log("a");
            Debug.Log(a);

        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);//エラーを表示
        }
    }
}