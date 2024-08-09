using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    private int health;
    protected int attack;
    public int defense = 20;

    void Start()
    {
        Debug.Log("defense 변수의 값 : " + defense);
    }

}
