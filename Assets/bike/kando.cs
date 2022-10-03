using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kando : MonoBehaviour
{
    public GameObject input;
    public GameObject start_r;
    public GameObject start_b;
    int flag = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (flag == 0)
            {
            input.SetActive(true);
            start_r.SetActive(false);
                start_b.SetActive(false);
                flag = 1;
            }else if (flag == 1)
            {
                input.SetActive(false);
                start_r.SetActive(true);
                start_b.SetActive(true);
                flag = 0;
            }
        }  
    }
}
