using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botan_OR : MonoBehaviour
{
    public static int flag_p = 0;
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        flag_p = 3;
       //Debug.Log("�����ꂽ!");  // ���O���o��
      //Debug.Log(flag_p);
        SceneManager.LoadSceneAsync("Main");
    }
}