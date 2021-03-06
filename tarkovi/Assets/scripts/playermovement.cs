using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float sprintMultiplier = 1.5f;
    void Start ()
    { rb = GetComponent<Rigidbody>();}
void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 moveBy = transform.right * x + transform.forward * z;

        float actualSpeed = speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            actualSpeed *= sprintMultiplier;
        }
        rb.MovePosition(transform.position + moveBy.normalized * actualSpeed * Time.deltaTime);
    }


}