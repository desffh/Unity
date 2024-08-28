using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] AudioSource effectAudioSource;

    private void Awake()
    {
        if(instance == null)
        { 
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }

        effectAudioSource = GetComponentInChildren<AudioSource>();
    }

    public void Listen(AudioClip audioClip)
    {
        effectAudioSource.PlayOneShot(audioClip);
    }
}
