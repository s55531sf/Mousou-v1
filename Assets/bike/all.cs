using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class all : MonoBehaviour
{
    public int num;
    public static int flag_p;
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        flag_p = num;
        Debug.Log("押された!");  // ログを出力
        Debug.Log(flag_p);
        SceneManager.LoadSceneAsync("Main");
    }

    public void set(int abcd)
    {
        num = abcd;
    }
}


