using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Restart 버튼을 누르면 해당 장면 다시 시작하기
    }
}
