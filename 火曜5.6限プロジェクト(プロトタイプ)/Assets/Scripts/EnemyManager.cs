using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : SingletonMonoBehaviour<EnemyManager>
{
    
    private float serchTime = 0;
    private float rad;
    private Vector2 Position;
    [SerializeField]
    private Vector2 speed = new Vector2(0.05f, 0.05f);

    public void DropItem(Vector3 vec3)
    {
        int x = Random.Range(1, 10000);
        if (x < 8000)
        {
            Debug.Log("No Drop" + x);
        }
        else
        {
            Debug.Log("Get Drop" + x);
            ItemManager.instance.InstanceItem(vec3);
        }
    }
    public Vector2 Move(GameObject enemy, GameObject nearObj)
    {
        if (serchTime >= 1.0f)
        {
            //経過時間の初期化
            serchTime = 0;
        }
        //atan2(近い城のy座標 -　初期位置のy座標,近い城のx座標 -　初期位置のx座標)
        //rad = Mathf.Atan2(nearObj.transform.position.y-enemy.transform.position.y,
        //                nearObj.transform.position.x-enemy.transform.position.x);
        float x = nearObj.transform.position.x-enemy.transform.position.x;
        float y = nearObj.transform.position.y-enemy.transform.position.y ;
        
        //現在座標をPositionに代入
        Position = enemy.transform.position;
        //radにCos,Sinを使い移動
        Position.x = speed.x * (1/x);
        Position.y = speed.y * (1/y);
        //現在座標に加減したPositonを代入
        return Position;
        //enemy.transform.position = Position;
    }
    
    public void Deceleration()
    {

    }
    public void Strengthen()
    {

    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        serchTime += Time.deltaTime;
    }
    
}
