using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holesound : MonoBehaviour{

    public AudioSource myAudioSource;
    public AudioClip myaudioclip;

    private void OnCollisionEnter(Collision collision)
    {
        myAudioSource.PlayOneShot(myaudioclip);
    }
   
    
    }
    
        
    




