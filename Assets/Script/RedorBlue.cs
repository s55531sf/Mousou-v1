using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedorBlue : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    // Start is called before the first frame update
    void Start()
    {
        if (Botan_PR.flag_p == 1) //Redplayer�I��
        {
            red.SetActive(true);
        }
        else if (Botan_PB.flag_p==2 ) //BluePlayer�I��
        {
            blue.SetActive(true);
        }
    }

    
}
