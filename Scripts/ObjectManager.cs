using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] gameObjects;
   

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
        for(int i =0;i<gameObjects.Length;i++)
        {
            if (gameObjects[i] != null)
                canChangeScene = false;
            Debug.Log(gameObjects[i]);
        }
        if(canChangeScene)
        {
            SceneManager.LoadScene("Nighttime");
        }
    }
}
