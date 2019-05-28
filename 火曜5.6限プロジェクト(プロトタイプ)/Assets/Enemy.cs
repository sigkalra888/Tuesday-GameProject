using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private GameObject nearObj;

    // Start is called before the first frame update
    void Start()
    {
        nearObj = serchTag(gameObject, "castle");
        Debug.Log(nearObj);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyManager.instance.Move(gameObject,nearObj);
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
    //城に対する攻撃判定
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "castle")
        {
            Destroy(gameObject);
            EnemyManager.instance.DropItem();
            Debug.Log("10ダメージ");
        }
    }
}
