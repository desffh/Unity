using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject food;

    [SerializeField] GameObject clone; // ���ӿ�����Ʈ �����ϱ� ���� ��������

    [SerializeField] float time;

    private void Update()
    {
        // time�� deltaTime ����
        time += Time.deltaTime;

        if(time >= 5.0f)
        {
            clone = Instantiate(food);

            time = 0.0f;
        }
    }

    //[SerializeField] GameObject [] foods;
    //
    //[SerializeField] GameObject clone;
    //
    //[SerializeField] int count = 0;
    //
    //WaitForSeconds waitForSecond = new WaitForSeconds(5.0f);
    //
    //private void Start()
    //{
    //    StartCoroutine(Create());
    //}
    //IEnumerator Create()
    //{
    //    while (count < foods.Length)
    //    {
    //        if(clone == null) // ������Ʈ�� ���ٸ�
    //        {
    //            clone = Instantiate(foods[count++]);
    //        }
    //        yield return waitForSecond;
    //    }        
    //}


}
