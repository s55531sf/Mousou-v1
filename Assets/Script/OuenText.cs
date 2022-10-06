using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OuenText : MonoBehaviour
{
    // UI Text指定用
    public Text TextFrame;
    public Text rank;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        TextFrame.text = string.Format("あなたの応援回数{0}",itemTest.num_o);
        if (itemTest.num_o < 3)
        {
            rank.text = string.Format("C");//0-2
        }else if (itemTest.num_o < 6)
        {
            rank.text = string.Format("B");//3-5
        }else if (itemTest.num_o < 9)
        {
            rank.text = string.Format("A");//6-8
        }else
        {
            rank.text = string.Format("S");//9-
        }

        if (Botan_PR.flag_p == 1 || Botan_PB.flag_p == 2)//プレイヤーを選択したか否か
        {
            canvas.SetActive(false);
        }
    }


}
