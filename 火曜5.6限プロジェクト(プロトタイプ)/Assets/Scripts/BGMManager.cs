using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    [SerializeField] private GameObject bgmManager;

    [SerializeField] private AudioClip[] bgm;

    private AudioSource bgmAudioSource;

    private void Awake()
    {
        DontDestroyOnLoad(bgmManager);
        bgmAudioSource = gameObject.GetComponent<AudioSource>();
    }
    public void BGM_Start()
    {
        if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Title")
        {
            bgmAudioSource.clip = bgm[0];
            bgmAudioSource.Play();
        }
    }
}
