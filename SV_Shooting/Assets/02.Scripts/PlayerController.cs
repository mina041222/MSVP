using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed;

    public Vector2 moveInput;

    public Transform topLeft;
    public Transform bottomRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rb.velocity = moveInput * moveSpeed;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, topLeft.position.x, bottomRight.position.x),
                                               Mathf.Clamp(transform.position.y, bottomRight.position.y, topLeft.position.y),
                                               transform.position.z);   //Mathf.Clamp ���� �ּҰ��� �ִ밪���� ���� �̿��� ���� ���� �ʰ� �Ѵ�
    }
}
