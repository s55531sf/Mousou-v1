using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEtest : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void seplay()
    {

        //��(sound1)��炷
        Debug.LogWarning("SE");
        audioSource.PlayOneShot(sound1);
        
    }
}