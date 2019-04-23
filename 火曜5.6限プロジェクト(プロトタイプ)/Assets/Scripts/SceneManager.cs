using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private BaseController _baseControllers;
    void Update()
    {
        //拠点の耐久が減った時の画面遷移処理
        if (_baseControllers.CastleLife == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Result");
        }
    }
}
