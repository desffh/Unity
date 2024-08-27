using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject [] foods;

    [SerializeField] GameObject clone; // ���ӿ�����Ʈ �����ϱ� ���� ��������

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
            if(clone == null) // ������Ʈ�� ���ٸ�
            {
                clone = Instantiate(foods[count++]);
            }
            yield return waitForSecond;
        }
       
    }


}
