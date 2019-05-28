using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour
{
    [SerializeField] private GameObject R_Shiro;
    [SerializeField] private GameObject L_Shiro;
    [SerializeField] private GameObject C_shiro;

    public int _L_castleLife;
    public int _R_castleLife;
    public int _C_castleLife;
    
    private float _time;
    public float[] _targettime = new float[2];
    void Update()
    {
        // Debug.Log(CastleLife); //確認用
        //時間経過で拠点が一つ出現
        //仮のタイムでの作成
        _time += Time.deltaTime;
        //Debug.Log(_time);
        if (_time >= _targettime[0])
        {
            L_Shiro.gameObject.SetActive(true);
        }
        if (_time >= _targettime[1])
        {
            C_shiro.gameObject.SetActive(true);
        }
    }
    public void CastleLife()
    {
        if (_R_castleLife == 0 || _L_castleLife == 0 || _C_castleLife == 0)
        {
            SceneManager.instance.MoveResult();
        }
    }
    //プレイヤーが触れたらライトを充電する
    private void LightHeal()
    {

    }
}