using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEtest : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void seplay()
    {

        //‰¹(sound1)‚ð–Â‚ç‚·
        Debug.LogWarning("SE");
        audioSource.PlayOneShot(sound1);
        
    }
}