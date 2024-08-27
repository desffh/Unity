using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    public void Attack()
    {
        SoundManager.instance.Listen(audioClip);
    }


}
