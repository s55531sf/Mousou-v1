using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botan_VR : MonoBehaviour
{
    public static int flag_vr = 0;
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        if (flag_vr == 0)
        {
             flag_vr = 1;
        }
        else
        {
            flag_vr = 0;
        }
 
    }
}
