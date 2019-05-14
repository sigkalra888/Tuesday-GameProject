using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : SingletonMonoBehaviour<ItemManager>
{
    public enum ItemKind{
        BatteryHeal, //バッテリーの回復
        LightRangeUp //ライトの範囲増加
    }
    
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
    
    // Update is called once per frame
    void Update()
    {

    }
}
