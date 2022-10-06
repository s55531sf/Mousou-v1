using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botan_OR : MonoBehaviour
{
    public static int flag_p = 0;
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        flag_p = 3;
       //Debug.Log("押された!");  // ログを出力
      //Debug.Log(flag_p);
        SceneManager.LoadSceneAsync("Main");
    }
}