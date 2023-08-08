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

    public Animator Player;        //1. 선언 해주기

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GetComponent<Animator>();      //2. player에 animator 넣기.
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rb.velocity = moveInput * moveSpeed;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, topLeft.position.x, bottomRight.position.x),
                                               Mathf.Clamp(transform.position.y, bottomRight.position.y, topLeft.position.y),
                                               transform.position.z);   //Mathf.Clamp 뜻은 최소값과 최대값안의 범위 이외의 값을 넘지 않게 한다

        Player.SetFloat("Movement",moveInput.y);      //3. Movement에 moveinput y축 수치를 넣기! 히ㅣ히  
    }
}
