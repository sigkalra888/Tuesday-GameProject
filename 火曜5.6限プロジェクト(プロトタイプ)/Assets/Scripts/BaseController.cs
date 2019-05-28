using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour
{
    [SerializeField] private GameObject R_Shiro;
    [SerializeField] private GameObject L_Shiro;
    [SerializeField] private GameObject C_shiro;

<<<<<<< HEAD
    [SerializeField] public int _L_castleLife;
    [SerializeField] public int _R_castleLife;
    private float _time;
    public float _targettime;
    void Update()
    {
       // Debug.Log(CastleLife); //確認用
=======
    public int _L_castleLife;
    public int _R_castleLife;
    public int _C_castleLife;
    
    private float _time;
    public float[] _targettime = new float[2];
    void Update()
    {
        // Debug.Log(CastleLife); //確認用
>>>>>>> 721b9e45217549a7c6d762d42b04cb54da60303a
        //時間経過で拠点が一つ出現
        //仮のタイムでの作成
        _time += Time.deltaTime;
        //Debug.Log(_time);
<<<<<<< HEAD
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
=======
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
            SceneManager.LoadScene("Result");
>>>>>>> 721b9e45217549a7c6d762d42b04cb54da60303a
        }
    }
    //プレイヤーが触れたらライトを充電する
    private void LightHeal()
    {

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 721b9e45217549a7c6d762d42b04cb54da60303a
