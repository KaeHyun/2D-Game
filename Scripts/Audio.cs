using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play(); //audio 재생
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale==0)  //timeScale이 0이라면
        {
            GetComponent<AudioSource>().Stop();  //음악 정지
        }
    }
}
