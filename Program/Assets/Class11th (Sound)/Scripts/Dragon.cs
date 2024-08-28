using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] AudioClip audioClip;
    
    private int count = 0;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        if(count >= 10)
        {
            animator.SetTrigger("Die");
            return;
        }

        count++;

        SoundManager.instance.Listen(audioClip);
    }
    
    public void Release()
    {
        Destroy(gameObject);
    }

}
