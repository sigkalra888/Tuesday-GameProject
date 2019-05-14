using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : SingletonMonoBehaviour<ItemManager>
{
    public enum ItemKind{
        BatteryHeal, //バッテリーの回復
        LightRangeUp //ライトの範囲増加
    }
    public List<GameObject> Item;

    //アイテムを使う関数
    public void UseItem()
    {
        //ランダムでどっちか使う
        int rand = Random.Range(0, 2);
        switch (rand)
        {
            case 0:
                // バッテリーの回復
                break;
            case 1:
                // ライトの範囲増加
                break;
            default:
                break;
        }
    }
    
    public void InstanceItem()
    {
        int rand = Random.Range(0, 2);
        if(rand == 0)
        {
            Instantiate(Item[rand]);
        }
        else
        {
            Instantiate(Item[rand]);
        }
    }

    public void UseBatteryHeal()
    {
        // バッテリーの回復
        return;
    }

    public void UseLightUp()
    {
        // ライトの範囲増加
        return;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            InstanceItem();
        }
    }
}
