using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botan_PR : MonoBehaviour
{
    public static int flag_p = 0;
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        flag_p = 1;
        //Debug.Log("�����ꂽ!");  // ���O���o��
        //Debug.Log(flag_p);
        SceneManager.LoadSceneAsync("Main");
    }
}