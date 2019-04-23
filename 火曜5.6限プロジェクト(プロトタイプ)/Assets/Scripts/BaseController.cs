using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour
{
    [SerializeField] private GameObject R_Shiro;
    [SerializeField] private GameObject L_Shiro;

    [SerializeField] private int CastleLife;
    void Start()
    {

    }
    
    void Update()
    {
        Debug.Log(CastleLife);　//確認用
        //拠点の耐久がなくなったらgameover
        if (CastleLife == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Result");
        }
    }
    //Enemyが触れた時に拠点の耐久を減らす
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.transform.name == "Enemy")
        {
            CastleLife = CastleLife - 10;
        }
    }
}
