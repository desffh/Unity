using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
    [SerializeField] string[] names;
    private void Awake()
    {
        for (int i = 0; i < names.Length; i++)
        {
            Instantiate(Resources.Load<GameObject>(names[i]));
        }
    }
}
