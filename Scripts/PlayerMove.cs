using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed; //moveSpeed 선언
    public float jumpRange=100f; //jumpRange 선언 및 설정 그러나 public이므로 바꿀 수 있음
    private Rigidbody2D rigid;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>(); //Animator 불러오기

    }

    void Awake()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();  //rigidbody 를 rigid에 할당
    }

    void Update()  //애니메이터의 구현과 플레이어 움직임 
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(h * moveSpeed * Time.deltaTime, 0,0);

        anim.SetBool("Run", h != 0);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
            anim.SetTrigger("Jump");
        }
    }

    private void jump()
    {
        
        {
            rigid.AddForce(Vector2.up * jumpRange); //하늘을 바라보는 방향으로 힘을 가하라 즉, 점프하고 돌아오기 위한 구현
        }
        
    }
}
