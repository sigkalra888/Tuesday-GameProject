using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{



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

    }

    public void MoveResult()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Result");

    }

    public void MoveGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");

    }

    public void MoveMain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");

    }
}
