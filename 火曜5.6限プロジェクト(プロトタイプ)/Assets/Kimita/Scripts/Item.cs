using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // アイテムが消える時間
    float lostTime = 3.0f;
    // アイテムの種類
    public ItemManager.ItemKind item;
    bool checkTenmetu;
    ItemManager ItemM = ItemManager.instance;
    
    // Start is called before the first frame update
    void Start()
    {
        lostTime = 8.0f;
        checkTenmetu = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(lostTime <= 0)
        {
            Destroy(gameObject);
        }else if (lostTime <= 4.0f&&!checkTenmetu)
        {
            StartCoroutine(Dot());
            checkTenmetu = true;
        }

        lostTime -= Time.deltaTime;
    }

    private IEnumerator Dot()
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        while (true)
        {
            yield return new WaitForSeconds(Time.deltaTime * 20);
            Color color = sr.color;
            color.a = 0.4f;
            sr.color = color;
            yield return new WaitForSeconds(Time.deltaTime * 20);
            color = sr.color;
            color.a = 1f;
            sr.color = color;
        }

    }

    // プレイヤーとの判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switch(item)
            {
                case ItemManager.ItemKind.BatteryHeal:
                    ItemM.UseBatteryHeal();
                    break;
                case ItemManager.ItemKind.LightRangeUp:
                    ItemM.UseLightUp();
                    break;
                default:
                    Debug.Log("ErrorMassage:ItemScript");
                    break;
            }
        }
    }
}
