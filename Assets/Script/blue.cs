using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�F��
        gameObject.GetComponent<Renderer>().material.color = Color.blue;

    }

}
