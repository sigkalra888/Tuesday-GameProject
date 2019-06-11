using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{
    public void GameRestart()
    {
        //SceneManager.instance.MoveGame();
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");
    }
    public void GameTitle()
    {
        //SceneManager.instance.MoveTitle();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }
}
