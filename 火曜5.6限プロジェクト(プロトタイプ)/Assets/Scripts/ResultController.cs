using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{
    public void GameRestart()
    {
        SceneManager.LoadScene("game");
    }
    public void GameTitle()
    {
        SceneManager.LoadScene("main");
    }
}
