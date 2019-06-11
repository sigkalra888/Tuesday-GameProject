using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{

    [SerializeField] private AudioClip[] bgm;

    private AudioSource bgmAudioSource;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        bgmAudioSource = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        Debug.Log(GameManager.instance.NowStatus);
        Debug.Log(GameManager.instance.NowStatus);
        if (GameManager.instance.NowStatus == GameManager.GameStatus.Title)
        {
            bgmAudioSource.clip = bgm[0];
        }
        else if (GameManager.instance.NowStatus == GameManager.GameStatus.Game)
        {
            bgmAudioSource.clip = bgm[1];
        }

        bgmAudioSource.Play();
    }
}
