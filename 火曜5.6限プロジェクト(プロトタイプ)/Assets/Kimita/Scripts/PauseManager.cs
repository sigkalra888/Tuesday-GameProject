using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
    public bool isPause = false;
    bool StartGame = true;
    public Canvas pauseCanvas;
    public Canvas StartCanvas;

    public bool Pause{
        get{ return isPause; }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
     
    }
    public void Setting()
    {
        StartGame = false;
        StartCanvas.gameObject.SetActive(false);
        OffPause();
    }
    private void Update()
    {
        if (!isPause)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && GameManager.instance.NowStatus == GameManager.GameStatus.Game)
            {
                OnPause();
                pauseCanvas.gameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Escape) && GameManager.instance.NowStatus == GameManager.GameStatus.Title)
            {
                Application.Quit();
            }
        }
    }
    public void OnPause()
    {
        isPause = true;
    }
    public void OffPause()
    {
        isPause = false;
    }
    public void Contenue()
    {
        OffPause();
        pauseCanvas.gameObject.SetActive(false);
    }
    public void TitleMove()
    {
        OffPause();
        pauseCanvas.gameObject.SetActive(false);
        StartGame = true;
        GameManager.instance.NowStatus = GameManager.GameStatus.Title;
        SceneManager.instance.MoveTitle();
    }
}
