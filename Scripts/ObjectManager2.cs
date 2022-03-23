using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectManager2 : MonoBehaviour
{
    public GameObject[] gameObjects; //배열 선언
    void Start()
    {
      
    }
    public void ChangeScene(string sceneName)
    {

    }


    void Update()
    {
        ChangeSceneAfterAllRemove(); 
    }
    public void ChangeSceneAfterAllRemove()
    {
        bool canChangeScene = true;  
        for (int i = 0; i < gameObjects.Length; i++) //계속해서 오브젝트들의 개수를 확인
        {
            if (gameObjects[i] != null)
                canChangeScene = false;   //게임 오브젝트들이 "null"이라면 씬전환
            Debug.Log(gameObjects[i]);
        }

        if (canChangeScene)   //씬전환
        {
            SceneManager.LoadScene("End");
        }
    }

}
