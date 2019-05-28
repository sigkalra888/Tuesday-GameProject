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
    private LightG light;

    //アイテムを使う関数
    public void UseItem()
    {
        light = GameObject.Find("Light").transform.GetChild(0).GetComponent<LightG>();
        //ランダムでどっちか使う
        int rand = Random.Range(0, 2);
        switch (rand)
        {
            case 0:
                light.RangeUp();
                // バッテリーの回復
                break;
            case 1:
                light.RangeUp();
                // ライトの範囲増加
                break;
            default:
                break;
        }
    }
    
    public void InstanceItem(Vector3 vec3)
    {
        int rand = Random.Range(0, 2);
        if(rand == 0)
        {
            Instantiate(Item[rand],new Vector3(vec3.x,-3.0f,0),Quaternion.identity);
        }
        else
        {
            Instantiate(Item[rand], new Vector3(vec3.x, -3.0f, 0), Quaternion.identity);
        }
    }

    public void UseBatteryHeal()
    {
        light = GameObject.Find("Light").GetComponent<LightG>();
        // バッテリーの回復
        light.RangeUp();
        return;
    }

    public void UseLightUp()
    {
        light = GameObject.Find("Light").GetComponent<LightG>();
        // ライトの範囲増加
        light.RangeUp();
        return;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
