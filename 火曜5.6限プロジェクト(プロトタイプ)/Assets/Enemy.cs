using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private GameObject nearObj;
    float hp = 2;
    private float HP
    {
        get { return hp; }
        set { hp = value; }
    }
    Vector3 pos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        nearObj = SerchTag(gameObject, "castle");
        Debug.Log(nearObj);

        Vector2 goal= EnemyManager.instance.Move(gameObject, nearObj);
        StartCoroutine(EnemyMove(goal));
        pos = Vector3.zero;
    }
    IEnumerator EnemyMove(Vector2 vec2)
    {
        while (true)
        {
            yield return new WaitForSeconds(Time.deltaTime);

            transform.position +=(PauseManager.instance.Pause)? new Vector3(0, 0, 0) : new Vector3(vec2.x, vec2.y, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
            EnemyManager.instance.DropItem(transform.position);
        }
    }

    GameObject SerchTag(GameObject nowObj, string tagName)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "castle")
        {
            
            StartCoroutine(RedSprite());
        }

    }
    IEnumerator RedSprite()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.1f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        Destroy(gameObject);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            hp -= Time.deltaTime;
        }
        if(collision.gameObject.tag == "Dento")
        {
            Vector2 goal = EnemyManager.instance.Move(gameObject, nearObj);
            if (PauseManager.instance.Pause) return;
            transform.position -= new Vector3(goal.x/2, goal.y/2, 0);
        }
    }
}
