using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerTransform;
    public float minHigh = -2f;  //카메라 최하 높이 지정!
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; //tag를 이용해 플레이어 찾기 
    }

    
    private void Update()
    {
        if(playerTransform.position.y>=minHigh) 
        {
            Vector3 temp=playerTransform.position;   //카메라 좌표를 현재 플레이어의 포지션에 z축으로 -1, y축으로 1 더한값으로 할당
            temp.z = -1;
            temp.y += 2;

            transform.position = temp;
             
        }
       
    }
}
