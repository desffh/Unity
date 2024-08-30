using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;

    [SerializeField] Vector3 direction;

    [SerializeField] Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        // ForceMode.Force : 연속적인 힘을 가해 게임 오브젝트를 움직이는 방식입니다. (무게O)
        // ForceMode.Acceleration : 연속적인 힘을 가해 게임 오브젝트를 움직이는 방식입니다. (무게X)

        //ForceMode.Impulse : 순간적인 힘을 가해 게임 오브젝트를 움직이는 방식입니다. (무게O)
        //ForceMode.VelocityChange : 순간적인 힘을 가해 게임 오브젝트를 움직이는 방식입니다. (무게X)

        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
