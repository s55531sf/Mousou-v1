using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OuenText : MonoBehaviour
{
    // UI Textw’è—p
    public Text TextFrame;
    public Text rank;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        TextFrame.text = string.Format("‚ ‚È‚½‚Ì‰‰‡‰ñ”{0}",Ouen.num_o);
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

        if (Botan_PR.flag_p == 1 || Botan_PB.flag_p == 2)
        {
            canvas.SetActive(false);
        }
    }


}
