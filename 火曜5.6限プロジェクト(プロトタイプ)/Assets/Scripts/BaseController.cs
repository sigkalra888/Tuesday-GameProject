using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour
{
    [SerializeField] private GameObject R_Shiro;
    [SerializeField] private GameObject L_Shiro;

    [SerializeField] public int _L_castleLife;
    [SerializeField] public int _R_castleLife;
    private float _time;
    public float _targettime;
    void Update()
    {
        // Debug.Log(CastleLife); //確認用
        //時間経過で拠点が一つ出現
        //仮のタイムでの作成
        _time += Time.deltaTime;
        //Debug.Log(_time);
        if (_time >= _targettime)
        {
            L_Shiro.gameObject.SetActive(true);
        }
    }
    public void CastleLife()
    {
        if (_R_castleLife == 0 || _L_castleLife == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Result");
        }
    }
    //プレイヤーが触れたらライトを充電する
    private void LightHeal()
    {

    }
}