using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    [SerializeField] private GameObject seManager;

    [SerializeField]private AudioClip[] se;

    private AudioSource seAudioSource;
    private void Awake()
    {
        DontDestroyOnLoad(seManager);
        seAudioSource = gameObject.GetComponent<AudioSource>();
    }
    public void SE()
    {
        seAudioSource.clip = se[0];
        seAudioSource.Play();
    }
}
