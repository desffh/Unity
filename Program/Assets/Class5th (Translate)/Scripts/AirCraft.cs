using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCrapt : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 1.0f;

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize(); // 벡터의 정규화

        // P = P0 + vt
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
