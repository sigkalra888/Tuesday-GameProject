using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public enum GameStatus
    {
        Title,
        Game,
        Result,
    }

    bool GameOver= false;
    public GameStatus NowStatus;
    
    private void Start()
    {
        GameOver = false;
        DontDestroyOnLoad(gameObject);
        NowStatus = GameStatus.Title;
    }
    // Update is called once per frame
    void Update()
    {
        switch (NowStatus)
        {
            case GameStatus.Title:
                if (Input.GetMouseButtonDown(0))
                {
                    SEManager.instance.SEPlay(0);
                    NowStatus = GameStatus.Game;
                    PauseManager.instance.StartCanvas.gameObject.SetActive(true);
                    PauseManager.instance.OnPause();
                    SceneManager.instance.MoveGame();

                    GameObject.Find("BGM").GetComponent<BGMManager>().PlayMusic();
                }
                break;
            case GameStatus.Game:
                float count = TimerManager.instance.Count;
                if (Input.GetMouseButtonDown(0)&&PauseManager.instance.Pause)
                {
                    PauseManager.instance.Setting();
                }
                if (count <= 180 && GameOver)
                {
                    NowStatus = GameStatus.Result;
                    SceneManager.instance.MoveResult();
                }
                else if(count >= 180)
                {
                    NowStatus = GameStatus.Result;
                    SceneManager.instance.MoveResult();
                }
                break;
            case GameStatus.Result:
                if (Input.GetMouseButtonDown(0))
                {
                }
                break;
        }
    }
    public void GetGameOver()
    {
        GameOver = true;
    }


}
