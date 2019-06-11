using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPOP : MonoBehaviour
{
    TimerManager TM = TimerManager.instance;
    public GameObject EnemyPrefabs;
    List<Vector3> PopPoint = new List<Vector3>();
    float Count;
    // Start is called before the first frame update
    void Start()
    {
        PopPoint.Add(new Vector3(2.8f, 2.8f, 0f));
        PopPoint.Add(new Vector3(-2.61f, 2.8f, 0f));
        PopPoint.Add(new Vector3(-12.9f, 2.8f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseManager.instance.Pause) return;
        Count += Time.deltaTime;
        if (TimerManager.instance.Count <= 80)
        {
            if (Count  >= 5)
            {
                Instantiate(EnemyPrefabs, PopPoint[Random.Range(0, 2)], Quaternion.identity);
                Count = 0;
            }
        }
        else
        {
            if (Count >= 5)
            {
                Instantiate(EnemyPrefabs, PopPoint[Random.Range(0, 3)], Quaternion.identity);
                Count = 0;
            }
        }
    }
}
