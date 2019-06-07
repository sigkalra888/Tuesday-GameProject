using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : SingletonMonoBehaviour<TimerManager>
{
    public float Count { get; private set; } = 0;

    // Start is called before the first frame update
    void Start()
    {
        Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Count += Time.deltaTime;
    }
}
