using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEtest : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void seplay()
    {

        //音(sound1)を鳴らす
        Debug.LogWarning("SE");
        audioSource.PlayOneShot(sound1);
        
    }
}