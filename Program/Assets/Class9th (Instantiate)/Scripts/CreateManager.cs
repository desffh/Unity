using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject [] foods;

    [SerializeField] GameObject clone; // 게임오브젝트 접근하기 위한 참조변수

    [SerializeField] int count = 0;
    
    WaitForSeconds waitForSecond = new WaitForSeconds(5.0f);
    
    private void Start()
    {
        StartCoroutine(Create());
    }
    IEnumerator Create()
    {
        while (count < foods.Length)
        {
            if(clone == null) // 오브젝트가 없다면
            {
                clone = Instantiate(foods[count++]);
            }
            yield return waitForSecond;
        }
       
    }


}
