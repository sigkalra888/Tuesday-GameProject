using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    [SerializeField] private GameObject seManager;

    [SerializeField]private AudioClip[] se;

    private AudioSource[] seAudioSource;
    private void Awake()
    {
        DontDestroyOnLoad(seManager);
        for (int i = 0; i < se.Length; i++)
        {
            seAudioSource[i] = gameObject.GetComponent<AudioSource>();
        }
    }
    public void SE1()
    {
        seAudioSource[0].clip = se[0];
        seAudioSource[0].Play();
    }
    public void SE2()
    {
        seAudioSource[1].clip = se[1];
        seAudioSource[1].Play();
    }
    public void SE3()
    {
        seAudioSource[2].clip = se[2];
        seAudioSource[2].Play();
    }
    public void SE4()
    {
        seAudioSource[3].clip = se[3];
        seAudioSource[3].Play();
    }
    public void SE5()
    {
        seAudioSource[4].clip = se[4];
        seAudioSource[4].Play();
    }
    public void SE6()
    {
        seAudioSource[5].clip = se[5];
        seAudioSource[5].Play();
    }
}
