using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OuenText : MonoBehaviour
{
    // UI Text指定用
    public Text TextFrame;
    public Text rank;

    // Start is called before the first frame update
    void Start()
    {
        TextFrame.text = string.Format("あなたの応援回数{0}",Ouen.num_o);
        if (Ouen.num_o < 3)
        {
            rank.text = string.Format("C");
        }else if (Ouen.num_o < 6)
        {
            rank.text = string.Format("B");
        }else if (Ouen.num_o < 9)
        {
            rank.text = string.Format("A");
        }else
        {
            rank.text = string.Format("S");
        }
    }


}
