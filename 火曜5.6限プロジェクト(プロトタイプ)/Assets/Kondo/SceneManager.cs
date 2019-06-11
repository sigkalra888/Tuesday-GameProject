using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public Scene[] scenes;

    public GameObject SM;
    static public SceneManager instance;
    void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(SM);
        }
        else
        {
            Destroy(SM);
        }

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    MoveGame();
        //}
        //if (Input.GetMouseButtonDown(1))
        //{
        //    MoveResult();
        //}
    }

    public void MoveResult()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Result");

    }

    public void MoveGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");

    }

    public void MoveTitle()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");

    }
}
