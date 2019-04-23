using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour
{
    [SerializeField] private GameObject R_Shiro;
    [SerializeField] private GameObject L_Shiro;

    [SerializeField] public int CastleLife;
    void Update()
    {
        Debug.Log(CastleLife); //確認用
    }
    //プレイヤーが触れたらライトを充電する

    //時間経過で拠点が一つ出現

    //Enemyが触れた時に拠点の耐久を減らす
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.transform.name == "Enemy")
        {
            CastleLife = CastleLife - 10;
        }
    }
}
