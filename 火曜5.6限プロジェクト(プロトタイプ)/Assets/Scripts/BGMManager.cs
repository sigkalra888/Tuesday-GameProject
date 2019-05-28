using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        bgmAudioSource.clip = bgm[0];
        bgmAudioSource.Play();
    }
}
