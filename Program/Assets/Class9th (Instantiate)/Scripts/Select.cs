using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public void OnEnter()
    {
        Destroy(gameObject);
    }
}
