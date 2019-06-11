using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : SingletonMonoBehaviour<TimerManager>
{
    public float Count { get; private set; } = 0;
    bool set;
    // Start is called before the first frame update
    void Start()
    {
        Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Count >= 80f && !set) { GameObject.Find("Main Camera").GetComponent<CameraController>().CameraSizeChange(); set = true; }
        if (PauseManager.instance.Pause) return;
        if (GameManager.instance.NowStatus == GameManager.GameStatus.Game)Count += Time.deltaTime;
    }
    public void ResetCount()
    {
        Count = 0;
    }
}
