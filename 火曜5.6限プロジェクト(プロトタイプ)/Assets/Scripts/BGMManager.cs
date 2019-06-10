using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    [SerializeField] private GameObject bgmManager;

    [SerializeField] private AudioClip[] bgm;

    private AudioSource[] bgmAudioSource;

    private void Awake()
    {
        DontDestroyOnLoad(bgmManager);
        bgmAudioSource[0] = gameObject.GetComponent<AudioSource>();
        bgmAudioSource[1] = gameObject.GetComponent<AudioSource>();
    }
    public void BGM()
    {
        if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Title")
        {
            bgmAudioSource[0].clip = bgm[0];
            bgmAudioSource[0].Play();
        }
        else if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Main")
        {
            bgmAudioSource[1].clip = bgm[1];
            bgmAudioSource[1].Play();
        }
        else
        {
            bgmAudioSource[0].Stop();
            bgmAudioSource[1].Stop();
        }
    }
}
