using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private GameObject nearObj;
    private float serchTime = 0;
    private float rad;
    private Vector2 Position;
    private Vector2 speed = new Vector2(0.01f, 0.01f);

    public void DropItem()
    {
        int x = Random.Range(1, 10000);
        if (x < 8000)
        {
            Debug.Log("No Drop" + x);
        }
        else
        {
            Debug.Log("Get Drop" + x);
        }
    }
    public void Move()
    {
        if (serchTime >= 1.0f)
        {
            //最も近い拠点を取得
            nearObj = serchTag(gameObject, "castle");
            //経過時間の初期化
            serchTime = 0;
        }
        //atan2(近い城のy座標 -　初期位置のy座標,近い城のx座標 -　初期位置のx座標)
        rad = Mathf.Atan2(nearObj.transform.position.y-transform.position.y,
                        nearObj.transform.position.x-transform.position.x);
        //現在座標をPositionに代入
        Position = transform.position;
        //radにCos,Sinを使い移動
        Position.x += speed.x * Mathf.Cos(rad);
        Position.y += speed.y * Mathf.Sin(rad);
        //現在座標に加減したPositonを代入
        transform.position = Position;
    }
    //城に対する攻撃判定
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "castle")
        {
            Destroy(gameObject);
            DropItem();
            Debug.Log("10ダメージ");
        }
    }
    public void Deceleration()
    {

    }
    public void Strengthen()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        nearObj = serchTag(gameObject, "castle");
    }

    // Update is called once per frame
    void Update()
    {
        serchTime += Time.deltaTime;
        Move();
    }
    GameObject serchTag(GameObject nowObj, string tagName)
    {
        float tmDis = 0; //一時変数
        float nearDis = 0; //近い城との距離
        GameObject targetObj = null; //拠点
        //配列で取得
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag(tagName))
        {
            //自身と取得した城との距離を取得
            tmDis = Vector3.Distance(obj.transform.position, nowObj.transform.position);
            //距離が0か近いときオブジェクト名取得
            if (nearDis == 0 || nearDis > tmDis)
            {
                nearDis = tmDis;
                targetObj = obj;
            }
        }
        //最も近い城を返す
        return targetObj;
    }
}
