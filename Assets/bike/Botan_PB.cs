using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botan_PB : MonoBehaviour
{

    public GameObject Bike;
  //  public GameObject item;
    private all spd;
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        spd = Bike.GetComponent<all>();
        spd.set(2);
        Debug.Log("2押された!");  // ログを出力
                              // Debug.Log(Botan_all.flag_p);
                              //SceneManager.LoadSceneAsync("Main");
    }
}