using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{

    GameObject player; 
    public float collisionRange = 1f;

    void Start()
    {
        this.player = GameObject.FindWithTag("Player");  // 플레이어 찾기 
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.transform.tag == "Player")  // 플레이와 부딪히면
        {
            Destroy(gameObject);  // 오브젝트 파괴
        }
    }
    

}
